namespace Zahar.SqlClient
{
    using Xunit;
    using System;
    using TransactionScript.AdventureWorks2014;
    using System.Data.SqlClient;
    using System.Transactions;

    public class AdventureWorks2014
    {
        readonly AdventureWorks2014CmdBuilderFactory
            _factory = new AdventureWorks2014CmdBuilderFactory(Constants.AdventureWorks2014ConnectionString);



        [Fact]
        public void DboUspGetBillOfMaterials()
        {
            var builder = _factory.CreateDboUspGetBillOfMaterialsCmdBuilder();
            builder.StartProductID = 3;
            builder.CheckDate = new DateTime(2016, 01, 01);
            DboUspGetBillOfMaterials(builder);

            builder = _factory.CreateDboUspGetBillOfMaterialsCmdBuilder(3, new DateTime(2016, 01, 01));
            DboUspGetBillOfMaterials(builder);
        }



        private void DboUspGetBillOfMaterials(DboUspGetBillOfMaterialsCmdBuilder builder)
        {
            using (var connection = _factory.CreateConnection())
            {
                connection.Open();
                

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


        [Fact]
        public void DboUspGetEmployeeManagers()
        {
            var builder = _factory.CreateDboUspGetEmployeeManagersCmdBuilder();
            builder.BusinessEntityID = 4;
            DboUspGetEmployeeManagers(builder);
            DboUspGetEmployeeManagers(_factory.CreateDboUspGetEmployeeManagersCmdBuilder(4));
        }
        
        private void DboUspGetEmployeeManagers(DboUspGetEmployeeManagersCmdBuilder builder)
        {
            
            using (var connection = _factory.CreateConnection())
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                builder.BuildCommand(command);
                using (var reader = command.ExecuteReader())
                {
                    var current = builder.BuildRecordAdapter(reader);
                    Assert.True(reader.Read());
                    Assert.Equal(0, current.RecursionLevel);
                    Assert.Equal(4, current.BusinessEntityID);
                    Assert.Equal("Rob", current.FirstName, StringComparer.Ordinal);
                    Assert.Equal("Walters", current.LastName, StringComparer.Ordinal);
                    Assert.Equal("/1/1/1/", current.OrganizationNode, StringComparer.Ordinal);
                    Assert.Equal("Roberto", current.ManagerFirstName, StringComparer.Ordinal);
                    Assert.Equal("Tamburello", current.ManagerLastName, StringComparer.Ordinal);

                    Assert.True(reader.Read());
                    Assert.Equal(1, current.RecursionLevel);
                    Assert.Equal(3, current.BusinessEntityID);
                    Assert.Equal("Roberto", current.FirstName, StringComparer.Ordinal);
                    Assert.Equal("Tamburello", current.LastName, StringComparer.Ordinal);
                    Assert.Equal("/1/1/", current.OrganizationNode, StringComparer.Ordinal);
                    Assert.Equal("Terri", current.ManagerFirstName, StringComparer.Ordinal);
                    Assert.Equal("Duffy", current.ManagerLastName, StringComparer.Ordinal);

                    Assert.False(reader.Read());
                }
            }
        }

        [Fact]
        public void DboUspGetManagerEmployees()
        {
            var builder = _factory.CreateDboUspGetManagerEmployeesCmdBuilder();
            builder.BusinessEntityID = 7;
            using (var connection = _factory.CreateConnection())
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                builder.BuildCommand(command);
                using (var reader = command.ExecuteReader())
                {
                    var current = builder.BuildRecordAdapter(reader);
                    Assert.True(reader.Read());
                    Assert.Equal(0, current.RecursionLevel);
                    Assert.Equal("/1/1/4/", current.OrganizationNode, StringComparer.Ordinal);
                    Assert.Equal("Roberto", current.ManagerFirstName, StringComparer.Ordinal);
                    Assert.Equal("Tamburello", current.ManagerLastName, StringComparer.Ordinal);
                    Assert.Equal(7, current.BusinessEntityID);
                    Assert.Equal("Dylan", current.FirstName, StringComparer.Ordinal);
                    Assert.Equal("Miller", current.LastName, StringComparer.Ordinal);

                    Assert.True(reader.Read());
                    Assert.Equal(1, current.RecursionLevel);
                    Assert.Equal("/1/1/4/1/", current.OrganizationNode, StringComparer.Ordinal);
                    Assert.Equal("Dylan", current.ManagerFirstName, StringComparer.Ordinal);
                    Assert.Equal("Miller", current.ManagerLastName, StringComparer.Ordinal);
                    Assert.Equal(8, current.BusinessEntityID);
                    Assert.Equal("Diane", current.FirstName, StringComparer.Ordinal);
                    Assert.Equal("Margheim", current.LastName, StringComparer.Ordinal);

                    Assert.True(reader.Read());
                    Assert.Equal(1, current.RecursionLevel);
                    Assert.Equal("/1/1/4/2/", current.OrganizationNode, StringComparer.Ordinal);
                    Assert.Equal("Dylan", current.ManagerFirstName, StringComparer.Ordinal);
                    Assert.Equal("Miller", current.ManagerLastName, StringComparer.Ordinal);
                    Assert.Equal(9, current.BusinessEntityID);
                    Assert.Equal("Gigi", current.FirstName, StringComparer.Ordinal);
                    Assert.Equal("Matthew", current.LastName, StringComparer.Ordinal);

                    Assert.True(reader.Read());
                    Assert.Equal(1, current.RecursionLevel);
                    Assert.Equal("/1/1/4/3/", current.OrganizationNode, StringComparer.Ordinal);
                    Assert.Equal("Dylan", current.ManagerFirstName, StringComparer.Ordinal);
                    Assert.Equal("Miller", current.ManagerLastName, StringComparer.Ordinal);
                    Assert.Equal(10, current.BusinessEntityID);
                    Assert.Equal("Michael", current.FirstName, StringComparer.Ordinal);
                    Assert.Equal("Raheem", current.LastName, StringComparer.Ordinal);

                    Assert.False(reader.Read());
                }
            }
        }

        [Fact]
        public void DboUspGetWhereUsedProductID()
        {
            var builder = _factory.CreateDboUspGetWhereUsedProductIDCmdBuilder();
            builder.StartProductID = 4;
            builder.CheckDate = new DateTime(2010, 12, 30);
            using (var connection = _factory.CreateConnection())
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                builder.BuildCommand(command);
                using (var reader = command.ExecuteReader())
                {
                    var current = builder.BuildRecordAdapter(reader);
                    Assert.True(reader.Read());
                    Assert.Equal(749, current.ProductAssemblyID);
                    Assert.Equal(807, current.ComponentID);
                    Assert.Equal("Road-150 Red, 62", current.ComponentDesc, StringComparer.Ordinal);
                    Assert.Equal(1.00m, current.TotalQuantity);
                    Assert.Equal(2171.2942m, current.StandardCost);
                    Assert.Equal(3578.27m, current.ListPrice);
                    Assert.Equal((short)1, current.BOMLevel);
                    Assert.Equal(1, current.RecursionLevel);


                    for (int i = 2; i < 100 && reader.Read(); ++i) { }

                    Assert.True(reader.Read());
                    Assert.Equal(807, current.ProductAssemblyID);
                    Assert.Equal(4, current.ComponentID);
                    Assert.Equal("HL Headset", current.ComponentDesc, StringComparer.Ordinal);
                    Assert.Equal(8.00m, current.TotalQuantity);
                    Assert.Equal(55.3801m, current.StandardCost);
                    Assert.Equal(124.73m, current.ListPrice);
                    Assert.Equal((short)2, current.BOMLevel);
                    Assert.Equal(0, current.RecursionLevel);


                    Assert.False(reader.Read());

                }
            }
        }

        [Fact]
        public void HumanResourcesUspUpdateEmployeeHireInfo()
        {
            var builder = _factory.CreateHumanResourcesUspUpdateEmployeeHireInfoCmdBuilder();    
            //using(new TransactionScope())        
            using (var connection = _factory.CreateConnection())
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                builder.BusinessEntityID = 1;
                builder.CurrentFlag = true;
                builder.HireDate = DateTime.Now;
                builder.JobTitle = "Test";
                builder.PayFrequency = 10;
                builder.Rate = 100;
                builder.RateChangeDate = DateTime.Now;
                builder.BuildCommand(command, connection);
                command.ExecuteNonQuery();                
            }
        }
    }
}
