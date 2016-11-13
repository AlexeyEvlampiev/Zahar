namespace Zahar.SqlClient
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    public class SqlDbTypeInfo
    {
        #region Private Fields

        readonly Dictionary<SqlDbType, Type> m_ixClrTypeBySqlDbType
            = new Dictionary<SqlDbType, Type>()
            {
                { SqlDbType.BigInt, typeof(System.Int64) },
                { SqlDbType.Binary, typeof(System.Byte[]) },
                { SqlDbType.Bit, typeof(System.Boolean) },
                { SqlDbType.Char, typeof(System.String) },
                { SqlDbType.DateTime, typeof(System.DateTime) },
                { SqlDbType.Decimal, typeof(System.Decimal) },
                { SqlDbType.Float, typeof(System.Double) },
                { SqlDbType.Image, typeof(System.Byte[]) },
                { SqlDbType.Int, typeof(System.Int32) },
                { SqlDbType.Money, typeof(System.Decimal) },
                { SqlDbType.NChar, typeof(System.String) },
                { SqlDbType.NText, typeof(System.String) },
                { SqlDbType.NVarChar, typeof(System.String) },
                { SqlDbType.Real, typeof(System.Single) },
                { SqlDbType.UniqueIdentifier, typeof(System.Guid) },
                { SqlDbType.SmallDateTime, typeof(System.DateTime) },
                { SqlDbType.SmallInt, typeof(System.Int16) },
                { SqlDbType.SmallMoney, typeof(System.Decimal) },
                { SqlDbType.Text, typeof(System.String) },
                { SqlDbType.Timestamp, typeof(System.Byte[]) },
                { SqlDbType.TinyInt, typeof(System.Byte) },
                { SqlDbType.VarBinary, typeof(System.Byte[]) },
                { SqlDbType.VarChar, typeof(System.String) },
                { SqlDbType.Variant, typeof(System.Object) },
                { SqlDbType.Xml, typeof(System.String) },
                { SqlDbType.Date, typeof(System.DateTime) },
                { SqlDbType.Time, typeof(System.TimeSpan) },
                { SqlDbType.DateTime2, typeof(System.DateTime) },
                { SqlDbType.DateTimeOffset, typeof(System.DateTimeOffset) },
                { SqlDbType.Structured, typeof(System.Data.DataTable) },
            };
        #endregion

        public Type GetDataType(SqlDbType sqlDbType)
        {
            try
            {
                return m_ixClrTypeBySqlDbType[sqlDbType];
            }
            catch (KeyNotFoundException)
            {
                return typeof(object);
            }
        }
    }
}
