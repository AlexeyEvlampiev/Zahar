﻿namespace Zahar.SqlClient
{
    using Xunit;
    using System;

    public class AdventureWorks2014_CreateDboUspGetBillOfMaterials_Should
    {
        [Fact]
        public void SupportExecutingReader()
        {
            var factory = new AdventureWorks2014Client.AdventureWorks2014CmdBuilderFactory(Constants.AdventureWorks2014ConnectionString);
            using (var connection = factory.CreateConnection())
            {
                connection.Open();
                var builder = factory.CreateDboUspGetBillOfMaterialsCmdBuilder();
                builder.StartProductID = 3;
                builder.CheckDate = new DateTime(2016, 01, 01);

                var command = builder.BuildCommand(connection);
                using (var reader = command.ExecuteReader())
                {
                    var current = builder.BuildRecordAdapter(reader);

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