namespace Zahar.SqlClient
{
    using System;
    using System.Data;
    using System.Linq;
    using Xunit;

    public class Zahar_uspEcho01_Should
    {
        [Fact]
        public void BeReaderExecutable()
        {
            const int testRowsCount = 3;
            var client = new Zahar.Client(Constants.ZaharConnectionString);
            var factory = client.CreateDboUspEcho01ComponentFactory();
            

            factory.FirstInputParameter = 123;
            factory.SecondInputParameter = 321;

            factory.FirstTableValueParam.Populate(
                from i in Enumerable.Range(1, testRowsCount)
                select i, (i, row)=> 
                {
                    row.Id = i;
                    row.Name = $"Name {i}";
                    row.Date = new DateTime(2016, i, i);
                });

            factory.SecondTableValueParam.Populate(
                from i in Enumerable.Range(1, testRowsCount)
                select i, (i, row) =>
                {
                    row.Id = i;
                    row.Name = $"Name {i}";
                });

            using (var command = factory.BuildCommand())
            using(var reader = client.ExecuteReader(command))
            {                   
                var output = factory.BuildOutputValues(command);
                var record1 = factory.BuildRecordAdapter(reader);
                Assert.True(reader.Read());
                Assert.Equal(123, record1.Field1);
                Assert.Equal(321, record1.Field2);
                Assert.False(reader.Read());

                var record2 = record1.NextResult();                
                for (int i = 1; i < testRowsCount + 1; ++i)
                {
                    Assert.True(reader.Read());
                    Assert.Equal(i, record2.Id);
                    Assert.Equal($"Name {i}", record2.Name);
                    Assert.Equal(new DateTime(2016, i, i), record2.Date);
                }
                Assert.False(reader.Read());

                var record3 = record2.NextResult();
                for (int i = 1; i < testRowsCount + 1; ++i)
                {
                    Assert.True(reader.Read());
                    Assert.Equal(i, record3.Id);
                    Assert.Equal($"Name {i}", record3.Name);                    
                }
                
                Assert.False(reader.Read());

                reader.Close();

                Assert.Equal(123, output.FirstOutputParameter);
                Assert.Equal(321, output.SecondOutputParameter);
                Assert.Equal(-123, output.RETURN_VALUE);

            }

            Assert.Equal(ConnectionState.Closed, client.Connection.State);

            
        }
    }
}
