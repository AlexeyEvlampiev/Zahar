namespace Zahar.SqlClient.Catalog
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;

    class CatalogReader : ICatalogReader
    {
        private readonly string m_connectionString;
        private readonly DiagnosticsCallbackScope m_diagnosticsCallback;
        private readonly string DataSource;
        private readonly string Database;        
        readonly SqlDbTypeInfo m_sqlDbTypeInfo = new SqlDbTypeInfo();
        private readonly ReaderWriterLockSlim m_sessionLock = new ReaderWriterLockSlim();

        public CatalogReader(string connectionString, IDiagnosticsCallback diagnosticsCallback)
        {
            string pattern = Regex.Replace(@"(?:xis);? Max Pool Size\s*=\s*\d+ |;?$", @"\s+", @"\s+");
            connectionString = Regex.Replace(connectionString, pattern, ";Max Pool Size=10");
            m_connectionString = connectionString;
            m_diagnosticsCallback = new DiagnosticsCallbackScope( diagnosticsCallback);
            try
            {
                var connection = new SqlConnection(connectionString);
                DataSource = connection.DataSource;
                Database = connection.Database;
                //TODO: verify sever version
                using (connection)
                {
                    connection.Open();
                }
            }
            catch (SqlException ex)
            {
                var message = new StringBuilder($"Could not reach the {Database} database on server {DataSource}.");
                if (ex.Number == 18487 || ex.Number == 18488)
                {
                    message.Append(" The specified password has expired or must be reset.");
                }
                else
                {
                    message.Append(" Make sure that the specified SQL Server instance is up and running.");
                }
                m_diagnosticsCallback.Error(message.ToString());
                throw new DatabaseNotAccessibleException();
            }
            catch (ArgumentException)
            {
                var message = new StringBuilder("Invalid connection string.")
                    .Append($" Connection string: \"{m_connectionString}\"");

                m_diagnosticsCallback.Error(message.ToString());
                throw new ConnectionStringFormatException(connectionString);
            }
        }

        public override string ToString()
        {
            return $"[{DataSource}].[{Database}]";
        }


        public async Task<Catalog> ReadAsync()
        {
            using (var connection = new SqlConnection(m_connectionString))
            using (var command = new SqlCommand(Resources.CatalogQuery, connection))
            {
                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync(CommandBehavior.SequentialAccess, CancellationToken.None))
                {
                    if (!reader.Read())
                        throw new InvalidOperationException();
                    var serializer = new CatalogSerializer(m_diagnosticsCallback);
                    return serializer.Deserialize(reader.GetString(0));
                }
            }
        }

        public async Task<ProcedureInfo> ReadSpInfoAsync(string spFullName, IDictionary<string, object> session = null)
        {
            using (var connection = new SqlConnection(m_connectionString))
            using (var command = new SqlCommand(spFullName, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                await connection.OpenAsync();
                SqlCommandBuilder.DeriveParameters(command);

                var sp = new ProcedureInfo(spFullName);

                foreach (SqlParameter parameter in command.Parameters)
                {
                    var dataType = m_sqlDbTypeInfo.GetDataType(parameter.SqlDbType);
                    if (dataType == typeof(string)) {
                        parameter.Value = "a";
                    }
                    var parameterInfo = new SqlParameterInfo(parameter, dataType);
                    sp.AddParameter(parameterInfo);
                    if (false != string.IsNullOrWhiteSpace(parameter.TypeName))
                        continue;

                    string tableTypeName = new DbObjectInfo(parameter.TypeName).FullName;
                    parameter.TypeName = tableTypeName;
                    var tableTypeSchema = GetFromSession<DataTable>(tableTypeName, session);
                    if (!ReferenceEquals(tableTypeSchema, null) )
                    {      
                        parameter.Value = tableTypeSchema.Clone();
                        parameterInfo.TableTypeSchema = tableTypeSchema;
                        continue;
                    }

                    using (var loadTableValueParameterSchemaCmd = new SqlCommand())
                    {
                        loadTableValueParameterSchemaCmd.Connection = connection;
                        loadTableValueParameterSchemaCmd.CommandText =
                            $@"
                            DECLARE @t AS {tableTypeName}
                            SELECT * FROM @t
                        ";
                        using (var reader = await loadTableValueParameterSchemaCmd.ExecuteReaderAsync(CommandBehavior.SchemaOnly | CommandBehavior.KeyInfo))
                        {
                            tableTypeSchema = new DataTable(tableTypeName);
                            tableTypeSchema.Load(reader);
                            AddToSession(tableTypeName, tableTypeSchema, session);
                            parameter.Value = tableTypeSchema.Clone();
                            parameterInfo.TableTypeSchema = tableTypeSchema;
                        }
                    }
                }

                try
                {
                    DataSet schema = new DataSet();
                    var adapter = new SqlDataAdapter(command);
                    adapter.FillSchema(schema, SchemaType.Source);
                    for (int i = 0; i < schema.Tables.Count; ++i)
                    {
                        schema.Tables[i].TableName = $"{spFullName} > result {i}";
                    }

                    sp.AddResultSchemas(schema.Tables.OfType<DataTable>());
                }
                catch (SqlException ex)
                {
                    var message = new StringBuilder($"Could not retrieve {spFullName} result schema information.");
                    message.Append($" Error: {ex.Message}");
                    m_diagnosticsCallback.Error(message.ToString());
                }

                return sp;
            }
        }

        private bool AreSame(SqlCommand cmd1, SqlCommand cmd2)
        {
            var stringComparer = StringComparer.OrdinalIgnoreCase;
            if (stringComparer.Compare(cmd1.CommandText, cmd2.CommandText) != 0)
                return false;
            if (cmd1.Parameters.Count != cmd2.Parameters.Count)
                return false;
            for (int i = 0; i < cmd1.Parameters.Count; ++i)
            {
                var p1 = cmd1.Parameters[i];
                var p2 = cmd2.Parameters[i];
                if (stringComparer.Compare(p1.ParameterName, p2.ParameterName) != 0)
                    return false;
                if (p1.SqlDbType != p2.SqlDbType)
                    return false;
                if (p1.Direction != p2.Direction)
                    return false;
            }
            return true;
        }

        private T GetFromSession<T>(string key, IDictionary<string, object> session) where T : class
        {
            if (ReferenceEquals(session, null))
                return null;
            if (!m_sessionLock.TryEnterReadLock(300))
                throw new TimeoutException("Threading > failed to equire read lock.");
            try
            {
                if (session.ContainsKey(key))
                    return session[key] as T;
                return null;
            }
            finally
            {
                m_sessionLock.ExitReadLock();
            }
        }

        private void AddToSession(string key, object value, IDictionary<string, object> session)
        {
            if (ReferenceEquals(session, null))
                return;
            if (!m_sessionLock.TryEnterWriteLock(300))
                throw new TimeoutException("Threading > failed to equire write lock.");
            try
            {
                if (session.ContainsKey(key))
                    session[key] = value;
            }
            finally
            {
                m_sessionLock.ExitWriteLock();
            }
        }
    }
}
