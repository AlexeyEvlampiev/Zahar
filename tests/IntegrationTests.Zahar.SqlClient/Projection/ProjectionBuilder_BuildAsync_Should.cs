namespace Zahar.SqlClient.Projection
{
    using System.Threading.Tasks;
    using Xunit;

    public class ProjectionBuilder_BuildAsync_Should
    {
        [Fact]
        public void ManageWithAdventureWorks2014()
        {
            var diagnosticsCallback = new RelayDiagnosticsCallback();
            var projection = ProjectionBuilder.Build(diagnosticsCallback, 
                "AdventureWorks2014.xml", 
                Constants.AdventureWorks2014ConnectionString);
        }

        [Fact]
        public async Task ManageWithZaharAsync()
        {
            var diagnosticsCallback = new RelayDiagnosticsCallback();
            var projection = await ProjectionBuilder.BuildAsync(diagnosticsCallback,
                "Zahar.xml",
                Constants.UseCaseDbConnectionString);
        }
    }
}
