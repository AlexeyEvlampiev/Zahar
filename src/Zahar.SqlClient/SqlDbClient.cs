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

        public System.Data.SqlClient.SqlConnection Connection { get; }

        public SqlDbClient(string connectionString)
        {
            if (ReferenceEquals(connectionString, null))
                throw new System.ArgumentNullException(nameof(connectionString));
            Connection = new System.Data.SqlClient.SqlConnection(connectionString);
        }

        public bool CloseSession()
        {
            if ((Connection.State & System.Data.ConnectionState.Closed) == System.Data.ConnectionState.Closed)
                return false;
            Connection.Close();
            return true;
        }

        public System.IDisposable OpenSession()
        {
            if ((Connection.State & System.Data.ConnectionState.Closed) == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
                return Disposable.Create(Connection.Close);
            }

            return Disposable.Null;
        }

        public async System.Threading.Tasks.Task<System.IDisposable> OpenSessionAsync(System.Threading.CancellationToken token)
        {
            if ((Connection.State & System.Data.ConnectionState.Closed) == System.Data.ConnectionState.Closed)
            {
                await Connection.OpenAsync(token);
                return Disposable.Create(Connection.Close);
            }

            return Disposable.Null;
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
