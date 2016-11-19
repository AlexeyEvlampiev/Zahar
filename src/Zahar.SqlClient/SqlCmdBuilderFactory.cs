namespace Zahar.SqlClient
{
    /// <summary>
    /// 
    /// </summary>
    public class SqlCmdBuilderFactory
    {
        #region Private Fields

        readonly System.Func<System.Data.SqlClient.SqlConnection> m_connectionFactory;

        #endregion

        #region Ctor
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlCmdBuilderFactory"/> class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <exception cref="System.ArgumentNullException">connectionString</exception>
        public SqlCmdBuilderFactory(string connectionString)
        {
            if (ReferenceEquals(connectionString, null))
                throw new System.ArgumentNullException(nameof(connectionString));
            m_connectionFactory = () => new System.Data.SqlClient.SqlConnection(connectionString);
        }

        public SqlCmdBuilderFactory() : this("context connection=true") { }

        public SqlCmdBuilderFactory(System.Func<string> connectionStringFactory)
        {
            if (ReferenceEquals(null, connectionStringFactory))
                throw new System.ArgumentNullException(nameof(connectionStringFactory));
            this.m_connectionFactory = () =>
            {
                var connectionString = connectionStringFactory();
                var connection = new System.Data.SqlClient.SqlConnection(connectionString);
                return connection;
            };
        }

        public SqlCmdBuilderFactory(System.Func<System.Data.SqlClient.SqlConnection> connectionFactory)
        {
            if (ReferenceEquals(null, connectionFactory))
                throw new System.ArgumentNullException(nameof(connectionFactory));
            this.m_connectionFactory = connectionFactory;
        }
        #endregion

        public System.Data.SqlClient.SqlConnection CreateConnection() { return m_connectionFactory(); }
    }
}
