namespace Zahar.SqlClient.Projection
{
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
        public void ManageWithZahar()
        {
            var diagnosticsCallback = new RelayDiagnosticsCallback();
            var projection = ProjectionBuilder.Build(diagnosticsCallback,
                "Zahar.xml",
                Constants.ZaharConnectionString);
        }
    }
}
