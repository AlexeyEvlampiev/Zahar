namespace Zahar.SqlClient
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Threading;
    using System.Threading.Tasks;

    public class SqlDbClient
    {
        #region Nested Types
        struct SqlCommandState
        {
            readonly SqlConnection Connection;
            readonly SqlTransaction Transaction;

            public SqlCommandState(SqlCommand command)
            {
                Connection = command.Connection;
                Transaction = command.Transaction;
            }

            public void ApplyTo(SqlCommand command)
            {
                command.Connection = Connection;
                command.Transaction = Transaction;
            }
        }

        class StatementCompletedHandler : IDisposable
        {
            private SqlCommand m_command;
            private IDisposable m_session;
            private SqlCommandState m_initialState;
            private bool m_disposed;

            public StatementCompletedHandler(SqlCommand command, IDisposable session, SqlCommandState initialState)
            {
                m_command = command;
                m_session = session;
                m_initialState = initialState;
                m_command.StatementCompleted += this.OnStatementCompleted;
            }

            private void OnStatementCompleted(object sender, StatementCompletedEventArgs e)
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

        public SqlConnection Connection { get; }

        public SqlDbClient(string connectionString)
        {
            if (ReferenceEquals(connectionString, null))
                throw new ArgumentNullException(nameof(connectionString));
            Connection = new SqlConnection(connectionString);
        }

        public bool CloseSession()
        {
            if ((Connection.State & ConnectionState.Closed) == ConnectionState.Closed)
                return false;
            Connection.Close();
            return true;
        }

        public IDisposable OpenSession()
        {
            if ((Connection.State & ConnectionState.Closed) == ConnectionState.Closed)
            {
                Connection.Open();
                return Disposable.Create(Connection.Close);
            }

            return Disposable.Null;
        }

        public async Task<IDisposable> OpenSessionAsync(CancellationToken token)
        {
            if ((Connection.State & ConnectionState.Closed) == ConnectionState.Closed)
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
            return (ReferenceEquals(value, null) || global::System.DBNull.Value.Equals(value))
                    ? default(T)
                    : (T)value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static object ToSqlValue<T>(T value)
        {
            return value == null
                ? (object)global::System.DBNull.Value
                : value;
        }

    }
}
