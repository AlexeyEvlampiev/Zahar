namespace Zahar.SqlClient
{
    using System;
    using Xunit;

    public class DbObjectInfo_ctor_Should
    {
        [Fact]
        public void SetDboSchema()
        {
            var target = new DbObjectInfo();
            Assert.Equal("dbo", target.Schema, StringComparer.Ordinal);
        }

        [Fact]
        public void ParseOnePartNames()
        {
            var target = new DbObjectInfo("uspMyProcedure");
            Assert.Equal("dbo", target.Schema, StringComparer.Ordinal);
            Assert.Equal("uspMyProcedure", target.Name, StringComparer.Ordinal);

            target = new DbObjectInfo("[uspMyProcedure]");
            Assert.Equal("dbo", target.Schema, StringComparer.Ordinal);
            Assert.Equal("uspMyProcedure", target.Name, StringComparer.Ordinal);
        }

        [Fact]
        public void ParseTwoPartsFullNames()
        {
            var target = new DbObjectInfo("[dbo].uspMyProcedure");
            Assert.Equal("dbo", target.Schema, StringComparer.Ordinal);
            Assert.Equal("uspMyProcedure", target.Name, StringComparer.Ordinal);

            target = new DbObjectInfo("dbo.[uspMyProcedure]");
            Assert.Equal("dbo", target.Schema, StringComparer.Ordinal);
            Assert.Equal("uspMyProcedure", target.Name, StringComparer.Ordinal);

            target = new DbObjectInfo("[dbo].[uspMyProcedure]");
            Assert.Equal("dbo", target.Schema, StringComparer.Ordinal);
            Assert.Equal("uspMyProcedure", target.Name, StringComparer.Ordinal);

            target = new DbObjectInfo("[mySchema].uspMyProcedure");
            Assert.Equal("mySchema", target.Schema, StringComparer.Ordinal);
            Assert.Equal("uspMyProcedure", target.Name, StringComparer.Ordinal);

            target = new DbObjectInfo("mySchema.[uspMyProcedure]");
            Assert.Equal("mySchema", target.Schema, StringComparer.Ordinal);
            Assert.Equal("uspMyProcedure", target.Name, StringComparer.Ordinal);

            target = new DbObjectInfo("[mySchema].[uspMyProcedure]");
            Assert.Equal("mySchema", target.Schema, StringComparer.Ordinal);
            Assert.Equal("uspMyProcedure", target.Name, StringComparer.Ordinal);
        }

        [Fact]
        public void ParseThreePartsFullNames()
        {            
            var target = new DbObjectInfo("[myDatabase].[mySchema].[uspMyProcedure]");
            Assert.Equal("mySchema", target.Schema, StringComparer.Ordinal);
            Assert.Equal("uspMyProcedure", target.Name, StringComparer.Ordinal);
        }

        [Fact]
        public void ParseFourPartsFullNames()
        {
            var target = new DbObjectInfo("[myServer].[myDatabase].[mySchema].[uspMyProcedure]");
            Assert.Equal("mySchema", target.Schema, StringComparer.Ordinal);
            Assert.Equal("uspMyProcedure", target.Name, StringComparer.Ordinal);
        }
    }
}
