namespace AdventureWorks2014Client
{
    using Zahar.SqlClient;
    using Xunit;
    using System;

    public class AdventureWorks2014_CreateDboUspGetBillOfMaterials_Should
    {
        [Fact]
        public void SupportExecutingReader()
        {
            var client = new Client(Constants.AdventureWorks2014ConnectionString);
            using (client.OpenSession())
            {
                var factory = client.CreateDboUspGetBillOfMaterialsComponentFactory();
                factory.StartProductID = 3;
                factory.CheckDate = new DateTime(2016, 01, 01);

                var command = factory.BuildCommand();
                using (var reader = client.ExecuteReader(command))
                {
                    var current = factory.BuildRecordAdapter(reader);

                    Assert.True(reader.Read());
                    Assert.Equal(3, current.ProductAssemblyID);
                    Assert.Equal(2, current.ComponentID);
                    Assert.Equal("Bearing Ball", current.ComponentDesc, StringComparer.OrdinalIgnoreCase);
                    Assert.Equal(10.00m, current.TotalQuantity);
                    Assert.Equal(0.0m, current.StandardCost);
                    Assert.Equal(0.0m, current.ListPrice);
                    Assert.Equal(3d, current.BOMLevel.Value);
                    Assert.Equal(0, current.RecursionLevel);

                    Assert.True(reader.Read());
                    Assert.Equal(3, current.ProductAssemblyID);
                    Assert.Equal(461, current.ComponentID);
                    Assert.Equal("Lock Ring", current.ComponentDesc, StringComparer.OrdinalIgnoreCase);
                    Assert.Equal(1.00m, current.TotalQuantity);
                    Assert.Equal(0.0m, current.StandardCost);
                    Assert.Equal(0.0m, current.ListPrice);
                    Assert.Equal(3d, current.BOMLevel.Value);
                    Assert.Equal(0, current.RecursionLevel);

                    Assert.True(reader.Read());
                    Assert.Equal(3, current.ProductAssemblyID);
                    Assert.Equal(504, current.ComponentID);
                    Assert.Equal("Cup-Shaped Race", current.ComponentDesc, StringComparer.OrdinalIgnoreCase);
                    Assert.Equal(2.00m, current.TotalQuantity);
                    Assert.Equal(0.0m, current.StandardCost);
                    Assert.Equal(0.0m, current.ListPrice);
                    Assert.Equal(3d, current.BOMLevel.Value);
                    Assert.Equal(0, current.RecursionLevel);

                    Assert.True(reader.Read());
                    Assert.Equal(3, current.ProductAssemblyID);
                    Assert.Equal(505, current.ComponentID);
                    Assert.Equal("Cone-Shaped Race", current.ComponentDesc, StringComparer.OrdinalIgnoreCase);
                    Assert.Equal(2.00m, current.TotalQuantity);
                    Assert.Equal(0.0m, current.StandardCost);
                    Assert.Equal(0.0m, current.ListPrice);
                    Assert.Equal(3d, current.BOMLevel.Value);
                    Assert.Equal(0, current.RecursionLevel);


                    Assert.False(reader.Read());
                }
            }
        }
    }
}
