namespace Zahar.SqlClient.Codegen
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Text.RegularExpressions;

    public class FormatInfo : IFormatInfo
    {
        #region Private Fields        
        readonly Dictionary<Type, string> m_csTypeAliases = new Dictionary<Type, string>();
        readonly ConcurrentDictionary<string, DbObjectInfo> m_ixDbObjectInfoByFullName = new ConcurrentDictionary<string, DbObjectInfo>(StringComparer.OrdinalIgnoreCase);
        #endregion

        internal const string UserDefinedDataTableClassNamePostfix = "UserDefinedDataTable";
        internal const string UserDefinedDataTableRowClassNamePostfix = "UserDefinedDataTableRow";
        internal const string StoredProcedureComponentFactoryClassNamePostfix = "ComponentFactory";
        internal const string StoredProcedureReaderAdapterClassNamePostfix = "SqlDataReaderAdapter";
        internal const string StoredProcedureOutputValueSetClassNamePostfix = "OutputValueSet";
        internal const string DataTableClassNamePostfix = "DataTable";
        internal const string DataRowClassNamePostfix = "DataRow";


        #region Constructors
        public FormatInfo()
        {
            m_csTypeAliases = new Dictionary<Type, string>
            {
                { typeof(bool), "bool" },
                { typeof(byte), "byte" },
                { typeof(sbyte), "sbyte" },
                { typeof(char), "char" },
                { typeof(decimal), "decimal" },
                { typeof(double), "double" },
                { typeof(float), "float" },
                { typeof(int), "int" },
                { typeof(uint), "uint" },
                { typeof(long), "long" },
                { typeof(ulong), "ulong" },
                { typeof(object), "object" },
                { typeof(short), "short" },
                { typeof(ushort), "ushort" },
                { typeof(string), "string" }
            };
        }
        #endregion

        public virtual string BuildCommandMethodName => "BuildCommand";

        public virtual string StoredProcedureBasicOutputClassName => "Basic" + StoredProcedureOutputValueSetClassNamePostfix;

        public virtual string SuperFactoryClassName => "TypedComponentSuperFactory";

        public virtual string FieldPrefix => "m_";

        public virtual string FrameworkUtilitiesClassName => "TransactionScriptUtils";

        [DebuggerStepThrough]
        private DbObjectInfo GetDbObjectInfo(string fullName)
        {
            return m_ixDbObjectInfoByFullName.GetOrAdd(fullName, key => new DbObjectInfo(key));
        }

        public virtual string GetStoredProcedureComponentFactoryClassName(string spFullName)
        {
            var dbObjectInfo = GetDbObjectInfo(spFullName);
            string schemaPart = ToPascalCaseString(Normalize(dbObjectInfo.Schema));
            string namePart = ToPascalCaseString(Normalize(dbObjectInfo.Name));
            string className = $"{schemaPart}{namePart}{StoredProcedureComponentFactoryClassNamePostfix}";
            return className;
        }

        public virtual string GetStoredProcedureReaderAdapterClassName(string spFullName, int ordinal)
        {
            var dbObjectInfo = GetDbObjectInfo(spFullName);
            string schemaPart = ToPascalCaseString(Normalize(dbObjectInfo.Schema));
            string namePart = ToPascalCaseString(Normalize(dbObjectInfo.Name));
            string postfix = ordinal > 0 ? (ordinal + 1).ToString("g") : string.Empty;
            string className = $"{schemaPart}{namePart}{StoredProcedureReaderAdapterClassNamePostfix}{postfix}";
            return className;
        }

        public virtual string GetStoredProcedureOutputClassName(string spFullName)
        {
            var dbObjectInfo = GetDbObjectInfo(spFullName);
            string schemaPart = ToPascalCaseString(Normalize(dbObjectInfo.Schema));
            string namePart = ToPascalCaseString(Normalize(dbObjectInfo.Name));
            string className = $"{schemaPart}{namePart}{StoredProcedureOutputValueSetClassNamePostfix}";
            return className;
        }

        public virtual string GetUserDefinedDataTableClassName(string tableFullName)
        {
            var dbObjectInfo = GetDbObjectInfo(tableFullName);
            string schemaPart = ToPascalCaseString(Normalize(dbObjectInfo.Schema));
            string namePart = ToPascalCaseString(Normalize(dbObjectInfo.Name));
            string className = $"{schemaPart}{namePart}{UserDefinedDataTableClassNamePostfix}";
            return className;
        }

        public virtual string GetUserDefinedDataRowClassName(string tableFullName)
        {
            var dbObjectInfo = GetDbObjectInfo(tableFullName);
            string schemaPart = ToPascalCaseString(Normalize(dbObjectInfo.Schema));
            string namePart = ToPascalCaseString(Normalize(dbObjectInfo.Name));
            string className = $"{schemaPart}{namePart}{UserDefinedDataTableRowClassNamePostfix}";
            return className;
        }

        public string GetDataRowClassName(string tblFullName)
        {
            var dbObjectInfo = GetDbObjectInfo(tblFullName);
            string schemaPart = ToPascalCaseString(Normalize(dbObjectInfo.Schema));
            string namePart = ToPascalCaseString(Normalize(dbObjectInfo.Name));
            string className = $"{schemaPart}{namePart}{DataRowClassNamePostfix}";
            return className;
        }

        public string GetDataTableClassName(string tblFullName)
        {
            var dbObjectInfo = GetDbObjectInfo(tblFullName);
            string schemaPart = ToPascalCaseString(Normalize(dbObjectInfo.Schema));
            string namePart = ToPascalCaseString(Normalize(dbObjectInfo.Name));
            string className = $"{schemaPart}{namePart}{DataTableClassNamePostfix}";
            return className;
        }

        public virtual string GetPropertyName(string name)
        {
            string propertyName = name;
            propertyName = Normalize(propertyName);
            propertyName = ToPascalCaseString(propertyName);
            return propertyName;
        }

        public virtual string GetParameterName(string name)
        {
            return ToCamelCaseString(GetPropertyName(name));
        }

        public virtual string GetFieldName(string name)
        {
            return FieldPrefix + GetParameterName(name);
        }


        public virtual string GetPropertyTypeName(Type dataType, bool allowDBNull)
        {
            string propertyTypeString = m_csTypeAliases.ContainsKey(dataType)
                ? m_csTypeAliases[dataType]
                : dataType.FullName;

            if (allowDBNull &&
                dataType.IsValueType &&
                !dataType.IsGenericType)
            {
                return $"{propertyTypeString}?";
            }

            return propertyTypeString;
        }





        string ToPascalCaseString(string s)
        {
            return Regex.Replace(s, @"^.", m => m.Value.ToUpper());
        }

        string ToCamelCaseString(string s)
        {
            return Regex.Replace(s, @"^.", m => m.Value.ToLower());
        }

        internal string Normalize(string s)
        {
            return Regex.Replace(s, @"[\W]+(\w)", m => m.Groups[1].Value.ToUpper());
        }
    }
}
