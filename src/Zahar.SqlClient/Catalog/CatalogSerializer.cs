namespace Zahar.SqlClient.Catalog
{
    using System;
    using System.Diagnostics;

    class CatalogSerializer : SchemaValidatingXmlSerializer<Catalog>
    {
        public CatalogSerializer(DiagnosticsCallbackScope host)
            : base(Resources.Catalog, host)
        {
        }

        protected override void OnError(string message)
        {
            throw new InvalidOperationException(message);
        }

        protected override void OnWarning(string message)
        {
            Trace.TraceWarning(message);
        }

    }
}
