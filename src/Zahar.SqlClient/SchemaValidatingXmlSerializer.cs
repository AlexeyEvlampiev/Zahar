namespace Zahar.SqlClient
{
    using System;
    using System.IO;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    abstract class SchemaValidatingXmlSerializer<T>
    {
        #region Private Fields
        private readonly DiagnosticsCallbackScope m_diagnosticsCallbackScope;
        private int m_schemaErrorsCount;
        private XmlReaderSettings m_settings;
        private XmlSerializer m_serializer;
        #endregion

        protected SchemaValidatingXmlSerializer(
            string schemaXmlString,
            IDiagnosticsCallback diagnosticsCallback)
        {
            var schema = XmlSchema.Read(new StringReader(schemaXmlString), (e, a) =>
            {
                if (a.Severity == XmlSeverityType.Error)
                {
                    throw new InvalidOperationException();
                }
            });

            m_serializer = new XmlSerializer(typeof(T));
            m_diagnosticsCallbackScope = new DiagnosticsCallbackScope(diagnosticsCallback);
            var schemas = new XmlSchemaSet();
            schemas.Add(schema);
            m_settings = new XmlReaderSettings
            {
                Schemas = schemas,
                ValidationType = ValidationType.Schema,
                ValidationFlags =
                           XmlSchemaValidationFlags.ProcessIdentityConstraints |
                           XmlSchemaValidationFlags.ReportValidationWarnings
            };
            m_settings.ValidationEventHandler +=
                delegate (object sender, ValidationEventArgs args)
                {
                    if (args.Severity == XmlSeverityType.Error)
                    {
                        this.OnError(args.Message);
                        m_schemaErrorsCount++;
                    }
                    else if (args.Severity == XmlSeverityType.Warning)
                    {
                        this.OnWarning(args.Message);
                    }
                };
        }


        public T Deserialize(string xmlString)
        {            
            using (var input = new StringReader(xmlString))
            using (var reader = XmlReader.Create(input, m_settings))
            {
                m_schemaErrorsCount = 0;
                var obj = (T)m_serializer.Deserialize(reader);
                if (m_schemaErrorsCount > 0)
                    throw new XmlValidationException();
                return obj;
            }
        }

        public T Deserialize(Stream stream)
        {
            using (var input = new StreamReader(stream))
            using (var reader = XmlReader.Create(input, m_settings))
            {
                m_schemaErrorsCount = 0;
                var obj = (T)m_serializer.Deserialize(reader);
                if (m_schemaErrorsCount > 0)
                    throw new XmlValidationException();
                return obj;
            }
        }

        protected virtual void OnError(string message)
        {
            m_diagnosticsCallbackScope.Error(message);
        }

        protected virtual void OnWarning(string message)
        {
            m_diagnosticsCallbackScope.Warning(message);
        }
    }
}
