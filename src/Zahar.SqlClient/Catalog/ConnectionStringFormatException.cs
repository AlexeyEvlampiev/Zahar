namespace Zahar.SqlClient.Catalog
{
    using System;
    using System.Text;

    [Serializable]
    public sealed class ConnectionStringFormatException : ProcessingCancelledException
    {
        const int ConnectionStringMaxLength = 500;

        internal ConnectionStringFormatException(string connectionString)
        {
            ConnectionString = connectionString?.Trim();
        }


        public string ConnectionString { get; }

        public override string Message
        {
            get
            {
                var connectionStringDislay = string.IsNullOrWhiteSpace(ConnectionString)
                ? string.Empty
                : ConnectionString.Trim();

                if (connectionStringDislay.Length > ConnectionStringMaxLength)
                {
                    connectionStringDislay = connectionStringDislay.Substring(0, ConnectionStringMaxLength) + "...";
                }


                var sb = new StringBuilder("Invalid connection string. Ensure that the provided SQL Server database connection string is valid.");
                sb.Append(@" An example of valid connection string: ""Data Source=[MySqlServer];Initial Catalog=MySqlDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"" ");
                sb.Append($@" Actual connection string: ""{connectionStringDislay}""");
                return sb.ToString();
            }
        }
    }
}
