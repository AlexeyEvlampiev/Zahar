namespace Demo
{	 
	
	
	/// <summary>
	/// [dbo].[uspGetBillOfMaterials] typed component factory.
	/// </summary>
	public partial class DboUspGetBillOfMaterialsComponentFactory
	{
		public const string ProcedureName = "[dbo].[uspGetBillOfMaterials]";
	
		#region Private Fields
		 
		#endregion
	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public DboUspGetBillOfMaterialsComponentFactory()
		{
			OnInit();
		}
	
		#region Partial Methods
		static partial void OnInit();
		static partial void OnCommandCreated(global::System.Data.SqlClient.SqlCommand command);
		 
		static partial void OnStartProductIDParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnCheckDateParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		#endregion
	
		/// <summary>
		/// Creates new [dbo].[uspGetBillOfMaterials] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand(global::System.Data.SqlClient.SqlConnection connection)
		{
			if(ReferenceEquals(connection, null))
				throw new global::System.ArgumentNullException(nameof(connection));
			var command = this.BuildCommand();
			command.Connection = connection;
			return command;
		}
	
		/// <summary>
		/// Creates new [dbo].[uspGetBillOfMaterials] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand(global::System.Data.SqlClient.SqlTransaction transaction)
		{
			if(ReferenceEquals(transaction, null))
				throw new global::System.ArgumentNullException(nameof(transaction));
			if(ReferenceEquals(transaction.Connection, null))
				throw new global::System.InvalidOperationException("transaction.Connection is null");
			var command = this.BuildCommand();
			command.Connection = transaction.Connection;
			command.Transaction = transaction;
			return command;
		}
	
		/// <summary>
		/// Creates new [dbo].[uspGetBillOfMaterials] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand()
		{
			var command = new global::System.Data.SqlClient.SqlCommand();
			this.BuildCommand(command);
			return command;
		}
	
		/// <summary>
		/// Configures the given command object to execute the [dbo].[uspGetBillOfMaterials] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
		{
			if(ReferenceEquals(command, null))
				throw new global::System.ArgumentNullException(nameof(command));		
			var parameters = CreateParametersArray(); 
			parameters[1].Value = this.StartProductID;  
			parameters[2].Value = this.CheckDate;  
			for (int i = 0; i < parameters.Length; ++i)
			{
				var parameter = parameters[i];
				if (parameter.Value == null)
					parameter.Value = global::System.DBNull.Value;
			}
			command.CommandText = ProcedureName;
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [dbo].[uspGetBillOfMaterials] -command output values set
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public ReturnValueSqlCommandOutput BuildOutputValues(global::System.Data.SqlClient.SqlCommand command)
		{			
			return new ReturnValueSqlCommandOutput(command);
		}
		 
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public DboUspGetBillOfMaterialsSqlDataReaderAdapter BuildRecordAdapter(global::System.Data.SqlClient.SqlDataReader reader)
		{		
			return new DboUspGetBillOfMaterialsSqlDataReaderAdapter(reader);
		}
		
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public static global::System.Data.SqlClient.SqlCommand CreateCommand(int? startProductID, System.DateTime? checkDate)
		{
			var builder = new DboUspGetBillOfMaterialsComponentFactory()		
			{ 
				StartProductID = startProductID,  
				CheckDate = checkDate,  
			};
			
			return builder.BuildCommand();
		}
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public static global::System.Data.SqlClient.SqlParameter[] CreateParametersArray()
		{
			var parameters = new []
			{ 
				new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.ReturnValue}, 
				new global::System.Data.SqlClient.SqlParameter("@StartProductID", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@CheckDate", global::System.Data.SqlDbType.DateTime){ Direction = global::System.Data.ParameterDirection.Input}, 
			};
	
			 
			OnStartProductIDParameterCreated(parameters[1]);  
			OnCheckDateParameterCreated(parameters[2]);  
	
			return parameters;
		}
		#region Sql Parameter Properties
		/// <summary>
		/// Parameter 1
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public int? StartProductID { get; set; }
		/// <summary>
		/// Parameter 2
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public System.DateTime? CheckDate { get; set; }
	
	
		#endregion
	}
	
	
	
	
	/// <summary>
	/// [dbo].[uspGetBillOfMaterials] result[0]
	/// </summary>
	public partial struct DboUspGetBillOfMaterialsSqlDataReaderAdapter
	{
		/// <summary>
		/// 
		/// </summary>
		public global::System.Data.SqlClient.SqlDataReader InnerReader { get; }
	
		public DboUspGetBillOfMaterialsSqlDataReaderAdapter(
			global::System.Data.SqlClient.SqlDataReader reader) : this()
		{
			if(ReferenceEquals(reader, null))
				throw new global::System.ArgumentNullException(nameof(reader));
			InnerReader = reader;
		}
	
		/// <summary>
		/// 
		/// </summary>
		public bool Read() { return InnerReader.Read(); }  
	
		 
		/// <summary>
		/// 
		/// </summary>
		public int? ProductAssemblyID => SqlDbClient.ToClrValue<int?>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public int? ComponentID => SqlDbClient.ToClrValue<int?>(InnerReader[1]);  
		/// <summary>
		/// 
		/// </summary>
		public string ComponentDesc => SqlDbClient.ToClrValue<string>(InnerReader[2]);  
		/// <summary>
		/// 
		/// </summary>
		public decimal? TotalQuantity => SqlDbClient.ToClrValue<decimal?>(InnerReader[3]);  
		/// <summary>
		/// 
		/// </summary>
		public decimal? StandardCost => SqlDbClient.ToClrValue<decimal?>(InnerReader[4]);  
		/// <summary>
		/// 
		/// </summary>
		public decimal? ListPrice => SqlDbClient.ToClrValue<decimal?>(InnerReader[5]);  
		/// <summary>
		/// 
		/// </summary>
		public short? BOMLevel => SqlDbClient.ToClrValue<short?>(InnerReader[6]);  
		/// <summary>
		/// 
		/// </summary>
		public int? RecursionLevel => SqlDbClient.ToClrValue<int?>(InnerReader[7]);  
	}

	 
	
	
	/// <summary>
	/// [dbo].[uspGetEmployeeManagers] typed component factory.
	/// </summary>
	public partial class DboUspGetEmployeeManagersComponentFactory
	{
		public const string ProcedureName = "[dbo].[uspGetEmployeeManagers]";
	
		#region Private Fields
		 
		#endregion
	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public DboUspGetEmployeeManagersComponentFactory()
		{
			OnInit();
		}
	
		#region Partial Methods
		static partial void OnInit();
		static partial void OnCommandCreated(global::System.Data.SqlClient.SqlCommand command);
		 
		static partial void OnBusinessEntityIDParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		#endregion
	
		/// <summary>
		/// Creates new [dbo].[uspGetEmployeeManagers] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand(global::System.Data.SqlClient.SqlConnection connection)
		{
			if(ReferenceEquals(connection, null))
				throw new global::System.ArgumentNullException(nameof(connection));
			var command = this.BuildCommand();
			command.Connection = connection;
			return command;
		}
	
		/// <summary>
		/// Creates new [dbo].[uspGetEmployeeManagers] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand(global::System.Data.SqlClient.SqlTransaction transaction)
		{
			if(ReferenceEquals(transaction, null))
				throw new global::System.ArgumentNullException(nameof(transaction));
			if(ReferenceEquals(transaction.Connection, null))
				throw new global::System.InvalidOperationException("transaction.Connection is null");
			var command = this.BuildCommand();
			command.Connection = transaction.Connection;
			command.Transaction = transaction;
			return command;
		}
	
		/// <summary>
		/// Creates new [dbo].[uspGetEmployeeManagers] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand()
		{
			var command = new global::System.Data.SqlClient.SqlCommand();
			this.BuildCommand(command);
			return command;
		}
	
		/// <summary>
		/// Configures the given command object to execute the [dbo].[uspGetEmployeeManagers] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
		{
			if(ReferenceEquals(command, null))
				throw new global::System.ArgumentNullException(nameof(command));		
			var parameters = CreateParametersArray(); 
			parameters[1].Value = this.BusinessEntityID;  
			for (int i = 0; i < parameters.Length; ++i)
			{
				var parameter = parameters[i];
				if (parameter.Value == null)
					parameter.Value = global::System.DBNull.Value;
			}
			command.CommandText = ProcedureName;
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [dbo].[uspGetEmployeeManagers] -command output values set
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public ReturnValueSqlCommandOutput BuildOutputValues(global::System.Data.SqlClient.SqlCommand command)
		{			
			return new ReturnValueSqlCommandOutput(command);
		}
		 
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public DboUspGetEmployeeManagersSqlDataReaderAdapter BuildRecordAdapter(global::System.Data.SqlClient.SqlDataReader reader)
		{		
			return new DboUspGetEmployeeManagersSqlDataReaderAdapter(reader);
		}
		
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public static global::System.Data.SqlClient.SqlCommand CreateCommand(int? businessEntityID)
		{
			var builder = new DboUspGetEmployeeManagersComponentFactory()		
			{ 
				BusinessEntityID = businessEntityID,  
			};
			
			return builder.BuildCommand();
		}
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public static global::System.Data.SqlClient.SqlParameter[] CreateParametersArray()
		{
			var parameters = new []
			{ 
				new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.ReturnValue}, 
				new global::System.Data.SqlClient.SqlParameter("@BusinessEntityID", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
			};
	
			 
			OnBusinessEntityIDParameterCreated(parameters[1]);  
	
			return parameters;
		}
		#region Sql Parameter Properties
		/// <summary>
		/// Parameter 1
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public int? BusinessEntityID { get; set; }
	
	
		#endregion
	}
	
	
	
	
	/// <summary>
	/// [dbo].[uspGetEmployeeManagers] result[0]
	/// </summary>
	public partial struct DboUspGetEmployeeManagersSqlDataReaderAdapter
	{
		/// <summary>
		/// 
		/// </summary>
		public global::System.Data.SqlClient.SqlDataReader InnerReader { get; }
	
		public DboUspGetEmployeeManagersSqlDataReaderAdapter(
			global::System.Data.SqlClient.SqlDataReader reader) : this()
		{
			if(ReferenceEquals(reader, null))
				throw new global::System.ArgumentNullException(nameof(reader));
			InnerReader = reader;
		}
	
		/// <summary>
		/// 
		/// </summary>
		public bool Read() { return InnerReader.Read(); }  
	
		 
		/// <summary>
		/// 
		/// </summary>
		public int? RecursionLevel => SqlDbClient.ToClrValue<int?>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public int? BusinessEntityID => SqlDbClient.ToClrValue<int?>(InnerReader[1]);  
		/// <summary>
		/// 
		/// </summary>
		public string FirstName => SqlDbClient.ToClrValue<string>(InnerReader[2]);  
		/// <summary>
		/// 
		/// </summary>
		public string LastName => SqlDbClient.ToClrValue<string>(InnerReader[3]);  
		/// <summary>
		/// 
		/// </summary>
		public string OrganizationNode => SqlDbClient.ToClrValue<string>(InnerReader[4]);  
		/// <summary>
		/// 
		/// </summary>
		public string ManagerFirstName => SqlDbClient.ToClrValue<string>(InnerReader[5]);  
		/// <summary>
		/// 
		/// </summary>
		public string ManagerLastName => SqlDbClient.ToClrValue<string>(InnerReader[6]);  
	}

	 
	
	
	/// <summary>
	/// [dbo].[uspGetManagerEmployees] typed component factory.
	/// </summary>
	public partial class DboUspGetManagerEmployeesComponentFactory
	{
		public const string ProcedureName = "[dbo].[uspGetManagerEmployees]";
	
		#region Private Fields
		 
		#endregion
	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public DboUspGetManagerEmployeesComponentFactory()
		{
			OnInit();
		}
	
		#region Partial Methods
		static partial void OnInit();
		static partial void OnCommandCreated(global::System.Data.SqlClient.SqlCommand command);
		 
		static partial void OnBusinessEntityIDParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		#endregion
	
		/// <summary>
		/// Creates new [dbo].[uspGetManagerEmployees] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand(global::System.Data.SqlClient.SqlConnection connection)
		{
			if(ReferenceEquals(connection, null))
				throw new global::System.ArgumentNullException(nameof(connection));
			var command = this.BuildCommand();
			command.Connection = connection;
			return command;
		}
	
		/// <summary>
		/// Creates new [dbo].[uspGetManagerEmployees] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand(global::System.Data.SqlClient.SqlTransaction transaction)
		{
			if(ReferenceEquals(transaction, null))
				throw new global::System.ArgumentNullException(nameof(transaction));
			if(ReferenceEquals(transaction.Connection, null))
				throw new global::System.InvalidOperationException("transaction.Connection is null");
			var command = this.BuildCommand();
			command.Connection = transaction.Connection;
			command.Transaction = transaction;
			return command;
		}
	
		/// <summary>
		/// Creates new [dbo].[uspGetManagerEmployees] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand()
		{
			var command = new global::System.Data.SqlClient.SqlCommand();
			this.BuildCommand(command);
			return command;
		}
	
		/// <summary>
		/// Configures the given command object to execute the [dbo].[uspGetManagerEmployees] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
		{
			if(ReferenceEquals(command, null))
				throw new global::System.ArgumentNullException(nameof(command));		
			var parameters = CreateParametersArray(); 
			parameters[1].Value = this.BusinessEntityID;  
			for (int i = 0; i < parameters.Length; ++i)
			{
				var parameter = parameters[i];
				if (parameter.Value == null)
					parameter.Value = global::System.DBNull.Value;
			}
			command.CommandText = ProcedureName;
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [dbo].[uspGetManagerEmployees] -command output values set
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public ReturnValueSqlCommandOutput BuildOutputValues(global::System.Data.SqlClient.SqlCommand command)
		{			
			return new ReturnValueSqlCommandOutput(command);
		}
		 
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public DboUspGetManagerEmployeesSqlDataReaderAdapter BuildRecordAdapter(global::System.Data.SqlClient.SqlDataReader reader)
		{		
			return new DboUspGetManagerEmployeesSqlDataReaderAdapter(reader);
		}
		
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public static global::System.Data.SqlClient.SqlCommand CreateCommand(int? businessEntityID)
		{
			var builder = new DboUspGetManagerEmployeesComponentFactory()		
			{ 
				BusinessEntityID = businessEntityID,  
			};
			
			return builder.BuildCommand();
		}
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public static global::System.Data.SqlClient.SqlParameter[] CreateParametersArray()
		{
			var parameters = new []
			{ 
				new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.ReturnValue}, 
				new global::System.Data.SqlClient.SqlParameter("@BusinessEntityID", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
			};
	
			 
			OnBusinessEntityIDParameterCreated(parameters[1]);  
	
			return parameters;
		}
		#region Sql Parameter Properties
		/// <summary>
		/// Parameter 1
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public int? BusinessEntityID { get; set; }
	
	
		#endregion
	}
	
	
	
	
	/// <summary>
	/// [dbo].[uspGetManagerEmployees] result[0]
	/// </summary>
	public partial struct DboUspGetManagerEmployeesSqlDataReaderAdapter
	{
		/// <summary>
		/// 
		/// </summary>
		public global::System.Data.SqlClient.SqlDataReader InnerReader { get; }
	
		public DboUspGetManagerEmployeesSqlDataReaderAdapter(
			global::System.Data.SqlClient.SqlDataReader reader) : this()
		{
			if(ReferenceEquals(reader, null))
				throw new global::System.ArgumentNullException(nameof(reader));
			InnerReader = reader;
		}
	
		/// <summary>
		/// 
		/// </summary>
		public bool Read() { return InnerReader.Read(); }  
	
		 
		/// <summary>
		/// 
		/// </summary>
		public int? RecursionLevel => SqlDbClient.ToClrValue<int?>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public string OrganizationNode => SqlDbClient.ToClrValue<string>(InnerReader[1]);  
		/// <summary>
		/// 
		/// </summary>
		public string ManagerFirstName => SqlDbClient.ToClrValue<string>(InnerReader[2]);  
		/// <summary>
		/// 
		/// </summary>
		public string ManagerLastName => SqlDbClient.ToClrValue<string>(InnerReader[3]);  
		/// <summary>
		/// 
		/// </summary>
		public int? BusinessEntityID => SqlDbClient.ToClrValue<int?>(InnerReader[4]);  
		/// <summary>
		/// 
		/// </summary>
		public string FirstName => SqlDbClient.ToClrValue<string>(InnerReader[5]);  
		/// <summary>
		/// 
		/// </summary>
		public string LastName => SqlDbClient.ToClrValue<string>(InnerReader[6]);  
	}

	 
	
	
	/// <summary>
	/// [dbo].[uspGetWhereUsedProductID] typed component factory.
	/// </summary>
	public partial class DboUspGetWhereUsedProductIDComponentFactory
	{
		public const string ProcedureName = "[dbo].[uspGetWhereUsedProductID]";
	
		#region Private Fields
		 
		#endregion
	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public DboUspGetWhereUsedProductIDComponentFactory()
		{
			OnInit();
		}
	
		#region Partial Methods
		static partial void OnInit();
		static partial void OnCommandCreated(global::System.Data.SqlClient.SqlCommand command);
		 
		static partial void OnStartProductIDParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnCheckDateParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		#endregion
	
		/// <summary>
		/// Creates new [dbo].[uspGetWhereUsedProductID] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand(global::System.Data.SqlClient.SqlConnection connection)
		{
			if(ReferenceEquals(connection, null))
				throw new global::System.ArgumentNullException(nameof(connection));
			var command = this.BuildCommand();
			command.Connection = connection;
			return command;
		}
	
		/// <summary>
		/// Creates new [dbo].[uspGetWhereUsedProductID] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand(global::System.Data.SqlClient.SqlTransaction transaction)
		{
			if(ReferenceEquals(transaction, null))
				throw new global::System.ArgumentNullException(nameof(transaction));
			if(ReferenceEquals(transaction.Connection, null))
				throw new global::System.InvalidOperationException("transaction.Connection is null");
			var command = this.BuildCommand();
			command.Connection = transaction.Connection;
			command.Transaction = transaction;
			return command;
		}
	
		/// <summary>
		/// Creates new [dbo].[uspGetWhereUsedProductID] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand()
		{
			var command = new global::System.Data.SqlClient.SqlCommand();
			this.BuildCommand(command);
			return command;
		}
	
		/// <summary>
		/// Configures the given command object to execute the [dbo].[uspGetWhereUsedProductID] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
		{
			if(ReferenceEquals(command, null))
				throw new global::System.ArgumentNullException(nameof(command));		
			var parameters = CreateParametersArray(); 
			parameters[1].Value = this.StartProductID;  
			parameters[2].Value = this.CheckDate;  
			for (int i = 0; i < parameters.Length; ++i)
			{
				var parameter = parameters[i];
				if (parameter.Value == null)
					parameter.Value = global::System.DBNull.Value;
			}
			command.CommandText = ProcedureName;
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [dbo].[uspGetWhereUsedProductID] -command output values set
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public ReturnValueSqlCommandOutput BuildOutputValues(global::System.Data.SqlClient.SqlCommand command)
		{			
			return new ReturnValueSqlCommandOutput(command);
		}
		 
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public DboUspGetWhereUsedProductIDSqlDataReaderAdapter BuildRecordAdapter(global::System.Data.SqlClient.SqlDataReader reader)
		{		
			return new DboUspGetWhereUsedProductIDSqlDataReaderAdapter(reader);
		}
		
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public static global::System.Data.SqlClient.SqlCommand CreateCommand(int? startProductID, System.DateTime? checkDate)
		{
			var builder = new DboUspGetWhereUsedProductIDComponentFactory()		
			{ 
				StartProductID = startProductID,  
				CheckDate = checkDate,  
			};
			
			return builder.BuildCommand();
		}
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public static global::System.Data.SqlClient.SqlParameter[] CreateParametersArray()
		{
			var parameters = new []
			{ 
				new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.ReturnValue}, 
				new global::System.Data.SqlClient.SqlParameter("@StartProductID", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@CheckDate", global::System.Data.SqlDbType.DateTime){ Direction = global::System.Data.ParameterDirection.Input}, 
			};
	
			 
			OnStartProductIDParameterCreated(parameters[1]);  
			OnCheckDateParameterCreated(parameters[2]);  
	
			return parameters;
		}
		#region Sql Parameter Properties
		/// <summary>
		/// Parameter 1
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public int? StartProductID { get; set; }
		/// <summary>
		/// Parameter 2
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public System.DateTime? CheckDate { get; set; }
	
	
		#endregion
	}
	
	
	
	
	/// <summary>
	/// [dbo].[uspGetWhereUsedProductID] result[0]
	/// </summary>
	public partial struct DboUspGetWhereUsedProductIDSqlDataReaderAdapter
	{
		/// <summary>
		/// 
		/// </summary>
		public global::System.Data.SqlClient.SqlDataReader InnerReader { get; }
	
		public DboUspGetWhereUsedProductIDSqlDataReaderAdapter(
			global::System.Data.SqlClient.SqlDataReader reader) : this()
		{
			if(ReferenceEquals(reader, null))
				throw new global::System.ArgumentNullException(nameof(reader));
			InnerReader = reader;
		}
	
		/// <summary>
		/// 
		/// </summary>
		public bool Read() { return InnerReader.Read(); }  
	
		 
		/// <summary>
		/// 
		/// </summary>
		public int? ProductAssemblyID => SqlDbClient.ToClrValue<int?>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public int? ComponentID => SqlDbClient.ToClrValue<int?>(InnerReader[1]);  
		/// <summary>
		/// 
		/// </summary>
		public string ComponentDesc => SqlDbClient.ToClrValue<string>(InnerReader[2]);  
		/// <summary>
		/// 
		/// </summary>
		public decimal? TotalQuantity => SqlDbClient.ToClrValue<decimal?>(InnerReader[3]);  
		/// <summary>
		/// 
		/// </summary>
		public decimal? StandardCost => SqlDbClient.ToClrValue<decimal?>(InnerReader[4]);  
		/// <summary>
		/// 
		/// </summary>
		public decimal? ListPrice => SqlDbClient.ToClrValue<decimal?>(InnerReader[5]);  
		/// <summary>
		/// 
		/// </summary>
		public short? BOMLevel => SqlDbClient.ToClrValue<short?>(InnerReader[6]);  
		/// <summary>
		/// 
		/// </summary>
		public int? RecursionLevel => SqlDbClient.ToClrValue<int?>(InnerReader[7]);  
	}

	 
	
	
	/// <summary>
	/// [dbo].[uspLogError] typed component factory.
	/// </summary>
	public partial class DboUspLogErrorComponentFactory
	{
		public const string ProcedureName = "[dbo].[uspLogError]";
	
		#region Private Fields
		 
		#endregion
	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public DboUspLogErrorComponentFactory()
		{
			OnInit();
		}
	
		#region Partial Methods
		static partial void OnInit();
		static partial void OnCommandCreated(global::System.Data.SqlClient.SqlCommand command);
		 
		static partial void OnErrorLogIDParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		#endregion
	
		/// <summary>
		/// Creates new [dbo].[uspLogError] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand(global::System.Data.SqlClient.SqlConnection connection)
		{
			if(ReferenceEquals(connection, null))
				throw new global::System.ArgumentNullException(nameof(connection));
			var command = this.BuildCommand();
			command.Connection = connection;
			return command;
		}
	
		/// <summary>
		/// Creates new [dbo].[uspLogError] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand(global::System.Data.SqlClient.SqlTransaction transaction)
		{
			if(ReferenceEquals(transaction, null))
				throw new global::System.ArgumentNullException(nameof(transaction));
			if(ReferenceEquals(transaction.Connection, null))
				throw new global::System.InvalidOperationException("transaction.Connection is null");
			var command = this.BuildCommand();
			command.Connection = transaction.Connection;
			command.Transaction = transaction;
			return command;
		}
	
		/// <summary>
		/// Creates new [dbo].[uspLogError] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand()
		{
			var command = new global::System.Data.SqlClient.SqlCommand();
			this.BuildCommand(command);
			return command;
		}
	
		/// <summary>
		/// Configures the given command object to execute the [dbo].[uspLogError] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
		{
			if(ReferenceEquals(command, null))
				throw new global::System.ArgumentNullException(nameof(command));		
			var parameters = CreateParametersArray(); 
			parameters[1].Value = this.ErrorLogID;  
			for (int i = 0; i < parameters.Length; ++i)
			{
				var parameter = parameters[i];
				if (parameter.Value == null)
					parameter.Value = global::System.DBNull.Value;
			}
			command.CommandText = ProcedureName;
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [dbo].[uspLogError] -command output values set
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public DboUspLogErrorOutputValueSet BuildOutputValues(global::System.Data.SqlClient.SqlCommand command)
		{			
			return new DboUspLogErrorOutputValueSet(command);
		}
		
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public static global::System.Data.SqlClient.SqlCommand CreateCommand(int? errorLogID)
		{
			var builder = new DboUspLogErrorComponentFactory()		
			{ 
				ErrorLogID = errorLogID,  
			};
			
			return builder.BuildCommand();
		}
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public static global::System.Data.SqlClient.SqlParameter[] CreateParametersArray()
		{
			var parameters = new []
			{ 
				new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.ReturnValue}, 
				new global::System.Data.SqlClient.SqlParameter("@ErrorLogID", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.InputOutput}, 
			};
	
			 
			OnErrorLogIDParameterCreated(parameters[1]);  
	
			return parameters;
		}
		#region Sql Parameter Properties
		/// <summary>
		/// Parameter 1
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public int? ErrorLogID { get; set; }
	
	
		#endregion
	}
	
	
	/// <summary>
	/// [dbo].[uspLogError] output parameters
	/// </summary>
	public partial struct DboUspLogErrorOutputValueSet
	{
		readonly global::System.Data.SqlClient.SqlCommand m_command;
		public DboUspLogErrorOutputValueSet(global::System.Data.SqlClient.SqlCommand command)
		{
			if(ReferenceEquals(command, null))
				throw new global::System.ArgumentNullException(nameof(command)); 
			global::System.Diagnostics.Debug.Assert(command.Parameters.Contains("@RETURN_VALUE"));  
			global::System.Diagnostics.Debug.Assert(command.Parameters.Contains("@ErrorLogID")); 	
			global::System.Diagnostics.Debug.Assert("[dbo].[uspLogError]".Equals(command.CommandText, global::System.StringComparison.OrdinalIgnoreCase));				
			m_command = command;
		}
	
		 
		/// <summary>
		/// 
		/// </summary>
		public int? RETURN_VALUE => SqlDbClient.ToClrValue<int?>(m_command.Parameters["@RETURN_VALUE"].Value);
		 
		/// <summary>
		/// 
		/// </summary>
		public int? ErrorLogID => SqlDbClient.ToClrValue<int?>(m_command.Parameters["@ErrorLogID"].Value);
		}
	
	

	 
	
	
	/// <summary>
	/// [dbo].[uspPrintError] typed component factory.
	/// </summary>
	public partial class DboUspPrintErrorComponentFactory
	{
		public const string ProcedureName = "[dbo].[uspPrintError]";
	
		#region Private Fields
		 
		#endregion
	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public DboUspPrintErrorComponentFactory()
		{
			OnInit();
		}
	
		#region Partial Methods
		static partial void OnInit();
		static partial void OnCommandCreated(global::System.Data.SqlClient.SqlCommand command);
		 
		#endregion
	
		/// <summary>
		/// Creates new [dbo].[uspPrintError] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand(global::System.Data.SqlClient.SqlConnection connection)
		{
			if(ReferenceEquals(connection, null))
				throw new global::System.ArgumentNullException(nameof(connection));
			var command = this.BuildCommand();
			command.Connection = connection;
			return command;
		}
	
		/// <summary>
		/// Creates new [dbo].[uspPrintError] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand(global::System.Data.SqlClient.SqlTransaction transaction)
		{
			if(ReferenceEquals(transaction, null))
				throw new global::System.ArgumentNullException(nameof(transaction));
			if(ReferenceEquals(transaction.Connection, null))
				throw new global::System.InvalidOperationException("transaction.Connection is null");
			var command = this.BuildCommand();
			command.Connection = transaction.Connection;
			command.Transaction = transaction;
			return command;
		}
	
		/// <summary>
		/// Creates new [dbo].[uspPrintError] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand()
		{
			var command = new global::System.Data.SqlClient.SqlCommand();
			this.BuildCommand(command);
			return command;
		}
	
		/// <summary>
		/// Configures the given command object to execute the [dbo].[uspPrintError] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
		{
			if(ReferenceEquals(command, null))
				throw new global::System.ArgumentNullException(nameof(command));		
			var parameters = CreateParametersArray(); 
			for (int i = 0; i < parameters.Length; ++i)
			{
				var parameter = parameters[i];
				if (parameter.Value == null)
					parameter.Value = global::System.DBNull.Value;
			}
			command.CommandText = ProcedureName;
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [dbo].[uspPrintError] -command output values set
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public ReturnValueSqlCommandOutput BuildOutputValues(global::System.Data.SqlClient.SqlCommand command)
		{			
			return new ReturnValueSqlCommandOutput(command);
		}
		
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public static global::System.Data.SqlClient.SqlCommand CreateCommand()
		{
			var builder = new DboUspPrintErrorComponentFactory()		
			{ 
			};
			
			return builder.BuildCommand();
		}
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public static global::System.Data.SqlClient.SqlParameter[] CreateParametersArray()
		{
			var parameters = new []
			{ 
				new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.ReturnValue}, 
			};
	
			 
	
			return parameters;
		}
		#region Sql Parameter Properties
	
	
		#endregion
	}
	
	
	
	

	 
	
	
	/// <summary>
	/// [dbo].[uspSearchCandidateResumes] typed component factory.
	/// </summary>
	public partial class DboUspSearchCandidateResumesComponentFactory
	{
		public const string ProcedureName = "[dbo].[uspSearchCandidateResumes]";
	
		#region Private Fields
		 
		#endregion
	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public DboUspSearchCandidateResumesComponentFactory()
		{
			OnInit();
		}
	
		#region Partial Methods
		static partial void OnInit();
		static partial void OnCommandCreated(global::System.Data.SqlClient.SqlCommand command);
		 
		static partial void OnSearchStringParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnUseInflectionalParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnUseThesaurusParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnLanguageParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		#endregion
	
		/// <summary>
		/// Creates new [dbo].[uspSearchCandidateResumes] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand(global::System.Data.SqlClient.SqlConnection connection)
		{
			if(ReferenceEquals(connection, null))
				throw new global::System.ArgumentNullException(nameof(connection));
			var command = this.BuildCommand();
			command.Connection = connection;
			return command;
		}
	
		/// <summary>
		/// Creates new [dbo].[uspSearchCandidateResumes] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand(global::System.Data.SqlClient.SqlTransaction transaction)
		{
			if(ReferenceEquals(transaction, null))
				throw new global::System.ArgumentNullException(nameof(transaction));
			if(ReferenceEquals(transaction.Connection, null))
				throw new global::System.InvalidOperationException("transaction.Connection is null");
			var command = this.BuildCommand();
			command.Connection = transaction.Connection;
			command.Transaction = transaction;
			return command;
		}
	
		/// <summary>
		/// Creates new [dbo].[uspSearchCandidateResumes] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand()
		{
			var command = new global::System.Data.SqlClient.SqlCommand();
			this.BuildCommand(command);
			return command;
		}
	
		/// <summary>
		/// Configures the given command object to execute the [dbo].[uspSearchCandidateResumes] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
		{
			if(ReferenceEquals(command, null))
				throw new global::System.ArgumentNullException(nameof(command));		
			var parameters = CreateParametersArray(); 
			parameters[1].Value = this.SearchString;  
			parameters[2].Value = this.UseInflectional;  
			parameters[3].Value = this.UseThesaurus;  
			parameters[4].Value = this.Language;  
			for (int i = 0; i < parameters.Length; ++i)
			{
				var parameter = parameters[i];
				if (parameter.Value == null)
					parameter.Value = global::System.DBNull.Value;
			}
			command.CommandText = ProcedureName;
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [dbo].[uspSearchCandidateResumes] -command output values set
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public ReturnValueSqlCommandOutput BuildOutputValues(global::System.Data.SqlClient.SqlCommand command)
		{			
			return new ReturnValueSqlCommandOutput(command);
		}
		 
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public DboUspSearchCandidateResumesSqlDataReaderAdapter BuildRecordAdapter(global::System.Data.SqlClient.SqlDataReader reader)
		{		
			return new DboUspSearchCandidateResumesSqlDataReaderAdapter(reader);
		}
		
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public static global::System.Data.SqlClient.SqlCommand CreateCommand(string searchString, bool? useInflectional, bool? useThesaurus, int? language)
		{
			var builder = new DboUspSearchCandidateResumesComponentFactory()		
			{ 
				SearchString = searchString,  
				UseInflectional = useInflectional,  
				UseThesaurus = useThesaurus,  
				Language = language,  
			};
			
			return builder.BuildCommand();
		}
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public static global::System.Data.SqlClient.SqlParameter[] CreateParametersArray()
		{
			var parameters = new []
			{ 
				new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.ReturnValue}, 
				new global::System.Data.SqlClient.SqlParameter("@searchString", global::System.Data.SqlDbType.NVarChar){ Direction = global::System.Data.ParameterDirection.Input, Size = 1000}, 
				new global::System.Data.SqlClient.SqlParameter("@useInflectional", global::System.Data.SqlDbType.Bit){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@useThesaurus", global::System.Data.SqlDbType.Bit){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@language", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
			};
	
			 
			OnSearchStringParameterCreated(parameters[1]);  
			OnUseInflectionalParameterCreated(parameters[2]);  
			OnUseThesaurusParameterCreated(parameters[3]);  
			OnLanguageParameterCreated(parameters[4]);  
	
			return parameters;
		}
		#region Sql Parameter Properties
		/// <summary>
		/// Parameter 1
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public string SearchString { get; set; }
		/// <summary>
		/// Parameter 2
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public bool? UseInflectional { get; set; }
		/// <summary>
		/// Parameter 3
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public bool? UseThesaurus { get; set; }
		/// <summary>
		/// Parameter 4
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public int? Language { get; set; }
	
	
		#endregion
	}
	
	
	
	
	/// <summary>
	/// [dbo].[uspSearchCandidateResumes] result[0]
	/// </summary>
	public partial struct DboUspSearchCandidateResumesSqlDataReaderAdapter
	{
		/// <summary>
		/// 
		/// </summary>
		public global::System.Data.SqlClient.SqlDataReader InnerReader { get; }
	
		public DboUspSearchCandidateResumesSqlDataReaderAdapter(
			global::System.Data.SqlClient.SqlDataReader reader) : this()
		{
			if(ReferenceEquals(reader, null))
				throw new global::System.ArgumentNullException(nameof(reader));
			InnerReader = reader;
		}
	
		/// <summary>
		/// 
		/// </summary>
		public bool Read() { return InnerReader.Read(); }  
	
		/// <summary>
		/// 
		/// </summary>
		public DboUspSearchCandidateResumesSqlDataReaderAdapter2 NextResult() 
		{ 
			if(!InnerReader.NextResult())
				throw new global::System.InvalidOperationException($"[dbo].[uspSearchCandidateResumes] > InnerReader.NextResult() returned false (next result number: 1).");
			return new DboUspSearchCandidateResumesSqlDataReaderAdapter2(InnerReader); 
		}
		 
	
		 
		/// <summary>
		/// 
		/// </summary>
		public int JobCandidateID => SqlDbClient.ToClrValue<int>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public int? RANK => SqlDbClient.ToClrValue<int?>(InnerReader[1]);  
	}
	/// <summary>
	/// [dbo].[uspSearchCandidateResumes] result[1]
	/// </summary>
	public partial struct DboUspSearchCandidateResumesSqlDataReaderAdapter2
	{
		/// <summary>
		/// 
		/// </summary>
		public global::System.Data.SqlClient.SqlDataReader InnerReader { get; }
	
		public DboUspSearchCandidateResumesSqlDataReaderAdapter2(
			global::System.Data.SqlClient.SqlDataReader reader) : this()
		{
			if(ReferenceEquals(reader, null))
				throw new global::System.ArgumentNullException(nameof(reader));
			InnerReader = reader;
		}
	
		/// <summary>
		/// 
		/// </summary>
		public bool Read() { return InnerReader.Read(); }  
	
		/// <summary>
		/// 
		/// </summary>
		public DboUspSearchCandidateResumesSqlDataReaderAdapter3 NextResult() 
		{ 
			if(!InnerReader.NextResult())
				throw new global::System.InvalidOperationException($"[dbo].[uspSearchCandidateResumes] > InnerReader.NextResult() returned false (next result number: 2).");
			return new DboUspSearchCandidateResumesSqlDataReaderAdapter3(InnerReader); 
		}
		 
	
		 
		/// <summary>
		/// 
		/// </summary>
		public int JobCandidateID => SqlDbClient.ToClrValue<int>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public int? RANK => SqlDbClient.ToClrValue<int?>(InnerReader[1]);  
	}
	/// <summary>
	/// [dbo].[uspSearchCandidateResumes] result[2]
	/// </summary>
	public partial struct DboUspSearchCandidateResumesSqlDataReaderAdapter3
	{
		/// <summary>
		/// 
		/// </summary>
		public global::System.Data.SqlClient.SqlDataReader InnerReader { get; }
	
		public DboUspSearchCandidateResumesSqlDataReaderAdapter3(
			global::System.Data.SqlClient.SqlDataReader reader) : this()
		{
			if(ReferenceEquals(reader, null))
				throw new global::System.ArgumentNullException(nameof(reader));
			InnerReader = reader;
		}
	
		/// <summary>
		/// 
		/// </summary>
		public bool Read() { return InnerReader.Read(); }  
	
		/// <summary>
		/// 
		/// </summary>
		public DboUspSearchCandidateResumesSqlDataReaderAdapter4 NextResult() 
		{ 
			if(!InnerReader.NextResult())
				throw new global::System.InvalidOperationException($"[dbo].[uspSearchCandidateResumes] > InnerReader.NextResult() returned false (next result number: 3).");
			return new DboUspSearchCandidateResumesSqlDataReaderAdapter4(InnerReader); 
		}
		 
	
		 
		/// <summary>
		/// 
		/// </summary>
		public int JobCandidateID => SqlDbClient.ToClrValue<int>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public int? RANK => SqlDbClient.ToClrValue<int?>(InnerReader[1]);  
	}
	/// <summary>
	/// [dbo].[uspSearchCandidateResumes] result[3]
	/// </summary>
	public partial struct DboUspSearchCandidateResumesSqlDataReaderAdapter4
	{
		/// <summary>
		/// 
		/// </summary>
		public global::System.Data.SqlClient.SqlDataReader InnerReader { get; }
	
		public DboUspSearchCandidateResumesSqlDataReaderAdapter4(
			global::System.Data.SqlClient.SqlDataReader reader) : this()
		{
			if(ReferenceEquals(reader, null))
				throw new global::System.ArgumentNullException(nameof(reader));
			InnerReader = reader;
		}
	
		/// <summary>
		/// 
		/// </summary>
		public bool Read() { return InnerReader.Read(); }  
	
		 
		/// <summary>
		/// 
		/// </summary>
		public int JobCandidateID => SqlDbClient.ToClrValue<int>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public int? RANK => SqlDbClient.ToClrValue<int?>(InnerReader[1]);  
	}

	 
	
	
	/// <summary>
	/// [HumanResources].[uspUpdateEmployeeHireInfo] typed component factory.
	/// </summary>
	public partial class HumanResourcesUspUpdateEmployeeHireInfoComponentFactory
	{
		public const string ProcedureName = "[HumanResources].[uspUpdateEmployeeHireInfo]";
	
		#region Private Fields
		 
		#endregion
	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public HumanResourcesUspUpdateEmployeeHireInfoComponentFactory()
		{
			OnInit();
		}
	
		#region Partial Methods
		static partial void OnInit();
		static partial void OnCommandCreated(global::System.Data.SqlClient.SqlCommand command);
		 
		static partial void OnBusinessEntityIDParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnJobTitleParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnHireDateParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnRateChangeDateParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnRateParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnPayFrequencyParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnCurrentFlagParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		#endregion
	
		/// <summary>
		/// Creates new [HumanResources].[uspUpdateEmployeeHireInfo] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand(global::System.Data.SqlClient.SqlConnection connection)
		{
			if(ReferenceEquals(connection, null))
				throw new global::System.ArgumentNullException(nameof(connection));
			var command = this.BuildCommand();
			command.Connection = connection;
			return command;
		}
	
		/// <summary>
		/// Creates new [HumanResources].[uspUpdateEmployeeHireInfo] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand(global::System.Data.SqlClient.SqlTransaction transaction)
		{
			if(ReferenceEquals(transaction, null))
				throw new global::System.ArgumentNullException(nameof(transaction));
			if(ReferenceEquals(transaction.Connection, null))
				throw new global::System.InvalidOperationException("transaction.Connection is null");
			var command = this.BuildCommand();
			command.Connection = transaction.Connection;
			command.Transaction = transaction;
			return command;
		}
	
		/// <summary>
		/// Creates new [HumanResources].[uspUpdateEmployeeHireInfo] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand()
		{
			var command = new global::System.Data.SqlClient.SqlCommand();
			this.BuildCommand(command);
			return command;
		}
	
		/// <summary>
		/// Configures the given command object to execute the [HumanResources].[uspUpdateEmployeeHireInfo] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
		{
			if(ReferenceEquals(command, null))
				throw new global::System.ArgumentNullException(nameof(command));		
			var parameters = CreateParametersArray(); 
			parameters[1].Value = this.BusinessEntityID;  
			parameters[2].Value = this.JobTitle;  
			parameters[3].Value = this.HireDate;  
			parameters[4].Value = this.RateChangeDate;  
			parameters[5].Value = this.Rate;  
			parameters[6].Value = this.PayFrequency;  
			parameters[7].Value = this.CurrentFlag;  
			for (int i = 0; i < parameters.Length; ++i)
			{
				var parameter = parameters[i];
				if (parameter.Value == null)
					parameter.Value = global::System.DBNull.Value;
			}
			command.CommandText = ProcedureName;
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [HumanResources].[uspUpdateEmployeeHireInfo] -command output values set
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public ReturnValueSqlCommandOutput BuildOutputValues(global::System.Data.SqlClient.SqlCommand command)
		{			
			return new ReturnValueSqlCommandOutput(command);
		}
		
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public static global::System.Data.SqlClient.SqlCommand CreateCommand(int? businessEntityID, string jobTitle, System.DateTime? hireDate, System.DateTime? rateChangeDate, decimal? rate, byte? payFrequency, bool? currentFlag)
		{
			var builder = new HumanResourcesUspUpdateEmployeeHireInfoComponentFactory()		
			{ 
				BusinessEntityID = businessEntityID,  
				JobTitle = jobTitle,  
				HireDate = hireDate,  
				RateChangeDate = rateChangeDate,  
				Rate = rate,  
				PayFrequency = payFrequency,  
				CurrentFlag = currentFlag,  
			};
			
			return builder.BuildCommand();
		}
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public static global::System.Data.SqlClient.SqlParameter[] CreateParametersArray()
		{
			var parameters = new []
			{ 
				new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.ReturnValue}, 
				new global::System.Data.SqlClient.SqlParameter("@BusinessEntityID", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@JobTitle", global::System.Data.SqlDbType.NVarChar){ Direction = global::System.Data.ParameterDirection.Input, Size = 50}, 
				new global::System.Data.SqlClient.SqlParameter("@HireDate", global::System.Data.SqlDbType.DateTime){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@RateChangeDate", global::System.Data.SqlDbType.DateTime){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@Rate", global::System.Data.SqlDbType.Money){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@PayFrequency", global::System.Data.SqlDbType.TinyInt){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@CurrentFlag", global::System.Data.SqlDbType.Bit){ Direction = global::System.Data.ParameterDirection.Input}, 
			};
	
			 
			OnBusinessEntityIDParameterCreated(parameters[1]);  
			OnJobTitleParameterCreated(parameters[2]);  
			OnHireDateParameterCreated(parameters[3]);  
			OnRateChangeDateParameterCreated(parameters[4]);  
			OnRateParameterCreated(parameters[5]);  
			OnPayFrequencyParameterCreated(parameters[6]);  
			OnCurrentFlagParameterCreated(parameters[7]);  
	
			return parameters;
		}
		#region Sql Parameter Properties
		/// <summary>
		/// Parameter 1
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public int? BusinessEntityID { get; set; }
		/// <summary>
		/// Parameter 2
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public string JobTitle { get; set; }
		/// <summary>
		/// Parameter 3
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public System.DateTime? HireDate { get; set; }
		/// <summary>
		/// Parameter 4
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public System.DateTime? RateChangeDate { get; set; }
		/// <summary>
		/// Parameter 5
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public decimal? Rate { get; set; }
		/// <summary>
		/// Parameter 6
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public byte? PayFrequency { get; set; }
		/// <summary>
		/// Parameter 7
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public bool? CurrentFlag { get; set; }
	
	
		#endregion
	}
	
	
	
	

	 
	
	
	/// <summary>
	/// [HumanResources].[uspUpdateEmployeeLogin] typed component factory.
	/// </summary>
	public partial class HumanResourcesUspUpdateEmployeeLoginComponentFactory
	{
		public const string ProcedureName = "[HumanResources].[uspUpdateEmployeeLogin]";
	
		#region Private Fields
		 
		#endregion
	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public HumanResourcesUspUpdateEmployeeLoginComponentFactory()
		{
			OnInit();
		}
	
		#region Partial Methods
		static partial void OnInit();
		static partial void OnCommandCreated(global::System.Data.SqlClient.SqlCommand command);
		 
		static partial void OnBusinessEntityIDParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnOrganizationNodeParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnLoginIDParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnJobTitleParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnHireDateParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnCurrentFlagParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		#endregion
	
		/// <summary>
		/// Creates new [HumanResources].[uspUpdateEmployeeLogin] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand(global::System.Data.SqlClient.SqlConnection connection)
		{
			if(ReferenceEquals(connection, null))
				throw new global::System.ArgumentNullException(nameof(connection));
			var command = this.BuildCommand();
			command.Connection = connection;
			return command;
		}
	
		/// <summary>
		/// Creates new [HumanResources].[uspUpdateEmployeeLogin] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand(global::System.Data.SqlClient.SqlTransaction transaction)
		{
			if(ReferenceEquals(transaction, null))
				throw new global::System.ArgumentNullException(nameof(transaction));
			if(ReferenceEquals(transaction.Connection, null))
				throw new global::System.InvalidOperationException("transaction.Connection is null");
			var command = this.BuildCommand();
			command.Connection = transaction.Connection;
			command.Transaction = transaction;
			return command;
		}
	
		/// <summary>
		/// Creates new [HumanResources].[uspUpdateEmployeeLogin] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand()
		{
			var command = new global::System.Data.SqlClient.SqlCommand();
			this.BuildCommand(command);
			return command;
		}
	
		/// <summary>
		/// Configures the given command object to execute the [HumanResources].[uspUpdateEmployeeLogin] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
		{
			if(ReferenceEquals(command, null))
				throw new global::System.ArgumentNullException(nameof(command));		
			var parameters = CreateParametersArray(); 
			parameters[1].Value = this.BusinessEntityID;  
			parameters[2].Value = this.OrganizationNode;  
			parameters[3].Value = this.LoginID;  
			parameters[4].Value = this.JobTitle;  
			parameters[5].Value = this.HireDate;  
			parameters[6].Value = this.CurrentFlag;  
			for (int i = 0; i < parameters.Length; ++i)
			{
				var parameter = parameters[i];
				if (parameter.Value == null)
					parameter.Value = global::System.DBNull.Value;
			}
			command.CommandText = ProcedureName;
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [HumanResources].[uspUpdateEmployeeLogin] -command output values set
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public ReturnValueSqlCommandOutput BuildOutputValues(global::System.Data.SqlClient.SqlCommand command)
		{			
			return new ReturnValueSqlCommandOutput(command);
		}
		
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public static global::System.Data.SqlClient.SqlCommand CreateCommand(int? businessEntityID, object organizationNode, string loginID, string jobTitle, System.DateTime? hireDate, bool? currentFlag)
		{
			var builder = new HumanResourcesUspUpdateEmployeeLoginComponentFactory()		
			{ 
				BusinessEntityID = businessEntityID,  
				OrganizationNode = organizationNode,  
				LoginID = loginID,  
				JobTitle = jobTitle,  
				HireDate = hireDate,  
				CurrentFlag = currentFlag,  
			};
			
			return builder.BuildCommand();
		}
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public static global::System.Data.SqlClient.SqlParameter[] CreateParametersArray()
		{
			var parameters = new []
			{ 
				new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.ReturnValue}, 
				new global::System.Data.SqlClient.SqlParameter("@BusinessEntityID", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@OrganizationNode", global::System.Data.SqlDbType.Udt){ Direction = global::System.Data.ParameterDirection.Input, Size = 892}, 
				new global::System.Data.SqlClient.SqlParameter("@LoginID", global::System.Data.SqlDbType.NVarChar){ Direction = global::System.Data.ParameterDirection.Input, Size = 256}, 
				new global::System.Data.SqlClient.SqlParameter("@JobTitle", global::System.Data.SqlDbType.NVarChar){ Direction = global::System.Data.ParameterDirection.Input, Size = 50}, 
				new global::System.Data.SqlClient.SqlParameter("@HireDate", global::System.Data.SqlDbType.DateTime){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@CurrentFlag", global::System.Data.SqlDbType.Bit){ Direction = global::System.Data.ParameterDirection.Input}, 
			};
	
			 
			OnBusinessEntityIDParameterCreated(parameters[1]);  
			OnOrganizationNodeParameterCreated(parameters[2]);  
			OnLoginIDParameterCreated(parameters[3]);  
			OnJobTitleParameterCreated(parameters[4]);  
			OnHireDateParameterCreated(parameters[5]);  
			OnCurrentFlagParameterCreated(parameters[6]);  
	
			return parameters;
		}
		#region Sql Parameter Properties
		/// <summary>
		/// Parameter 1
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public int? BusinessEntityID { get; set; }
		/// <summary>
		/// Parameter 2
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public object OrganizationNode { get; set; }
		/// <summary>
		/// Parameter 3
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public string LoginID { get; set; }
		/// <summary>
		/// Parameter 4
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public string JobTitle { get; set; }
		/// <summary>
		/// Parameter 5
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public System.DateTime? HireDate { get; set; }
		/// <summary>
		/// Parameter 6
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public bool? CurrentFlag { get; set; }
	
	
		#endregion
	}
	
	
	
	

	 
	
	
	/// <summary>
	/// [HumanResources].[uspUpdateEmployeePersonalInfo] typed component factory.
	/// </summary>
	public partial class HumanResourcesUspUpdateEmployeePersonalInfoComponentFactory
	{
		public const string ProcedureName = "[HumanResources].[uspUpdateEmployeePersonalInfo]";
	
		#region Private Fields
		 
		#endregion
	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public HumanResourcesUspUpdateEmployeePersonalInfoComponentFactory()
		{
			OnInit();
		}
	
		#region Partial Methods
		static partial void OnInit();
		static partial void OnCommandCreated(global::System.Data.SqlClient.SqlCommand command);
		 
		static partial void OnBusinessEntityIDParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnNationalIDNumberParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnBirthDateParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnMaritalStatusParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnGenderParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		#endregion
	
		/// <summary>
		/// Creates new [HumanResources].[uspUpdateEmployeePersonalInfo] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand(global::System.Data.SqlClient.SqlConnection connection)
		{
			if(ReferenceEquals(connection, null))
				throw new global::System.ArgumentNullException(nameof(connection));
			var command = this.BuildCommand();
			command.Connection = connection;
			return command;
		}
	
		/// <summary>
		/// Creates new [HumanResources].[uspUpdateEmployeePersonalInfo] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand(global::System.Data.SqlClient.SqlTransaction transaction)
		{
			if(ReferenceEquals(transaction, null))
				throw new global::System.ArgumentNullException(nameof(transaction));
			if(ReferenceEquals(transaction.Connection, null))
				throw new global::System.InvalidOperationException("transaction.Connection is null");
			var command = this.BuildCommand();
			command.Connection = transaction.Connection;
			command.Transaction = transaction;
			return command;
		}
	
		/// <summary>
		/// Creates new [HumanResources].[uspUpdateEmployeePersonalInfo] -command pre-configured based on this factory object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public global::System.Data.SqlClient.SqlCommand BuildCommand()
		{
			var command = new global::System.Data.SqlClient.SqlCommand();
			this.BuildCommand(command);
			return command;
		}
	
		/// <summary>
		/// Configures the given command object to execute the [HumanResources].[uspUpdateEmployeePersonalInfo] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
		{
			if(ReferenceEquals(command, null))
				throw new global::System.ArgumentNullException(nameof(command));		
			var parameters = CreateParametersArray(); 
			parameters[1].Value = this.BusinessEntityID;  
			parameters[2].Value = this.NationalIDNumber;  
			parameters[3].Value = this.BirthDate;  
			parameters[4].Value = this.MaritalStatus;  
			parameters[5].Value = this.Gender;  
			for (int i = 0; i < parameters.Length; ++i)
			{
				var parameter = parameters[i];
				if (parameter.Value == null)
					parameter.Value = global::System.DBNull.Value;
			}
			command.CommandText = ProcedureName;
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [HumanResources].[uspUpdateEmployeePersonalInfo] -command output values set
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public ReturnValueSqlCommandOutput BuildOutputValues(global::System.Data.SqlClient.SqlCommand command)
		{			
			return new ReturnValueSqlCommandOutput(command);
		}
		
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public static global::System.Data.SqlClient.SqlCommand CreateCommand(int? businessEntityID, string nationalIDNumber, System.DateTime? birthDate, string maritalStatus, string gender)
		{
			var builder = new HumanResourcesUspUpdateEmployeePersonalInfoComponentFactory()		
			{ 
				BusinessEntityID = businessEntityID,  
				NationalIDNumber = nationalIDNumber,  
				BirthDate = birthDate,  
				MaritalStatus = maritalStatus,  
				Gender = gender,  
			};
			
			return builder.BuildCommand();
		}
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public static global::System.Data.SqlClient.SqlParameter[] CreateParametersArray()
		{
			var parameters = new []
			{ 
				new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.ReturnValue}, 
				new global::System.Data.SqlClient.SqlParameter("@BusinessEntityID", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@NationalIDNumber", global::System.Data.SqlDbType.NVarChar){ Direction = global::System.Data.ParameterDirection.Input, Size = 15}, 
				new global::System.Data.SqlClient.SqlParameter("@BirthDate", global::System.Data.SqlDbType.DateTime){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@MaritalStatus", global::System.Data.SqlDbType.NChar){ Direction = global::System.Data.ParameterDirection.Input, Size = 1}, 
				new global::System.Data.SqlClient.SqlParameter("@Gender", global::System.Data.SqlDbType.NChar){ Direction = global::System.Data.ParameterDirection.Input, Size = 1}, 
			};
	
			 
			OnBusinessEntityIDParameterCreated(parameters[1]);  
			OnNationalIDNumberParameterCreated(parameters[2]);  
			OnBirthDateParameterCreated(parameters[3]);  
			OnMaritalStatusParameterCreated(parameters[4]);  
			OnGenderParameterCreated(parameters[5]);  
	
			return parameters;
		}
		#region Sql Parameter Properties
		/// <summary>
		/// Parameter 1
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public int? BusinessEntityID { get; set; }
		/// <summary>
		/// Parameter 2
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public string NationalIDNumber { get; set; }
		/// <summary>
		/// Parameter 3
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public System.DateTime? BirthDate { get; set; }
		/// <summary>
		/// Parameter 4
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public string MaritalStatus { get; set; }
		/// <summary>
		/// Parameter 5
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public string Gender { get; set; }
	
	
		#endregion
	}
	
	
	
	

    
    /// <summary>
    /// <see cref="global::System.IDisposable"/> factory.
    /// </summary>
    public static class Disposable
    {
        public static readonly global::System.IDisposable Null = new DisposableNullObject();

        public static global::System.IDisposable Create(global::System.Action callback) { return new RelayDisposable(callback); }

        sealed class DisposableNullObject : global::System.IDisposable
        {
            public void Dispose() { }
        }

        sealed class RelayDisposable : global::System.IDisposable
        {
            private global::System.Action m_callback;

            public RelayDisposable(global::System.Action callback)
            {
                m_callback = callback;
            }

            public void Dispose()
            {
                m_callback?.Invoke();
                m_callback = null;
            }
        }
    }


    /// <summary>
    /// 
    /// </summary>
    public class SqlDbClient
    {
        #region Nested Types
        struct SqlCommandState
        {
            readonly global::System.Data.SqlClient.SqlConnection Connection;
            readonly global::System.Data.SqlClient.SqlTransaction Transaction;

            public SqlCommandState(global::System.Data.SqlClient.SqlCommand command)
            {
                Connection = command.Connection;
                Transaction = command.Transaction;
            }

            public void ApplyTo(global::System.Data.SqlClient.SqlCommand command)
            {
                command.Connection = Connection;
                command.Transaction = Transaction;
            }
        }

        class StatementCompletedHandler : global::System.IDisposable
        {
            private global::System.Data.SqlClient.SqlCommand m_command;
            private global::System.IDisposable m_session;
            private SqlCommandState m_initialState;
            private bool m_disposed;

            public StatementCompletedHandler(global::System.Data.SqlClient.SqlCommand command, global::System.IDisposable session, SqlCommandState initialState)
            {
                m_command = command;
                m_session = session;
                m_initialState = initialState;
                m_command.StatementCompleted += this.OnStatementCompleted;
            }

            private void OnStatementCompleted(object sender, global::System.Data.StatementCompletedEventArgs e)
            {
                this.Dispose();
            }

            public void Dispose()
            {
                if (m_disposed)
                    return;

                try
                {
                    m_command.StatementCompleted -= this.OnStatementCompleted;
                    m_initialState.ApplyTo(m_command);
                    m_session.Dispose();
                    m_initialState = new SqlCommandState();
                    m_session = null;
                    m_command = null;
                }
                finally
                {
                    m_disposed = true;
                }
            }
        }

        #endregion

        public global::System.Data.SqlClient.SqlConnection Connection { get; }

        public SqlDbClient(string connectionString)
        {
            if (ReferenceEquals(connectionString, null))
                throw new global::System.ArgumentNullException(nameof(connectionString));
            Connection = new global::System.Data.SqlClient.SqlConnection(connectionString);
        }

        public bool CloseSession()
        {
            if ((Connection.State & global::System.Data.ConnectionState.Closed) == global::System.Data.ConnectionState.Closed)
                return false;
            Connection.Close();
            return true;
        }

        public global::System.IDisposable OpenSession()
        {
            if ((Connection.State & global::System.Data.ConnectionState.Closed) == global::System.Data.ConnectionState.Closed)
            {
                Connection.Open();
                return Disposable.Create(Connection.Close);
            }

            return Disposable.Null;
        }

        public async global::System.Threading.Tasks.Task<global::System.IDisposable> OpenSessionAsync(global::System.Threading.CancellationToken token)
        {
            if ((Connection.State & global::System.Data.ConnectionState.Closed) == global::System.Data.ConnectionState.Closed)
            {
                await Connection.OpenAsync(token);
                return Disposable.Create(Connection.Close);
            }

            return Disposable.Null;
        }

        /// <summary>
        /// 
        /// </summary>
        public static T ToClrValue<T>(object value)
        {
            return (ReferenceEquals(value, null) || global::System.DBNull.Value.Equals(value))
                    ? default(T)
                    : (T)value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static object ToSqlValue<T>(T value)
        {
            return value == null
                ? (object)global::System.DBNull.Value
                : value;
        }

    }


    public struct ReturnValueSqlCommandOutput
    {
        readonly global::System.Data.SqlClient.SqlParameter m_returnValueParameter;

        /// <summary>
        /// 
        /// </summary>
        public ReturnValueSqlCommandOutput(global::System.Data.SqlClient.SqlCommand command)
	    {
		    if(ReferenceEquals(command, null))
			    throw new global::System.ArgumentNullException(nameof(command));
            for (int i = 0; i < command.Parameters.Count; ++i)
            {
                m_returnValueParameter = command.Parameters[i];
                if (m_returnValueParameter.Direction == global::System.Data.ParameterDirection.ReturnValue)
                    return;
            }

            throw new global::System.InvalidOperationException("RETURN_VALUE parameter not found.");
	    }

        /// <summary>
        /// 
        /// </summary>
        public int? RETURN_VALUE => SqlDbClient.ToClrValue<int?>(m_returnValueParameter.Value);
    }


 	
}