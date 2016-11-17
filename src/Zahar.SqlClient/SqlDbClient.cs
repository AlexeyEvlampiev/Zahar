namespace Zahar.SqlClient
{
    /// <summary>
    /// 
    /// </summary>
    public class SqlDbClient
    {
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

        class StatementCompletedHandler : System.IDisposable
        {
            private System.Data.SqlClient.SqlCommand m_command;
            private System.IDisposable m_session;
            private SqlCommandState m_initialState;
            private bool m_disposed;

            public StatementCompletedHandler(System.Data.SqlClient.SqlCommand command, System.IDisposable session, SqlCommandState initialState)
            {
                m_command = command;
                m_session = session;
                m_initialState = initialState;
                m_command.StatementCompleted += this.OnStatementCompleted;
            }

            private void OnStatementCompleted(object sender, System.Data.StatementCompletedEventArgs e)
            {
                this.Dispose();
            }

            public void Dispose()
            {
                if (m_disposed)
                    return;

                try
                {
                    m_command.StatementCompleted -= this.OnStatementCompleted;
                    m_initialState.ApplyTo(m_command);
                    m_session.Dispose();
                    m_initialState = new SqlCommandState();
                    m_session = null;
                    m_command = null;
                }
                finally
                {
                    m_disposed = true;
                }
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
                    //if (m_transactions.Count > 0)
                    //    command.Transaction = m_transactions.Peek();
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
                    //command.Connection = this.m_connection;
                    //if (m_transactions.Count > 0)
                    //    command.Transaction = m_transactions.Peek();
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
                    //if (m_transactions.Count > 0)
                    //    command.Transaction = m_transactions.Peek();
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
                    //if (m_transactions.Count > 0)
                    //    command.Transaction = m_transactions.Peek();
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
            commandBehavior = commandBehavior & ~System.Data.CommandBehavior.CloseConnection;
            StatementCompletedHandler manager = null;
            System.IDisposable session = null;
            var initialState = new SqlCommandState(command);
            try
            {
                session = OpenSession();
                manager = new StatementCompletedHandler(command, session, initialState);
                command.Connection = Connection;
                //if (m_transactions.Count > 0)
                //    command.Transaction = m_transactions.Peek();
                return command.ExecuteReader(commandBehavior);
            }
            catch
            {
                session?.Dispose();
                manager?.Dispose();
                initialState.ApplyTo(command);
                throw;
            }
        }

        public async System.Threading.Tasks.Task<System.Data.SqlClient.SqlDataReader> ExecuteReaderAsync(
            System.Data.SqlClient.SqlCommand command,
            System.Threading.CancellationToken token, 
            System.Data.CommandBehavior commandBehavior = System.Data.CommandBehavior.Default)
        {
            commandBehavior = commandBehavior & ~System.Data.CommandBehavior.CloseConnection;
            StatementCompletedHandler handler = null;
            System.IDisposable session = null;
            var initialState = new SqlCommandState(command);
            try
            {
                session = await OpenSessionAsync(token);
                handler = new StatementCompletedHandler(command, session, initialState);
                command.Connection = Connection;
                //if (m_transactions.Count > 0)
                //    command.Transaction = m_transactions.Peek();
                return await command.ExecuteReaderAsync(commandBehavior);
            }
            catch
            {
                session?.Dispose();
                handler?.Dispose();
                initialState.ApplyTo(command);
                throw;
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
                    //if (m_transactions.Count > 0)
                    //    command.Transaction = m_transactions.Peek();
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
                    //if (m_transactions.Count > 0)
                    //    command.Transaction = m_transactions.Peek();
                    return await command.ExecuteXmlReaderAsync(token);
                }
                finally
                {
                    initialState.ApplyTo(command);
                }
            }
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
