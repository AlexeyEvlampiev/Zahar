namespace Zahar.SqlClient.Mapping
{
    using System;
    using System.IO;
    using System.Xml.Schema;

    class MappingSerializer : SchemaValidatingXmlSerializer<Mapping>
    {
        public MappingSerializer(IDiagnosticsCallback host)
            : base(Resources.Zahar_SqlClient, host)
        {
        }

        static XmlSchema GetSchema(string xmlString)
        {
            return XmlSchema.Read(new StringReader(xmlString), (e, a) =>
            {
                if (a.Severity == XmlSeverityType.Error)
                {
                    throw new NotImplementedException();
                }
            });
        }
    }
}
