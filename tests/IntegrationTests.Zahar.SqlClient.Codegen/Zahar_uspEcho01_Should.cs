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
            var factory = new Zahar.ZaharCmdBuilderFactory(Constants.ZaharConnectionString);
            var builder = factory.CreateDboUspEcho01CmdBuilder();


            builder.FirstInputParameter = 123;
            builder.SecondInputParameter = 321;

            builder.FirstTableValueParam.AddRows(
                from i in Enumerable.Range(1, testRowsCount)
                select i, (i, row)=> 
                {
                    row.Id = i;
                    row.Name = $"Name {i}";
                    row.Date = new DateTime(2016, i, i);
                });

            builder.SecondTableValueParam.AddRows(
                from i in Enumerable.Range(1, testRowsCount)
                select i, (i, row) =>
                {
                    row.Id = i;
                    row.Name = $"Name {i}";
                });
            using (var connection = factory.CreateConnection())
            using (var command = builder.BuildCommand(connection))            
            {
                connection.Open();
                var reader = command.ExecuteReader();
                var output = builder.BuildOutputValues(command);
                var record1 = builder.BuildRecordAdapter(reader);
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
        }
    }
}
