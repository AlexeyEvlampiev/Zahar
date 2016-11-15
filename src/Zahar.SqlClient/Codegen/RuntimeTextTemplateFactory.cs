namespace Zahar.SqlClient.Codegen
{
    using Catalog;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    public sealed class RuntimeTextTemplateFactory
    {
        private IDiagnosticsCallback m_diagnosticsCallback;
        private IFormatInfo m_formatInfo;
        private readonly Projection.Projection m_projection;

        public RuntimeTextTemplateFactory(
            Projection.Projection projection, 
            IDiagnosticsCallback diagnosticsCallback, 
            IFormatInfo formatInfo)
        {
            if (ReferenceEquals(projection, null))
                throw new ArgumentException(nameof(projection));
            if (ReferenceEquals(diagnosticsCallback, null))
                throw new ArgumentException(nameof(diagnosticsCallback));
            if (ReferenceEquals(diagnosticsCallback, null))
                throw new ArgumentException(nameof(formatInfo));
            m_projection = projection;
            m_diagnosticsCallback = diagnosticsCallback;
            m_formatInfo = formatInfo;
        }

        public IRuntimeTextTemplate CreateCommonRtt()
        {
            return new CommonRtt(m_diagnosticsCallback, m_formatInfo);
        }

        public IEnumerable<IRuntimeTextTemplate> CreateUserDefinedTableRtts()
        {
            return m_projection.UserDefinedTableTypes
                .OrderBy(uddt => uddt.TableName)
                .Select(uddt => new UserDefinedTableTypeRtt(uddt, m_diagnosticsCallback, m_formatInfo));
        }

        public IEnumerable<IRuntimeTextTemplate> CreateStoredProcedureRtts()
        {
            return m_projection.Procedures
                .OrderBy(sp => sp.FullName)
                .Select(sp => new StoredProcedureRtt(sp, m_diagnosticsCallback, m_formatInfo));
        }
    }

    public partial class UserDefinedTableTypeRtt
    {
        private readonly DataTable Schema;

        public UserDefinedTableTypeRtt(
            DataTable schema,
            IDiagnosticsCallback diagnosticsCallback,
            IFormatInfo formatInfo) : base(diagnosticsCallback, formatInfo)
        {
            if (ReferenceEquals(schema, null))
                throw new ArgumentNullException(nameof(schema));            
            Schema = schema;
        }        
    }

    public partial class StoredProcedureRtt
    {
        private readonly ProcedureInfo Procedure;

        public StoredProcedureRtt(
            ProcedureInfo procedureInfo,
            IDiagnosticsCallback diagnosticsCallback,
            IFormatInfo formatInfo)
            : base(diagnosticsCallback, formatInfo)
        {
            Procedure = procedureInfo;
        }
    }
}
