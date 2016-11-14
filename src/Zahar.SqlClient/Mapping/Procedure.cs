namespace Zahar.SqlClient.Mapping
{
    using System.Xml.Serialization;

    public partial class Procedure
    {
        [XmlIgnore]
        public string FullName => $"[{Schema}].[{Name}]";
    }
}
