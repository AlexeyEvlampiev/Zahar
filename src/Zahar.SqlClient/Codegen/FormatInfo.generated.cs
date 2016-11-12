namespace Zahar.SqlClient.Codegen
{
	using System;
    using System.Collections.Concurrent;
    using System.Diagnostics;
    using System.Text.RegularExpressions;


	public interface IFormatInfo
	{ 

        /// <summary>
        /// 
        /// </summary>
		string BuildCommandMethodName { get; }
	 

        /// <summary>
        /// 
        /// </summary>
		string FieldPrefix { get; }
	 

        /// <summary>
        /// 
        /// </summary>
		string FrameworkUtilitiesClassName { get; }
	 

        /// <summary>
        /// 
        /// </summary>
		string StoredProcedureBasicOutputClassName { get; }
	 

        /// <summary>
        /// 
        /// </summary>
		string SuperFactoryClassName { get; }
	  

        /// <summary>
        /// 
        /// </summary>
		string GetDataRowClassName(string tblFullName);  

        /// <summary>
        /// 
        /// </summary>
		string GetDataTableClassName(string tblFullName);  

        /// <summary>
        /// 
        /// </summary>
		string GetFieldName(string name);  

        /// <summary>
        /// 
        /// </summary>
		string GetParameterName(string name);  

        /// <summary>
        /// 
        /// </summary>
		string GetPropertyName(string name);  

        /// <summary>
        /// 
        /// </summary>
		string GetPropertyTypeName(Type propertyDataType, bool allowDBNull);  

        /// <summary>
        /// 
        /// </summary>
		string GetStoredProcedureComponentFactoryClassName(string spFullName);  

        /// <summary>
        /// 
        /// </summary>
		string GetStoredProcedureOutputClassName(string spFullName);  

        /// <summary>
        /// 
        /// </summary>
		string GetStoredProcedureReaderAdapterClassName(string spFullName, int ordinal);  

        /// <summary>
        /// 
        /// </summary>
		string GetUserDefinedDataRowClassName(string tableFullName);  

        /// <summary>
        /// 
        /// </summary>
		string GetUserDefinedDataTableClassName(string tableFullName);	}

	public class FormatInfoProxy : IFormatInfo
	{
		private readonly IFormatInfo m_innerFormatInfo;
		private readonly Regex m_validCsIdentifier = new Regex(@"^\w+$");
		private readonly Regex m_validDataTypeName = new Regex(@"^\w+(?:\.\w+)*\??$");
		readonly ConcurrentDictionary<string, string> m_cache = new ConcurrentDictionary<string, string>(StringComparer.Ordinal); 

        private FormatInfoProxy(IFormatInfo formatInfo)
        {
            m_innerFormatInfo = formatInfo;
        }

		public static FormatInfoProxy Create(IFormatInfo formatInfo)
		{
			if(ReferenceEquals(formatInfo, null))
                throw new ArgumentNullException(nameof(formatInfo));
			return formatInfo as FormatInfoProxy ?? new FormatInfoProxy(formatInfo);
		}

		private void AssertCsIdentifier(string memberName, string csName)
		{
			if(!m_validCsIdentifier.IsMatch(csName))
			{
				var type = m_innerFormatInfo.GetType();
				string message = $@"{type.Name} > ""{csName}"" is not a valid C# identifier.";
				if(type == typeof(FormatInfo))
					throw new InvalidOperationException(message);
				throw new CustomizationException(message);
			}
		}

		private void AssertDataTypeName(string memberName, string dataType)
		{
			if(!m_validDataTypeName.IsMatch(dataType))
			{
				var type = m_innerFormatInfo.GetType();
				string message = $@"{type.Name} > ""{dataType}"" is not a valid C# type name.";
				if(type == typeof(FormatInfo))
					throw new InvalidOperationException(message);
				throw new CustomizationException(message);
			}
		}

		 

        /// <summary>
        /// 
        /// </summary>
		public string BuildCommandMethodName 
		{ 
			[DebuggerStepThrough]
			get { return m_cache.GetOrAdd("BuildCommandMethodName", m_innerFormatInfo.BuildCommandMethodName); }
		}
		 

        /// <summary>
        /// 
        /// </summary>
		public string FieldPrefix 
		{ 
			[DebuggerStepThrough]
			get { return m_cache.GetOrAdd("FieldPrefix", m_innerFormatInfo.FieldPrefix); }
		}
		 

        /// <summary>
        /// 
        /// </summary>
		public string FrameworkUtilitiesClassName 
		{ 
			[DebuggerStepThrough]
			get { return m_cache.GetOrAdd("FrameworkUtilitiesClassName", m_innerFormatInfo.FrameworkUtilitiesClassName); }
		}
		 

        /// <summary>
        /// 
        /// </summary>
		public string StoredProcedureBasicOutputClassName 
		{ 
			[DebuggerStepThrough]
			get { return m_cache.GetOrAdd("StoredProcedureBasicOutputClassName", m_innerFormatInfo.StoredProcedureBasicOutputClassName); }
		}
		 

        /// <summary>
        /// 
        /// </summary>
		public string SuperFactoryClassName 
		{ 
			[DebuggerStepThrough]
			get { return m_cache.GetOrAdd("SuperFactoryClassName", m_innerFormatInfo.SuperFactoryClassName); }
		}
		  

        /// <summary>
        /// 
        /// </summary>
		[DebuggerStepThrough]
		public string GetDataRowClassName(string tblFullName)
		{
			return m_cache.GetOrAdd($"GetDataRowClassName_{tblFullName}", InvokeGetDataRowClassName(tblFullName));
		}  

        /// <summary>
        /// 
        /// </summary>
		[DebuggerStepThrough]
		public string GetDataTableClassName(string tblFullName)
		{
			return m_cache.GetOrAdd($"GetDataTableClassName_{tblFullName}", InvokeGetDataTableClassName(tblFullName));
		}  

        /// <summary>
        /// 
        /// </summary>
		[DebuggerStepThrough]
		public string GetFieldName(string name)
		{
			return m_cache.GetOrAdd($"GetFieldName_{name}", InvokeGetFieldName(name));
		}  

        /// <summary>
        /// 
        /// </summary>
		[DebuggerStepThrough]
		public string GetParameterName(string name)
		{
			return m_cache.GetOrAdd($"GetParameterName_{name}", InvokeGetParameterName(name));
		}  

        /// <summary>
        /// 
        /// </summary>
		[DebuggerStepThrough]
		public string GetPropertyName(string name)
		{
			return m_cache.GetOrAdd($"GetPropertyName_{name}", InvokeGetPropertyName(name));
		}  

        /// <summary>
        /// 
        /// </summary>
		[DebuggerStepThrough]
		public string GetPropertyTypeName(Type propertyDataType, bool allowDBNull)
		{
			return m_cache.GetOrAdd($"GetPropertyTypeName_{propertyDataType}_{allowDBNull}", InvokeGetPropertyTypeName(propertyDataType, allowDBNull));
		}  

        /// <summary>
        /// 
        /// </summary>
		[DebuggerStepThrough]
		public string GetStoredProcedureComponentFactoryClassName(string spFullName)
		{
			return m_cache.GetOrAdd($"GetStoredProcedureComponentFactoryClassName_{spFullName}", InvokeGetStoredProcedureComponentFactoryClassName(spFullName));
		}  

        /// <summary>
        /// 
        /// </summary>
		[DebuggerStepThrough]
		public string GetStoredProcedureOutputClassName(string spFullName)
		{
			return m_cache.GetOrAdd($"GetStoredProcedureOutputClassName_{spFullName}", InvokeGetStoredProcedureOutputClassName(spFullName));
		}  

        /// <summary>
        /// 
        /// </summary>
		[DebuggerStepThrough]
		public string GetStoredProcedureReaderAdapterClassName(string spFullName, int ordinal)
		{
			return m_cache.GetOrAdd($"GetStoredProcedureReaderAdapterClassName_{spFullName}_{ordinal}", InvokeGetStoredProcedureReaderAdapterClassName(spFullName, ordinal));
		}  

        /// <summary>
        /// 
        /// </summary>
		[DebuggerStepThrough]
		public string GetUserDefinedDataRowClassName(string tableFullName)
		{
			return m_cache.GetOrAdd($"GetUserDefinedDataRowClassName_{tableFullName}", InvokeGetUserDefinedDataRowClassName(tableFullName));
		}  

        /// <summary>
        /// 
        /// </summary>
		[DebuggerStepThrough]
		public string GetUserDefinedDataTableClassName(string tableFullName)
		{
			return m_cache.GetOrAdd($"GetUserDefinedDataTableClassName_{tableFullName}", InvokeGetUserDefinedDataTableClassName(tableFullName));
		}   

		private string InvokeGetDataRowClassName(string tblFullName)
		{
			string result = m_innerFormatInfo.GetDataRowClassName(tblFullName);
			AssertCsIdentifier("GetDataRowClassName", result);
			return result;
		}  

		private string InvokeGetDataTableClassName(string tblFullName)
		{
			string result = m_innerFormatInfo.GetDataTableClassName(tblFullName);
			AssertCsIdentifier("GetDataTableClassName", result);
			return result;
		}  

		private string InvokeGetFieldName(string name)
		{
			string result = m_innerFormatInfo.GetFieldName(name);
			AssertCsIdentifier("GetFieldName", result);
			return result;
		}  

		private string InvokeGetParameterName(string name)
		{
			string result = m_innerFormatInfo.GetParameterName(name);
			AssertCsIdentifier("GetParameterName", result);
			return result;
		}  

		private string InvokeGetPropertyName(string name)
		{
			string result = m_innerFormatInfo.GetPropertyName(name);
			AssertCsIdentifier("GetPropertyName", result);
			return result;
		}  

		private string InvokeGetPropertyTypeName(Type propertyDataType, bool allowDBNull)
		{
			string result = m_innerFormatInfo.GetPropertyTypeName(propertyDataType, allowDBNull);
			AssertDataTypeName("GetPropertyTypeName", result);
			return result;
		}  

		private string InvokeGetStoredProcedureComponentFactoryClassName(string spFullName)
		{
			string result = m_innerFormatInfo.GetStoredProcedureComponentFactoryClassName(spFullName);
			AssertCsIdentifier("GetStoredProcedureComponentFactoryClassName", result);
			return result;
		}  

		private string InvokeGetStoredProcedureOutputClassName(string spFullName)
		{
			string result = m_innerFormatInfo.GetStoredProcedureOutputClassName(spFullName);
			AssertCsIdentifier("GetStoredProcedureOutputClassName", result);
			return result;
		}  

		private string InvokeGetStoredProcedureReaderAdapterClassName(string spFullName, int ordinal)
		{
			string result = m_innerFormatInfo.GetStoredProcedureReaderAdapterClassName(spFullName, ordinal);
			AssertCsIdentifier("GetStoredProcedureReaderAdapterClassName", result);
			return result;
		}  

		private string InvokeGetUserDefinedDataRowClassName(string tableFullName)
		{
			string result = m_innerFormatInfo.GetUserDefinedDataRowClassName(tableFullName);
			AssertCsIdentifier("GetUserDefinedDataRowClassName", result);
			return result;
		}  

		private string InvokeGetUserDefinedDataTableClassName(string tableFullName)
		{
			string result = m_innerFormatInfo.GetUserDefinedDataTableClassName(tableFullName);
			AssertCsIdentifier("GetUserDefinedDataTableClassName", result);
			return result;
		} 
	}

	public abstract partial class RuntimeTextTemplate
	{ 

        /// <summary>
        /// 
        /// </summary>
		public string BuildCommandMethodName 
		{ 
			[DebuggerStepThrough]
			get { return m_formatInfo.BuildCommandMethodName; }
		}
		 

        /// <summary>
        /// 
        /// </summary>
		public string FieldPrefix 
		{ 
			[DebuggerStepThrough]
			get { return m_formatInfo.FieldPrefix; }
		}
		 

        /// <summary>
        /// 
        /// </summary>
		public string FrameworkUtilitiesClassName 
		{ 
			[DebuggerStepThrough]
			get { return m_formatInfo.FrameworkUtilitiesClassName; }
		}
		 

        /// <summary>
        /// 
        /// </summary>
		public string StoredProcedureBasicOutputClassName 
		{ 
			[DebuggerStepThrough]
			get { return m_formatInfo.StoredProcedureBasicOutputClassName; }
		}
		 

        /// <summary>
        /// 
        /// </summary>
		public string SuperFactoryClassName 
		{ 
			[DebuggerStepThrough]
			get { return m_formatInfo.SuperFactoryClassName; }
		}
		   

        /// <summary>
        /// 
        /// </summary>
		[DebuggerStepThrough]
		public string GetDataRowClassName(string tblFullName)
		{
			return m_formatInfo.GetDataRowClassName(tblFullName);
		}  

        /// <summary>
        /// 
        /// </summary>
		[DebuggerStepThrough]
		public string GetDataTableClassName(string tblFullName)
		{
			return m_formatInfo.GetDataTableClassName(tblFullName);
		}  

        /// <summary>
        /// 
        /// </summary>
		[DebuggerStepThrough]
		public string GetFieldName(string name)
		{
			return m_formatInfo.GetFieldName(name);
		}  

        /// <summary>
        /// 
        /// </summary>
		[DebuggerStepThrough]
		public string GetParameterName(string name)
		{
			return m_formatInfo.GetParameterName(name);
		}  

        /// <summary>
        /// 
        /// </summary>
		[DebuggerStepThrough]
		public string GetPropertyName(string name)
		{
			return m_formatInfo.GetPropertyName(name);
		}  

        /// <summary>
        /// 
        /// </summary>
		[DebuggerStepThrough]
		public string GetPropertyTypeName(Type propertyDataType, bool allowDBNull)
		{
			return m_formatInfo.GetPropertyTypeName(propertyDataType, allowDBNull);
		}  

        /// <summary>
        /// 
        /// </summary>
		[DebuggerStepThrough]
		public string GetStoredProcedureComponentFactoryClassName(string spFullName)
		{
			return m_formatInfo.GetStoredProcedureComponentFactoryClassName(spFullName);
		}  

        /// <summary>
        /// 
        /// </summary>
		[DebuggerStepThrough]
		public string GetStoredProcedureOutputClassName(string spFullName)
		{
			return m_formatInfo.GetStoredProcedureOutputClassName(spFullName);
		}  

        /// <summary>
        /// 
        /// </summary>
		[DebuggerStepThrough]
		public string GetStoredProcedureReaderAdapterClassName(string spFullName, int ordinal)
		{
			return m_formatInfo.GetStoredProcedureReaderAdapterClassName(spFullName, ordinal);
		}  

        /// <summary>
        /// 
        /// </summary>
		[DebuggerStepThrough]
		public string GetUserDefinedDataRowClassName(string tableFullName)
		{
			return m_formatInfo.GetUserDefinedDataRowClassName(tableFullName);
		}  

        /// <summary>
        /// 
        /// </summary>
		[DebuggerStepThrough]
		public string GetUserDefinedDataTableClassName(string tableFullName)
		{
			return m_formatInfo.GetUserDefinedDataTableClassName(tableFullName);
		}
	}
}