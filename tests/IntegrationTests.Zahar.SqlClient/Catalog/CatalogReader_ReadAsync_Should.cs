namespace Zahar.SqlClient.Catalog
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using Xunit;

    public class CatalogReader_ReadAsync_Should
    {
        [Fact]
        public void HandleLoadingAdventureWorks2014Catalog()
        {
            var reader = new CatalogReader(
                Constants.AdventureWorks2014ConnectionString, 
                new RelayDiagnosticsCallback(OnWarning));
            var catalog = reader.ReadAsync().GetAwaiter().GetResult();

            var comparer = StringComparer.Ordinal;
            var schemaNames = catalog.Schema.Select(s=> s.Name).ToList();
            Assert.Equal(6, schemaNames.Count);
            Assert.True(schemaNames.Contains("dbo", comparer));
            Assert.True(schemaNames.Contains("HumanResources", comparer));
            Assert.True(schemaNames.Contains("Person", comparer));
            Assert.True(schemaNames.Contains("Production", comparer));
            Assert.True(schemaNames.Contains("Sales", comparer));
            Assert.True(schemaNames.Contains("Purchasing", comparer));

            var spFullNames = new HashSet<string>(
                catalog.Schema.Where(s=> s.Procedure != null).SelectMany(s => s.Procedure).Select(p => p.FullName), 
                StringComparer.OrdinalIgnoreCase);
            Assert.Equal(10, spFullNames.Count);
            Assert.True(spFullNames.Contains("[dbo].[uspGetBillOfMaterials]"));
            Assert.True(spFullNames.Contains("[dbo].[uspGetEmployeeManagers]"));
            Assert.True(spFullNames.Contains("[dbo].[uspGetWhereUsedProductID]"));
            Assert.True(spFullNames.Contains("[dbo].[uspGetManagerEmployees]"));
            Assert.True(spFullNames.Contains("[dbo].[uspLogError]"));
            Assert.True(spFullNames.Contains("[dbo].[uspPrintError]"));
            Assert.True(spFullNames.Contains("[dbo].[uspSearchCandidateResumes]"));
            Assert.True(spFullNames.Contains("[HumanResources].[uspUpdateEmployeeHireInfo]"));
            Assert.True(spFullNames.Contains("[HumanResources].[uspUpdateEmployeeLogin]"));
            Assert.True(spFullNames.Contains("[HumanResources].[uspUpdateEmployeePersonalInfo]"));


        }

        void OnWarning(string message)
        {
            Debug.Write(message);
        }
    }
}
