namespace Zahar.SqlClient
{
    /// <summary>
    /// 
    /// </summary>
    public class SqlCmdBuilderFactory
    {
        #region Private Fields

        readonly global::System.Func<global::System.Data.SqlClient.SqlConnection> m_connectionFactory;

        #endregion

        #region Ctor
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlCmdBuilderFactory"/> class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <exception cref="global::System.ArgumentNullException">connectionString</exception>
        public SqlCmdBuilderFactory(string connectionString)
        {
            if (ReferenceEquals(connectionString, null))
                throw new global::System.ArgumentNullException(nameof(connectionString));
            m_connectionFactory = () => new global::System.Data.SqlClient.SqlConnection(connectionString);
        }

        public SqlCmdBuilderFactory() : this("context connection=true") { }

        public SqlCmdBuilderFactory(global::System.Func<string> connectionStringFactory)
        {
            if (ReferenceEquals(null, connectionStringFactory))
                throw new global::System.ArgumentNullException(nameof(connectionStringFactory));
            this.m_connectionFactory = () =>
            {
                var connectionString = connectionStringFactory();
                var connection = new global::System.Data.SqlClient.SqlConnection(connectionString);
                return connection;
            };
        }

        public SqlCmdBuilderFactory(global::System.Func<global::System.Data.SqlClient.SqlConnection> connectionFactory)
        {
            if (ReferenceEquals(null, connectionFactory))
                throw new global::System.ArgumentNullException(nameof(connectionFactory));
            this.m_connectionFactory = connectionFactory;
        }
        #endregion

        public global::System.Data.SqlClient.SqlConnection CreateConnection() { return m_connectionFactory(); }
    }
}
