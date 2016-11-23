namespace Zahar.SqlClient
{
    public abstract class SqlSpCmdBuilder : SqlCmdBuilder
    {
        #region Private Fields
        readonly string m_schemaName;
        readonly string m_procedureName;
        readonly string m_fullName; 
        #endregion

        [global::System.Diagnostics.DebuggerNonUserCode()]
        protected SqlSpCmdBuilder(string schemaName, string procedureName, string fullName)
        {
            m_schemaName = schemaName;
            m_procedureName = procedureName;
            m_fullName = fullName;
        }

        [global::System.Diagnostics.DebuggerNonUserCode()]
        public string GetProcedureSchemaName() { return m_schemaName; }

        [global::System.Diagnostics.DebuggerNonUserCode()]
        public string GetProcedureName() { return m_procedureName; }

        [global::System.Diagnostics.DebuggerNonUserCode()]
        public string GetProcedureFullName() { return m_fullName; }

        public override string ToString() { return m_fullName; }

        public override int GetHashCode() { return m_fullName.GetHashCode(); }
    }
}
