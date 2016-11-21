namespace Zahar.SqlClient
{
    using Xunit;

    public class SqlDbClient_BeginTransaction_Should
    {
        [Fact]
        public void Work()
        {
            var client = new SqlCmdBuilderFactory(Constants.UseCaseDbConnectionString);
            client.CreateConnection();
        }
    }
}
