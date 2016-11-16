namespace Zahar.SqlClient
{
    [System.AttributeUsage(System.AttributeTargets.Property)]
    public sealed class SqlParameterAttribute : System.Attribute
    {
        public SqlParameterAttribute(
            int ordinal,
            string parameterName, 
            System.Data.SqlDbType sqlDbType, 
            System.Data.ParameterDirection direction)
        {
            this.Ordinal = ordinal;
            this.ParameterName = parameterName;
            this.SqlDbType = sqlDbType;
            this.Direction = direction;
        }

        public SqlParameterAttribute(
            int ordinal,
            string parameterName,
            System.Data.SqlDbType sqlDbType,
            System.Data.ParameterDirection direction,
            int size)
        {
            this.Ordinal = ordinal;
            this.ParameterName = parameterName;
            this.SqlDbType = sqlDbType;
            this.Direction = direction;
            this.Size = size;
        }

        public int Ordinal { get; }

        public string ParameterName { get; }

        public System.Data.SqlDbType SqlDbType { get; }

        public System.Data.ParameterDirection Direction { get; }

        public int? Size { get; }
    }
}
