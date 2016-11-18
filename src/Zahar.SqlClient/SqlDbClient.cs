namespace Zahar.SqlClient
{
    /// <summary>
    /// 
    /// </summary>
    public class SqlDbClient
    {
        #region Private Fields
        readonly System.Collections.Generic.Stack<System.Data.SqlClient.SqlTransaction>
            m_transactions = new System.Collections.Generic.Stack<System.Data.SqlClient.SqlTransaction>(); 
        #endregion

        #region Nested Types
        struct SqlCommandState
        {
            readonly System.Data.SqlClient.SqlConnection Connection;
            readonly System.Data.SqlClient.SqlTransaction Transaction;

            public SqlCommandState(System.Data.SqlClient.SqlCommand command)
            {
                Connection = command.Connection;
                Transaction = command.Transaction;
            }

            public void ApplyTo(System.Data.SqlClient.SqlCommand command)
            {
                command.Connection = Connection;
                command.Transaction = Transaction;
            }
        }

        #endregion

        /// <summary>
        /// Gets the underlying <see cref="System.Data.SqlClient.SqlConnection"/> object.
        /// </summary>
        public System.Data.SqlClient.SqlConnection Connection { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlDbClient"/> class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <exception cref="System.ArgumentNullException">connectionString</exception>
        public SqlDbClient(string connectionString)
        {
            if (ReferenceEquals(connectionString, null))
                throw new System.ArgumentNullException(nameof(connectionString));
            Connection = new System.Data.SqlClient.SqlConnection(connectionString);
        }

        /// <summary>
        /// Closes the underlying <see cref="System.Data.SqlClient.SqlConnection"/> object.
        /// </summary>
        /// <returns></returns>
        public bool CloseSession()
        {
            if ((Connection.State | System.Data.ConnectionState.Closed) != System.Data.ConnectionState.Closed)
                return false;
            Connection.Close();
            return true;
        }

        /// <summary>
        /// Opens the underlying <see cref="System.Data.SqlClient.SqlConnection"/> if not yet opened.
        /// </summary>
        /// <returns></returns>
        public System.IDisposable OpenSession()
        {
            if ((Connection.State | System.Data.ConnectionState.Closed) == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
                return Disposable.Create(Connection.Close);
            }

            return Disposable.Null;
        }

        /// <summary>
        /// Opens the underlying <see cref="System.Data.SqlClient.SqlConnection"/> asynchronously if not yet opened.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<System.IDisposable> OpenSessionAsync(System.Threading.CancellationToken token)
        {
            if ((Connection.State & System.Data.ConnectionState.Closed) == System.Data.ConnectionState.Closed)
            {
                await Connection.OpenAsync(token);
                return Disposable.Create(Connection.Close);
            }

            return Disposable.Null;
        }

        public int ExecuteNonQuery(System.Data.SqlClient.SqlCommand command)
        {
            using (OpenSession())
            {
                var initialState = new SqlCommandState(command);
                try
                {
                    command.Connection = this.Connection;
                    if (m_transactions.Count > 0)
                        command.Transaction = m_transactions.Peek();
                    return command.ExecuteNonQuery();
                }
                finally
                {
                    initialState.ApplyTo(command);
                }
            }
        }

        public async System.Threading.Tasks.Task<int> ExecuteNonQueryAsync(
            System.Data.SqlClient.SqlCommand command, 
            System.Threading.CancellationToken token)
        {
            using (await OpenSessionAsync(token))
            {
                var initialState = new SqlCommandState(command);
                try
                {
                    command.Connection = this.Connection;
                    if (m_transactions.Count > 0)
                        command.Transaction = m_transactions.Peek();
                    return await command.ExecuteNonQueryAsync(token);
                }
                finally
                {
                    initialState.ApplyTo(command);
                }
            }
        }

        public object ExecuteScalar(System.Data.SqlClient.SqlCommand command)
        {
            using (OpenSession())
            {
                var initialState = new SqlCommandState(command);
                try
                {
                    command.Connection = this.Connection;
                    if (m_transactions.Count > 0)
                        command.Transaction = m_transactions.Peek();
                    return command.ExecuteScalar();
                }
                finally
                {
                    initialState.ApplyTo(command);
                }
            }
        }

        public async System.Threading.Tasks.Task<object> ExecuteScalarAsync(
            System.Data.SqlClient.SqlCommand command, 
            System.Threading.CancellationToken token)
        {
            using (await OpenSessionAsync(token))
            {
                var initialState = new SqlCommandState(command);
                try
                {
                    command.Connection = this.Connection;
                    if (m_transactions.Count > 0)
                        command.Transaction = m_transactions.Peek();
                    return await command.ExecuteScalarAsync(token);
                }
                finally
                {
                    initialState.ApplyTo(command);
                }
            }
        }

        public System.Data.SqlClient.SqlDataReader ExecuteReader(
            System.Data.SqlClient.SqlCommand command,
            System.Data.CommandBehavior commandBehavior = System.Data.CommandBehavior.Default)
        {
            var initialState = new SqlCommandState(command);
            bool autoOpen = Connection.State == System.Data.ConnectionState.Closed;
            try
            {
                command.Connection = Connection;

                if (autoOpen)
                {
                    Connection.Open();
                    commandBehavior |= System.Data.CommandBehavior.CloseConnection;
                }

                var reader = command.ExecuteReader(commandBehavior);
                return reader;

            }
            catch
            {
                if (autoOpen && Connection.State != System.Data.ConnectionState.Closed)
                    Connection.Close();
                throw;
            }
            finally
            {
                initialState.ApplyTo(command);
            }
        }

        public async System.Threading.Tasks.Task<System.Data.SqlClient.SqlDataReader> ExecuteReaderAsync(
            System.Data.SqlClient.SqlCommand command,
            System.Threading.CancellationToken token, 
            System.Data.CommandBehavior commandBehavior = System.Data.CommandBehavior.Default)
        {
            var initialState = new SqlCommandState(command);
            bool autoOpen = Connection.State == System.Data.ConnectionState.Closed;
            try
            {
                command.Connection = Connection;

                if (autoOpen)
                {
                    await Connection.OpenAsync();
                    commandBehavior |= System.Data.CommandBehavior.CloseConnection;
                }

                var reader = command.ExecuteReader(commandBehavior);
                return reader;

            }
            catch
            {
                if (autoOpen && Connection.State != System.Data.ConnectionState.Closed)
                    Connection.Close();
                throw;
            }
            finally
            {
                initialState.ApplyTo(command);
            }
        }

        public System.Xml.XmlReader ExecuteXmlReader(System.Data.SqlClient.SqlCommand command)
        {
            using (OpenSession())
            {
                var initialState = new SqlCommandState(command);
                try
                {
                    command.Connection = this.Connection;
                    if (m_transactions.Count > 0)
                        command.Transaction = m_transactions.Peek();
                    return command.ExecuteXmlReader();
                }
                finally
                {
                    initialState.ApplyTo(command);
                }
            }
        }

        public async System.Threading.Tasks.Task<System.Xml.XmlReader> ExecuteXmlReaderAsync(
            System.Data.SqlClient.SqlCommand command,
            System.Threading.CancellationToken token)
        {
            using (await OpenSessionAsync(token))
            {
                var initialState = new SqlCommandState(command);
                try
                {
                    command.Connection = Connection;
                    if (m_transactions.Count > 0)
                        command.Transaction = m_transactions.Peek();
                    return await command.ExecuteXmlReaderAsync(token);
                }
                finally
                {
                    initialState.ApplyTo(command);
                }
            }
        }

        /// <summary>
        /// Starts a database transaction.
        /// </summary>
        /// <exception cref="System.Data.SqlClient.SqlException">Parallel transactions are not allowed when using Multiple Active Result Sets (MARS).</exception>
        /// <exception cref="System.InvalidOperationException">Parallel transactions are not supported.</exception>
        public ISqlTransaction BeginTransaction()
        {
            return new SqlTransactionWrapper(this.Connection.BeginTransaction(), m_transactions);
        }

        /// <summary>
        /// Starts a database transaction with the specified isolation level.
        /// </summary>
        /// <param name="iso">The isolation level under which the transaction should run.</param>
        /// <exception cref="System.Data.SqlClient.SqlException">Parallel transactions are not allowed when using Multiple Active Result Sets (MARS).</exception>
        /// <exception cref="System.InvalidOperationException">Parallel transactions are not supported.</exception>
        public ISqlTransaction BeginTransaction(System.Data.IsolationLevel iso)
        {
            return new SqlTransactionWrapper(this.Connection.BeginTransaction(iso), m_transactions);
        }

        /// <summary>
        /// Starts a database transaction with the specified transaction name.
        /// </summary>
        /// <param name="transactionName">The name of the transaction..</param>
        /// <exception cref="System.Data.SqlClient.SqlException">Parallel transactions are not allowed when using Multiple Active Result Sets (MARS).</exception>
        /// <exception cref="System.InvalidOperationException">Parallel transactions are not supported.</exception>
        public ISqlTransaction BeginTransaction(string transactionName)
        {
            return new SqlTransactionWrapper(this.Connection.BeginTransaction(transactionName), m_transactions);
        }

        /// <summary>
        /// 
        /// </summary>
        public static T ToClrValue<T>(object value)
        {
            return (ReferenceEquals(value, null) || System.DBNull.Value.Equals(value))
                    ? default(T)
                    : (T)value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static object ToSqlValue<T>(T value)
        {
            return value == null
                ? (object)System.DBNull.Value
                : value;
        }

    }
}
