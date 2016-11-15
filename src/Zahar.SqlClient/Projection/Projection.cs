namespace Zahar.SqlClient.Projection
{
    using Catalog;
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    public class Projection
    {
        private ConcurrentDictionary<string, ProcedureInfo>
            _ixProceduresByFullName = new ConcurrentDictionary<string, ProcedureInfo>(StringComparer.OrdinalIgnoreCase);
        

        public IEnumerable<ProcedureInfo> Procedures => _ixProceduresByFullName.Values;

        public IEnumerable<DataTable> UserDefinedTableTypes =>
            from procedure in Procedures
            from parameter in procedure.Parameters
            let schema = parameter.TableTypeSchema
            where !ReferenceEquals(schema, null)
            group schema by schema.TableName
            into g
            select g.First();

        public void AddProcedure(ProcedureInfo info)
        {
            _ixProceduresByFullName.GetOrAdd(info.FullName, info);
        }


    }
}
