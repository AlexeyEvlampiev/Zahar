namespace Zahar.SqlClient.Catalog
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [DebuggerDisplay("{ParameterName}")]
    public class SqlParameterInfo
    {
        [XmlIgnore]
        public SqlParameter Parameter { get; }

        public SqlParameterInfo()
        {
        }

        public SqlParameterInfo(SqlParameter parameter, Type dataType)
        {
            if (ReferenceEquals(parameter, null))
                throw new ArgumentNullException(nameof(parameter));
            if (ReferenceEquals(dataType, null))
                throw new ArgumentNullException(nameof(dataType));
            Parameter = parameter;
            ParameterName = parameter.ParameterName;
            DbType = parameter.DbType;
            SqlDbType = parameter.SqlDbType;
            Direction = parameter.Direction;
            IsNullable = parameter.IsNullable;
            Offset = parameter.Offset;
            Precision = parameter.Precision;
            Scale = parameter.Scale;
            Size = parameter.Size;
            TypeName = parameter.TypeName;
            UdtTypeName = parameter.UdtTypeName;
            XmlSchemaCollectionDatabase = parameter.XmlSchemaCollectionDatabase;
            XmlSchemaCollectionName = parameter.XmlSchemaCollectionName;
            XmlSchemaCollectionOwningSchema = parameter.XmlSchemaCollectionOwningSchema;
            DataType = dataType;
        }

        public Type DataType { get; set; }

        /// <summary>
        /// The owning relational schema where the schema collection for this XML instance is located.
        /// </summary>
        public string XmlSchemaCollectionOwningSchema { get; set; }

        /// <summary>
        /// Gets the name of the schema collection for this XML instance.
        /// </summary>
        public string XmlSchemaCollectionName { get; set; }

        /// <summary>
        /// Gets the name of the database where the schema collection for this XML instance is located.
        /// </summary>
        public string XmlSchemaCollectionDatabase { get; set; }

        /// <summary>
        /// Gets or sets a string that represents a user-defined type as a parameter.
        /// </summary>
        public string UdtTypeName { get; set; }

        /// <summary>
        /// Gets or sets the type name for a table-valued parameter.
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets the maximum size, in bytes, of the data within the column.
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Gets or sets the number of decimal places to which Value is resolved.
        /// </summary>
        public byte Scale { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of digits used to represent the Value property.
        /// </summary>
        public byte Precision { get; set; }

        /// <summary>
        /// Gets or sets the offset to the Value property.
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether the parameter accepts null values. 
        /// IsNullable is not used to validate the parameter’s value and will not prevent sending or receiving a null value when executing a command.
        /// </summary>
        public bool IsNullable { get; set; }

        /// <summary>
        /// Gets or sets the name of the SqlParameter.
        /// </summary>
        public string ParameterName { get; set; }

        /// <summary>
        /// Gets or sets the SqlDbType of the parameter
        /// </summary>
        public DbType DbType { get; set; }

        /// <summary>
        /// Gets or sets the SqlDbType of the parameter.
        /// </summary>
        public SqlDbType SqlDbType { get; set; }

        /// <summary>
        /// Gets or sets the name of the SqlParameter.
        /// </summary>
        public ParameterDirection Direction;

        public DataTable TableTypeSchema { get; set; }
    }
}
