namespace Zahar.SqlClient.Projection
{
    using Catalog;
    using Mapping;
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    public class ProjectionBuilder
    {
        private readonly ICatalogReader _catalogReader;
        private readonly IMappingReader _mappingReader;
        private readonly DiagnosticsCallbackScope _diagnosticsCallbackScope;

        internal ProjectionBuilder(
            ICatalogReader catalogReader,
            IMappingReader mappingReader,
            IDiagnosticsCallback diagnosticsCallbackProxy)
        {
            _catalogReader = catalogReader;
            _mappingReader = mappingReader;
            _diagnosticsCallbackScope = new DiagnosticsCallbackScope( diagnosticsCallbackProxy);
        }

        public static async Task<Projection> BuildAsync(IDiagnosticsCallback diagnosticsCallback, string mappingFile, string connectionString)
        {
            var diagnosticsCallbackScope = new DiagnosticsCallbackScope(diagnosticsCallback);
            var catalogReader = new CatalogReader(connectionString, diagnosticsCallbackScope);
            var mappingReader = new MappingReader(mappingFile, diagnosticsCallbackScope);
            var modelReader = new ProjectionBuilder(catalogReader, mappingReader, diagnosticsCallbackScope);
            return await modelReader.BuildAsync();
        }

        [DebuggerStepThrough]
        public static Projection Build(IDiagnosticsCallback diagnosticsCallback, string mappingFile, string connectionString)
        {
            return ProjectionBuilder.BuildAsync(diagnosticsCallback, mappingFile, connectionString).GetAwaiter().GetResult();
        }

        internal async Task<Projection> BuildAsync()
        {
            var session = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
            var readCatalogTask = _catalogReader.ReadAsync();
            var mapping = await _mappingReader.ReadAsync();
            var catalog = await readCatalogTask;

            var ixProcedureFullNames = new HashSet<string>(
                from schema in catalog.Schema
                where schema.Procedure != null
                from sp in schema.Procedure
                select sp.FullName
                , StringComparer.OrdinalIgnoreCase);

            if (_diagnosticsCallbackScope.ErrorsCount > 0)
                throw new NotImplementedException();

            var projection = new Projection();
            var tasks = mapping.Procedures
                .Where(sp => ixProcedureFullNames.Contains(sp.FullName))
                .Select(sp => _catalogReader.ReadSpInfoAsync(sp.FullName, session))
                .ToList();

            foreach (var sp in mapping.Procedures
                .Where(sp => false == ixProcedureFullNames.Contains(sp.FullName)))
            {
                _diagnosticsCallbackScope.Error($"{sp.FullName} could not be found.");
            }

            foreach (var task in tasks)
            {
                try
                {
                    var spInfo = await task;
                    projection.AddProcedure(spInfo);
                }
                catch (SqlException ex)
                {
                    Debug.Write(ex.Message);
                    throw;
                }
            }
            

            return projection;
        }
    }
}
