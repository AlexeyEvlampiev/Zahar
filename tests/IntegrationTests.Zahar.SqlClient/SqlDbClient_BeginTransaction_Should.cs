namespace Zahar.SqlClient
{
    using Xunit;

    public class SqlDbClient_BeginTransaction_Should
    {
        [Fact]
        public void Work()
        {
            var client = new SqlDbClient(Constants.ZaharConnectionString);
            using (client.OpenSession())
            using (var transaction = client.BeginTransaction())
            using(var command = client.Connection.CreateCommand())
            {
                command.CommandText = @"PRINT 'Hello world!'";
                client.ExecuteNonQuery(command);
            }
        }
    }
}
