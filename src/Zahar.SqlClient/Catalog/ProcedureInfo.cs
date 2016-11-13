

namespace Zahar.SqlClient.Catalog
{
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics;

    public class ProcedureInfo : DbObjectInfo
    {
        #region Private Fields
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        readonly List<SqlParameterInfo> _parameters = new List<SqlParameterInfo>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        readonly List<DataTable> _resultSchemas = new List<DataTable>();
        #endregion

        #region ctor
        public ProcedureInfo()
        {
        }

        public ProcedureInfo(string fullName)
            : base(fullName)
        {
        } 
        #endregion

        public IEnumerable<SqlParameterInfo> Parameters => _parameters.AsReadOnly();

        public IEnumerable<DataTable> ResultSchemas => _resultSchemas.AsReadOnly();

        internal void AddParameter(SqlParameterInfo parameter) { _parameters.Add(parameter); }

        internal void AddResultSchema(DataTable schema) { _resultSchemas.Add(schema); }

        internal void AddResultSchemas(IEnumerable<DataTable> schemas) { _resultSchemas.AddRange(schemas); }
    }
}
