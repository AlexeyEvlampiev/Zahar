namespace Zahar
{	
	/// <summary>
	/// 
	/// </summary>
	public sealed class Client : SqlDbClient
	{
		/// <summary>
	    /// 
	    /// </summary>
		public Client(string connectionString)
			: base(connectionString)
		{
			
		} 
	
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspEcho01] components factory.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public DboUspEcho01ComponentFactory CreateDboUspEcho01ComponentFactory() { return new DboUspEcho01ComponentFactory(); }  
	
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspSelectFromTemporaryTable] components factory.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public DboUspSelectFromTemporaryTableComponentFactory CreateDboUspSelectFromTemporaryTableComponentFactory() { return new DboUspSelectFromTemporaryTableComponentFactory(); }  
	}
	 
	
	
	/// <summary>
	/// [dbo].[uspEcho01] typed component factory.
	/// </summary>
	public partial class DboUspEcho01ComponentFactory
	{
		public const string ProcedureName = "[dbo].[uspEcho01]";
	
		#region Private Fields
		 
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		private DboUdtt01UserDefinedDataTable m_firstTableValueParam;  
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		private DboUdtt02UserDefinedDataTable m_secondTableValueParam;  
		#endregion
	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public DboUspEcho01ComponentFactory()
		{
			OnInit();
		}
	
		#region Partial Methods
		static partial void OnInit();
		static partial void OnCommandCreated(global::System.Data.SqlClient.SqlCommand command);
		 
		static partial void OnFirstInputParameterParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnSecondInputParameterParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnFirstTableValueParamParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnFirstOutputParameterParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnSecondOutputParameterParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnSecondTableValueParamParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		#endregion
	
		/// <summary>
		/// Creates new [dbo].[uspEcho01] -command pre-configured based on this factory object.
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
		/// Creates new [dbo].[uspEcho01] -command pre-configured based on this factory object.
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
		/// Creates new [dbo].[uspEcho01] -command pre-configured based on this factory object.
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
		/// Configures the given command object to execute the [dbo].[uspEcho01] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
		{
			if(ReferenceEquals(command, null))
				throw new global::System.ArgumentNullException(nameof(command));		
			var parameters = CreateParametersArray(); 
			parameters[1].Value = this.FirstInputParameter;  
			parameters[2].Value = this.SecondInputParameter;  
			parameters[3].Value = this.FirstTableValueParam;  
			parameters[4].Value = this.FirstOutputParameter;  
			parameters[5].Value = this.SecondOutputParameter;  
			parameters[6].Value = this.SecondTableValueParam;  
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
		/// Creates new [dbo].[uspEcho01] -command output values set
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public DboUspEcho01OutputValueSet BuildOutputValues(global::System.Data.SqlClient.SqlCommand command)
		{			
			return new DboUspEcho01OutputValueSet(command);
		}
		 
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public DboUspEcho01SqlDataReaderAdapter BuildRecordAdapter(global::System.Data.SqlClient.SqlDataReader reader)
		{		
			return new DboUspEcho01SqlDataReaderAdapter(reader);
		}
		
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public static global::System.Data.SqlClient.SqlCommand CreateCommand(int? firstInputParameter, int? secondInputParameter, DboUdtt01UserDefinedDataTable firstTableValueParam, int? firstOutputParameter, int? secondOutputParameter, DboUdtt02UserDefinedDataTable secondTableValueParam)
		{
			var builder = new DboUspEcho01ComponentFactory()		
			{ 
				FirstInputParameter = firstInputParameter,  
				SecondInputParameter = secondInputParameter,  
				FirstTableValueParam = firstTableValueParam,  
				FirstOutputParameter = firstOutputParameter,  
				SecondOutputParameter = secondOutputParameter,  
				SecondTableValueParam = secondTableValueParam,  
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
				new global::System.Data.SqlClient.SqlParameter("@FirstInputParameter", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@SecondInputParameter", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@FirstTableValueParam", global::System.Data.SqlDbType.Structured){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@FirstOutputParameter", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.InputOutput}, 
				new global::System.Data.SqlClient.SqlParameter("@SecondOutputParameter", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.InputOutput}, 
				new global::System.Data.SqlClient.SqlParameter("@SecondTableValueParam", global::System.Data.SqlDbType.Structured){ Direction = global::System.Data.ParameterDirection.Input}, 
			};
	
			 
			OnFirstInputParameterParameterCreated(parameters[1]);  
			OnSecondInputParameterParameterCreated(parameters[2]);  
			OnFirstTableValueParamParameterCreated(parameters[3]);  
			OnFirstOutputParameterParameterCreated(parameters[4]);  
			OnSecondOutputParameterParameterCreated(parameters[5]);  
			OnSecondTableValueParamParameterCreated(parameters[6]);  
	
			return parameters;
		}
		#region Sql Parameter Properties
		/// <summary>
		/// Parameter 1 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		[SqlParameter(1,"FirstInputParameter", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? FirstInputParameter { get; set; }
		/// <summary>
		/// Parameter 2 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		[SqlParameter(2,"SecondInputParameter", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? SecondInputParameter { get; set; }
		/// <summary>
		/// Parameter 4 (InputOutput).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		[SqlParameter(4,"FirstOutputParameter", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.InputOutput)]
		public int? FirstOutputParameter { get; set; }
		/// <summary>
		/// Parameter 5 (InputOutput).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		[SqlParameter(5,"SecondOutputParameter", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.InputOutput)]
		public int? SecondOutputParameter { get; set; }
	
	
		/// <summary>
		/// Parameter 3
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		[SqlParameter(3,"FirstTableValueParam", global::System.Data.SqlDbType.Structured, global::System.Data.ParameterDirection.Input)]
		public DboUdtt01UserDefinedDataTable FirstTableValueParam
		{
			get { return this.m_firstTableValueParam ?? (this.m_firstTableValueParam = new DboUdtt01UserDefinedDataTable()); }
			set { this.m_firstTableValueParam = value; }
		}
		/// <summary>
		/// Parameter 6
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		[SqlParameter(6,"SecondTableValueParam", global::System.Data.SqlDbType.Structured, global::System.Data.ParameterDirection.Input)]
		public DboUdtt02UserDefinedDataTable SecondTableValueParam
		{
			get { return this.m_secondTableValueParam ?? (this.m_secondTableValueParam = new DboUdtt02UserDefinedDataTable()); }
			set { this.m_secondTableValueParam = value; }
		}
		#endregion
	}
	
	
	/// <summary>
	/// [dbo].[uspEcho01] output parameters
	/// </summary>
	public partial struct DboUspEcho01OutputValueSet
	{
		readonly global::System.Data.SqlClient.SqlCommand m_command;
		public DboUspEcho01OutputValueSet(global::System.Data.SqlClient.SqlCommand command)
		{
			if(ReferenceEquals(command, null))
				throw new global::System.ArgumentNullException(nameof(command)); 
			global::System.Diagnostics.Debug.Assert(command.Parameters.Contains("@RETURN_VALUE"));  
			global::System.Diagnostics.Debug.Assert(command.Parameters.Contains("@FirstOutputParameter"));  
			global::System.Diagnostics.Debug.Assert(command.Parameters.Contains("@SecondOutputParameter")); 	
			global::System.Diagnostics.Debug.Assert("[dbo].[uspEcho01]".Equals(command.CommandText, global::System.StringComparison.OrdinalIgnoreCase));				
			m_command = command;
		}
	
		 
		/// <summary>
		/// 
		/// </summary>
		[SqlParameter(0,"RETURN_VALUE", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.ReturnValue)]
		public int? RETURN_VALUE => SqlDbClient.ToClrValue<int?>(m_command.Parameters["@RETURN_VALUE"].Value);
		 
		/// <summary>
		/// 
		/// </summary>
		[SqlParameter(4,"FirstOutputParameter", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.InputOutput)]
		public int? FirstOutputParameter => SqlDbClient.ToClrValue<int?>(m_command.Parameters["@FirstOutputParameter"].Value);
		 
		/// <summary>
		/// 
		/// </summary>
		[SqlParameter(5,"SecondOutputParameter", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.InputOutput)]
		public int? SecondOutputParameter => SqlDbClient.ToClrValue<int?>(m_command.Parameters["@SecondOutputParameter"].Value);
		 
	}
	
	
	/// <summary>
	/// [dbo].[uspEcho01] result[0]
	/// </summary>
	public partial struct DboUspEcho01SqlDataReaderAdapter
	{
		/// <summary>
		/// 
		/// </summary>
		public global::System.Data.SqlClient.SqlDataReader InnerReader { get; }
	
		public DboUspEcho01SqlDataReaderAdapter(
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
		public DboUspEcho01SqlDataReaderAdapter2 NextResult() 
		{ 
			if(!InnerReader.NextResult())
				throw new global::System.InvalidOperationException($"[dbo].[uspEcho01] > InnerReader.NextResult() returned false (next result number: 1).");
			return new DboUspEcho01SqlDataReaderAdapter2(InnerReader); 
		}
		 
	
		 
		/// <summary>
		/// 
		/// </summary>
		public int? Field1 => SqlDbClient.ToClrValue<int?>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public int? Field2 => SqlDbClient.ToClrValue<int?>(InnerReader[1]);  
	}
	/// <summary>
	/// [dbo].[uspEcho01] result[1]
	/// </summary>
	public partial struct DboUspEcho01SqlDataReaderAdapter2
	{
		/// <summary>
		/// 
		/// </summary>
		public global::System.Data.SqlClient.SqlDataReader InnerReader { get; }
	
		public DboUspEcho01SqlDataReaderAdapter2(
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
		public DboUspEcho01SqlDataReaderAdapter3 NextResult() 
		{ 
			if(!InnerReader.NextResult())
				throw new global::System.InvalidOperationException($"[dbo].[uspEcho01] > InnerReader.NextResult() returned false (next result number: 2).");
			return new DboUspEcho01SqlDataReaderAdapter3(InnerReader); 
		}
		 
	
		 
		/// <summary>
		/// 
		/// </summary>
		public int Id => SqlDbClient.ToClrValue<int>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public string Name => SqlDbClient.ToClrValue<string>(InnerReader[1]);  
		/// <summary>
		/// 
		/// </summary>
		public System.DateTime? Date => SqlDbClient.ToClrValue<System.DateTime?>(InnerReader[2]);  
	}
	/// <summary>
	/// [dbo].[uspEcho01] result[2]
	/// </summary>
	public partial struct DboUspEcho01SqlDataReaderAdapter3
	{
		/// <summary>
		/// 
		/// </summary>
		public global::System.Data.SqlClient.SqlDataReader InnerReader { get; }
	
		public DboUspEcho01SqlDataReaderAdapter3(
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
		public int? Id => SqlDbClient.ToClrValue<int?>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public string Name => SqlDbClient.ToClrValue<string>(InnerReader[1]);  
	}

	 
	
	
	/// <summary>
	/// [dbo].[uspSelectFromTemporaryTable] typed component factory.
	/// </summary>
	public partial class DboUspSelectFromTemporaryTableComponentFactory
	{
		public const string ProcedureName = "[dbo].[uspSelectFromTemporaryTable]";
	
		#region Private Fields
		 
		#endregion
	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public DboUspSelectFromTemporaryTableComponentFactory()
		{
			OnInit();
		}
	
		#region Partial Methods
		static partial void OnInit();
		static partial void OnCommandCreated(global::System.Data.SqlClient.SqlCommand command);
		 
		static partial void OnParam1ParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnParam2ParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		#endregion
	
		/// <summary>
		/// Creates new [dbo].[uspSelectFromTemporaryTable] -command pre-configured based on this factory object.
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
		/// Creates new [dbo].[uspSelectFromTemporaryTable] -command pre-configured based on this factory object.
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
		/// Creates new [dbo].[uspSelectFromTemporaryTable] -command pre-configured based on this factory object.
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
		/// Configures the given command object to execute the [dbo].[uspSelectFromTemporaryTable] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
		{
			if(ReferenceEquals(command, null))
				throw new global::System.ArgumentNullException(nameof(command));		
			var parameters = CreateParametersArray(); 
			parameters[1].Value = this.Param1;  
			parameters[2].Value = this.Param2;  
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
		/// Creates new [dbo].[uspSelectFromTemporaryTable] -command output values set
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
		public static global::System.Data.SqlClient.SqlCommand CreateCommand(int? param1, int? param2)
		{
			var builder = new DboUspSelectFromTemporaryTableComponentFactory()		
			{ 
				Param1 = param1,  
				Param2 = param2,  
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
				new global::System.Data.SqlClient.SqlParameter("@param1", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@param2", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
			};
	
			 
			OnParam1ParameterCreated(parameters[1]);  
			OnParam2ParameterCreated(parameters[2]);  
	
			return parameters;
		}
		#region Sql Parameter Properties
		/// <summary>
		/// Parameter 1 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		[SqlParameter(1,"param1", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Param1 { get; set; }
		/// <summary>
		/// Parameter 2 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		[SqlParameter(2,"param2", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Param2 { get; set; }
	
	
		#endregion
	}
	
	
	
	

	
	/// <summary>
	/// [dbo].[Udtt01] user defined tabletype.
	/// </summary>	
	[global::System.Serializable()]
	public partial class DboUdtt01UserDefinedDataTable : global::System.Data.TypedTableBase<DboUdtt01UserDefinedDataTableRow>
	{
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public DboUdtt01UserDefinedDataTable()
		{
			this.TableName = @"[dbo].[Udtt01]";
			this.BeginInit();
			this.InitClass();
			this.EndInit();
		}
	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		protected DboUdtt01UserDefinedDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
				base(info, context) 
		{
			
		}
	
		public void Populate<T>(
			System.Collections.Generic.IEnumerable<T> entities, 
			System.Action<T, DboUdtt01UserDefinedDataTableRow> initializeRow)
		{
			foreach(var entity in entities)
			{
				var row = this.NewRow();
				initializeRow(entity, row);
				this.Rows.Add(row);
			}
		}
	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public new DboUdtt01UserDefinedDataTableRow NewRow() { return ((DboUdtt01UserDefinedDataTableRow)(base.NewRow())); }
				
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) { return new DboUdtt01UserDefinedDataTableRow(builder); }
				
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		protected override global::System.Type GetRowType() { return typeof(DboUdtt01UserDefinedDataTableRow); }
	
		public static global::System.Data.DataColumn[] CreateColumnsArray()
		{
			var columns = new global::System.Data.DataColumn[]{ 
				new global::System.Data.DataColumn("Id", typeof(System.Int32), null, global::System.Data.MappingType.Element),  
				new global::System.Data.DataColumn("Name", typeof(System.String), null, global::System.Data.MappingType.Element),  
				new global::System.Data.DataColumn("Date", typeof(System.DateTime), null, global::System.Data.MappingType.Element),  
			};
			 
			columns[0].AllowDBNull = false; // Id  
			columns[1].AllowDBNull = false; // Name   
			columns[1].MaxLength = 128; // Name        
			columns[0].Unique = true; // Id    
			columns[0].DefaultValue = default(int); // Id   
	
			return columns;
		}
	
		private void InitClass()
		{
			var columns = DboUdtt01UserDefinedDataTable.CreateColumnsArray();
			foreach (var column in columns) { this.Columns.Add(column); } 
			this.Constraints.Clear();  
			this.Constraints.Add(new global::System.Data.UniqueConstraint("UniqueConstraint_0", 
				 new global::System.Data.DataColumn[]
				 { 
					this.Columns[0], // Id  
				 }, isPrimaryKey: true));
			  
			this.PrimaryKey = new []{ this.Columns[0] };  
		}
	}
	
	/// <summary>
	/// [dbo].[Udtt01] data row
	/// </summary>		
	public partial class DboUdtt01UserDefinedDataTableRow : global::System.Data.DataRow
	{	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		internal DboUdtt01UserDefinedDataTableRow(global::System.Data.DataRowBuilder rb) : base(rb) 
		{
		}
	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public new DboUdtt01UserDefinedDataTable Table => (DboUdtt01UserDefinedDataTable)base.Table;
	
		 
		/// <summary>
	    /// Gets or sets the "Id" value.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")] 
		[global::System.ComponentModel.DataAnnotations.Key()]  
		[global::System.ComponentModel.DataAnnotations.Schema.Column("Id", Order = 0)]
		public int Id
		{
			get { return SqlDbClient.ToClrValue<int>(this[0]); }
			set { this[0] = SqlDbClient.ToSqlValue(value); }
		}
		 
		/// <summary>
	    /// Gets or sets the "Name" value.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")] 
		[global::System.ComponentModel.DataAnnotations.Schema.Column("Name", Order = 1)]
		public string Name
		{
			get { return SqlDbClient.ToClrValue<string>(this[1]); }
			set { this[1] = SqlDbClient.ToSqlValue(value); }
		}
		 
		/// <summary>
	    /// Gets or sets the "Date" value.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")] 
		[global::System.ComponentModel.DataAnnotations.Schema.Column("Date", Order = 2)]
		public System.DateTime? Date
		{
			get { return SqlDbClient.ToClrValue<System.DateTime?>(this[2]); }
			set { this[2] = SqlDbClient.ToSqlValue(value); }
		}
		 
	}

	
	/// <summary>
	/// [dbo].[Udtt02] user defined tabletype.
	/// </summary>	
	[global::System.Serializable()]
	public partial class DboUdtt02UserDefinedDataTable : global::System.Data.TypedTableBase<DboUdtt02UserDefinedDataTableRow>
	{
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public DboUdtt02UserDefinedDataTable()
		{
			this.TableName = @"[dbo].[Udtt02]";
			this.BeginInit();
			this.InitClass();
			this.EndInit();
		}
	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		protected DboUdtt02UserDefinedDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
				base(info, context) 
		{
			
		}
	
		public void Populate<T>(
			System.Collections.Generic.IEnumerable<T> entities, 
			System.Action<T, DboUdtt02UserDefinedDataTableRow> initializeRow)
		{
			foreach(var entity in entities)
			{
				var row = this.NewRow();
				initializeRow(entity, row);
				this.Rows.Add(row);
			}
		}
	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public new DboUdtt02UserDefinedDataTableRow NewRow() { return ((DboUdtt02UserDefinedDataTableRow)(base.NewRow())); }
				
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) { return new DboUdtt02UserDefinedDataTableRow(builder); }
				
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		protected override global::System.Type GetRowType() { return typeof(DboUdtt02UserDefinedDataTableRow); }
	
		public static global::System.Data.DataColumn[] CreateColumnsArray()
		{
			var columns = new global::System.Data.DataColumn[]{ 
				new global::System.Data.DataColumn("Id", typeof(System.Int32), null, global::System.Data.MappingType.Element),  
				new global::System.Data.DataColumn("Name", typeof(System.String), null, global::System.Data.MappingType.Element),  
			};
			  
			columns[1].MaxLength = 128; // Name           
	
			return columns;
		}
	
		private void InitClass()
		{
			var columns = DboUdtt02UserDefinedDataTable.CreateColumnsArray();
			foreach (var column in columns) { this.Columns.Add(column); } 
			this.Constraints.Clear();   
		}
	}
	
	/// <summary>
	/// [dbo].[Udtt02] data row
	/// </summary>		
	public partial class DboUdtt02UserDefinedDataTableRow : global::System.Data.DataRow
	{	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		internal DboUdtt02UserDefinedDataTableRow(global::System.Data.DataRowBuilder rb) : base(rb) 
		{
		}
	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		public new DboUdtt02UserDefinedDataTable Table => (DboUdtt02UserDefinedDataTable)base.Table;
	
		 
		/// <summary>
	    /// Gets or sets the "Id" value.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")] 
		[global::System.ComponentModel.DataAnnotations.Schema.Column("Id", Order = 0)]
		public int? Id
		{
			get { return SqlDbClient.ToClrValue<int?>(this[0]); }
			set { this[0] = SqlDbClient.ToSqlValue(value); }
		}
		 
		/// <summary>
	    /// Gets or sets the "Name" value.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")] 
		[global::System.ComponentModel.DataAnnotations.Schema.Column("Name", Order = 1)]
		public string Name
		{
			get { return SqlDbClient.ToClrValue<string>(this[1]); }
			set { this[1] = SqlDbClient.ToSqlValue(value); }
		}
		 
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
        #region Private Fields
        readonly global::System.Collections.Generic.Stack<global::System.Data.SqlClient.SqlTransaction>
            m_transactions = new global::System.Collections.Generic.Stack<global::System.Data.SqlClient.SqlTransaction>(); 
        #endregion

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

        #endregion

        /// <summary>
        /// Gets the underlying <see cref="global::System.Data.SqlClient.SqlConnection"/> object.
        /// </summary>
        public global::System.Data.SqlClient.SqlConnection Connection { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlDbClient"/> class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <exception cref="global::System.ArgumentNullException">connectionString</exception>
        public SqlDbClient(string connectionString)
        {
            if (ReferenceEquals(connectionString, null))
                throw new global::System.ArgumentNullException(nameof(connectionString));
            Connection = new global::System.Data.SqlClient.SqlConnection(connectionString);
        }

        /// <summary>
        /// Closes the underlying <see cref="global::System.Data.SqlClient.SqlConnection"/> object.
        /// </summary>
        /// <returns></returns>
        public bool CloseSession()
        {
            if ((Connection.State | global::System.Data.ConnectionState.Closed) != global::System.Data.ConnectionState.Closed)
                return false;
            Connection.Close();
            return true;
        }

        /// <summary>
        /// Opens the underlying <see cref="global::System.Data.SqlClient.SqlConnection"/> if not yet opened.
        /// </summary>
        /// <returns></returns>
        public global::System.IDisposable OpenSession()
        {
            if ((Connection.State | global::System.Data.ConnectionState.Closed) == global::System.Data.ConnectionState.Closed)
            {
                Connection.Open();
                return Disposable.Create(Connection.Close);
            }

            return Disposable.Null;
        }

        /// <summary>
        /// Opens the underlying <see cref="global::System.Data.SqlClient.SqlConnection"/> asynchronously if not yet opened.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        public async global::System.Threading.Tasks.Task<global::System.IDisposable> OpenSessionAsync(global::System.Threading.CancellationToken token)
        {
            if ((Connection.State & global::System.Data.ConnectionState.Closed) == global::System.Data.ConnectionState.Closed)
            {
                await Connection.OpenAsync(token);
                return Disposable.Create(Connection.Close);
            }

            return Disposable.Null;
        }

        public int ExecuteNonQuery(global::System.Data.SqlClient.SqlCommand command)
        {
            using (OpenSession())
            {
                var initialState = new SqlCommandState(command);
                try
                {
                    command.Connection = this.Connection;
                    //if (m_transactions.Count > 0)
                    //    command.Transaction = m_transactions.Peek();
                    return command.ExecuteNonQuery();
                }
                finally
                {
                    initialState.ApplyTo(command);
                }
            }
        }

        public async global::System.Threading.Tasks.Task<int> ExecuteNonQueryAsync(
            global::System.Data.SqlClient.SqlCommand command, 
            global::System.Threading.CancellationToken token)
        {
            using (await OpenSessionAsync(token))
            {
                var initialState = new SqlCommandState(command);
                try
                {
                    //command.Connection = this.m_connection;
                    //if (m_transactions.Count > 0)
                    //    command.Transaction = m_transactions.Peek();
                    return await command.ExecuteNonQueryAsync(token);
                }
                finally
                {
                    initialState.ApplyTo(command);
                }
            }
        }

        public object ExecuteScalar(global::System.Data.SqlClient.SqlCommand command)
        {
            using (OpenSession())
            {
                var initialState = new SqlCommandState(command);
                try
                {
                    command.Connection = this.Connection;
                    //if (m_transactions.Count > 0)
                    //    command.Transaction = m_transactions.Peek();
                    return command.ExecuteScalar();
                }
                finally
                {
                    initialState.ApplyTo(command);
                }
            }
        }

        public async global::System.Threading.Tasks.Task<object> ExecuteScalarAsync(
            global::System.Data.SqlClient.SqlCommand command, 
            global::System.Threading.CancellationToken token)
        {
            using (await OpenSessionAsync(token))
            {
                var initialState = new SqlCommandState(command);
                try
                {
                    command.Connection = this.Connection;
                    //if (m_transactions.Count > 0)
                    //    command.Transaction = m_transactions.Peek();
                    return await command.ExecuteScalarAsync(token);
                }
                finally
                {
                    initialState.ApplyTo(command);
                }
            }
        }

        public global::System.Data.SqlClient.SqlDataReader ExecuteReader(
            global::System.Data.SqlClient.SqlCommand command,
            global::System.Data.CommandBehavior commandBehavior = global::System.Data.CommandBehavior.Default)
        {
            var initialState = new SqlCommandState(command);
            bool autoOpen = Connection.State == global::System.Data.ConnectionState.Closed;
            try
            {
                command.Connection = Connection;

                if (autoOpen)
                {
                    Connection.Open();
                    commandBehavior |= global::System.Data.CommandBehavior.CloseConnection;
                }

                var reader = command.ExecuteReader(commandBehavior);
                return reader;

            }
            catch
            {
                if (autoOpen && Connection.State != global::System.Data.ConnectionState.Closed)
                    Connection.Close();
                throw;
            }
            finally
            {
                initialState.ApplyTo(command);
            }
        }

        public async global::System.Threading.Tasks.Task<global::System.Data.SqlClient.SqlDataReader> ExecuteReaderAsync(
            global::System.Data.SqlClient.SqlCommand command,
            global::System.Threading.CancellationToken token, 
            global::System.Data.CommandBehavior commandBehavior = global::System.Data.CommandBehavior.Default)
        {
            var initialState = new SqlCommandState(command);
            bool autoOpen = Connection.State == global::System.Data.ConnectionState.Closed;
            try
            {
                command.Connection = Connection;

                if (autoOpen)
                {
                    await Connection.OpenAsync();
                    commandBehavior |= global::System.Data.CommandBehavior.CloseConnection;
                }

                var reader = command.ExecuteReader(commandBehavior);
                return reader;

            }
            catch
            {
                if (autoOpen && Connection.State != global::System.Data.ConnectionState.Closed)
                    Connection.Close();
                throw;
            }
            finally
            {
                initialState.ApplyTo(command);
            }
        }

        public global::System.Xml.XmlReader ExecuteXmlReader(global::System.Data.SqlClient.SqlCommand command)
        {
            using (OpenSession())
            {
                var initialState = new SqlCommandState(command);
                try
                {
                    command.Connection = this.Connection;
                    //if (m_transactions.Count > 0)
                    //    command.Transaction = m_transactions.Peek();
                    return command.ExecuteXmlReader();
                }
                finally
                {
                    initialState.ApplyTo(command);
                }
            }
        }

        public async global::System.Threading.Tasks.Task<global::System.Xml.XmlReader> ExecuteXmlReaderAsync(
            global::System.Data.SqlClient.SqlCommand command,
            global::System.Threading.CancellationToken token)
        {
            using (await OpenSessionAsync(token))
            {
                var initialState = new SqlCommandState(command);
                try
                {
                    command.Connection = Connection;
                    //if (m_transactions.Count > 0)
                    //    command.Transaction = m_transactions.Peek();
                    return await command.ExecuteXmlReaderAsync(token);
                }
                finally
                {
                    initialState.ApplyTo(command);
                }
            }
        }

        /// <summary>
        /// Starts a database transaction.
        /// </summary>
        /// <exception cref="global::System.Data.SqlClient.SqlException">Parallel transactions are not allowed when using Multiple Active Result Sets (MARS).</exception>
        /// <exception cref="global::System.InvalidOperationException">Parallel transactions are not supported.</exception>
        public ISqlTransaction BeginTransaction()
        {
            return new SqlTransactionWrapper(this.Connection.BeginTransaction(), m_transactions);
        }

        /// <summary>
        /// Starts a database transaction with the specified isolation level.
        /// </summary>
        /// <param name="iso">The isolation level under which the transaction should run.</param>
        /// <exception cref="global::System.Data.SqlClient.SqlException">Parallel transactions are not allowed when using Multiple Active Result Sets (MARS).</exception>
        /// <exception cref="global::System.InvalidOperationException">Parallel transactions are not supported.</exception>
        public ISqlTransaction BeginTransaction(global::System.Data.IsolationLevel iso)
        {
            return new SqlTransactionWrapper(this.Connection.BeginTransaction(iso), m_transactions);
        }

        /// <summary>
        /// Starts a database transaction with the specified transaction name.
        /// </summary>
        /// <param name="transactionName">The name of the transaction..</param>
        /// <exception cref="global::System.Data.SqlClient.SqlException">Parallel transactions are not allowed when using Multiple Active Result Sets (MARS).</exception>
        /// <exception cref="global::System.InvalidOperationException">Parallel transactions are not supported.</exception>
        public ISqlTransaction BeginTransaction(string transactionName)
        {
            return new SqlTransactionWrapper(this.Connection.BeginTransaction(transactionName), m_transactions);
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
        [SqlParameter(0, "RETURN_VALUE", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.ReturnValue)]
        public int? RETURN_VALUE => SqlDbClient.ToClrValue<int?>(m_returnValueParameter.Value);
    }


    [global::System.AttributeUsage(global::System.AttributeTargets.Property)]
    public sealed class SqlParameterAttribute : global::System.Attribute
    {
        public SqlParameterAttribute(
            int ordinal,
            string parameterName, 
            global::System.Data.SqlDbType sqlDbType, 
            global::System.Data.ParameterDirection direction)
        {
            this.Ordinal = ordinal;
            this.ParameterName = parameterName;
            this.SqlDbType = sqlDbType;
            this.Direction = direction;
        }

        public SqlParameterAttribute(
            int ordinal,
            string parameterName,
            global::System.Data.SqlDbType sqlDbType,
            global::System.Data.ParameterDirection direction,
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

        public global::System.Data.SqlDbType SqlDbType { get; }

        public global::System.Data.ParameterDirection Direction { get; }

        public int? Size { get; }
    }


    /// <summary>
    /// Represents a Transact-SQL transaction to be made in a SQL Server database.
    /// </summary>
    public interface ISqlTransaction : global::System.IDisposable
    {
        /// <summary>
        /// Gets the isolation level for this transaction.
        /// </summary>
        global::System.Data.IsolationLevel IsolationLevel { get; }

        /// <summary>
        /// Commits the database transaction.
        /// </summary>
        /// <exception cref="global::System.Exception">An error occurred while trying to commit the transaction.</exception>
        /// <exception cref="global::System.InvalidOperationException">The transaction has already been committed or rolled back or 
        /// the connection is broken.</exception>
        void Commit();

        /// <summary>
        /// Rolls back a transaction from a pending state.
        /// </summary>
        /// <exception cref="global::System.Exception">An error occurred while trying to rollback the transaction.</exception>
        /// <exception cref="global::System.InvalidOperationException">The transaction has already been committed or rolled back or 
        /// the connection is broken.</exception>
        void Rollback();

        /// <summary>
        /// Rolls back a transaction from a pending state, and specifies the transaction or savepoint name.
        /// </summary>
        /// <param name="transactionName">The name of the transaction to roll back, or the savepoint to which to roll back.</param>
        /// <exception cref="global::System.ArgumentException">No transaction name was specified.</exception>
        /// <exception cref="global::System.InvalidOperationException">The transaction has already been committed or rolled back or 
        /// the connection is broken.</exception>
        void Rollback(string transactionName);

        /// <summary>
        /// Creates a savepoint in the transaction that can be used to roll back a part of the transaction, and specifies the savepoint name.
        /// </summary>
        /// <param name="savePointName">The name of the savepoint.</param>
        /// <exception cref="global::System.Exception">An error occurred while trying to commit the transaction..</exception>
        /// <exception cref="global::System.InvalidOperationException">The transaction has already been committed or rolled back or 
        /// the connection is broken.</exception>
        void Save(string savePointName);
    }


    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Zahar.SqlClient.ISqlTransaction" />
    class SqlTransactionWrapper : ISqlTransaction
    {
        readonly global::System.Data.SqlClient.SqlTransaction m_innerTransaction;
        readonly global::System.Collections.Generic.Stack<global::System.Data.SqlClient.SqlTransaction> m_stack;

        public SqlTransactionWrapper(
            global::System.Data.SqlClient.SqlTransaction innerTransaction,
            global::System.Collections.Generic.Stack<global::System.Data.SqlClient.SqlTransaction> stack)
        {
            global::System.Diagnostics.Debug.Assert(innerTransaction != null);
            global::System.Diagnostics.Debug.Assert(stack != null);
            global::System.Diagnostics.Debug.Assert(stack.Peek() != innerTransaction);
            m_innerTransaction = innerTransaction;
            m_stack = stack;
            m_stack.Push(innerTransaction);
        }

        public global::System.Data.IsolationLevel IsolationLevel => m_innerTransaction.IsolationLevel;

        public void Commit()
        {
            try { }
            finally {
                while (m_stack.Count > 0)
                {
                    var transaction = m_stack.Pop();
                    transaction.Commit();
                    if (ReferenceEquals(m_innerTransaction, transaction))
                        break;
                }
            }            
        }

        public void Dispose()
        {
            try { }
            finally
            {
                while (m_stack.Count > 0)
                {
                    var transaction = m_stack.Pop();
                    transaction.Dispose();
                    if (ReferenceEquals(m_innerTransaction, transaction))
                        break;
                }
            }
        }

        public void Rollback()
        {
            try { }
            finally
            {
                while (m_stack.Count > 0)
                {
                    var transaction = m_stack.Pop();
                    transaction.Rollback();
                    if (ReferenceEquals(m_innerTransaction, transaction))
                        break;
                }
            }
        }

        public void Rollback(string transactionName)
        {
            try { }
            finally
            {
                while (m_stack.Count > 0)
                {
                    if (m_stack.Peek() == m_innerTransaction)
                    {
                        m_innerTransaction.Rollback(transactionName);
                        break;
                    }
                    else { m_stack.Pop().Rollback(); }                    
                }
            }
        }

        public void Save(string savePointName)
        {
            m_innerTransaction.Save(savePointName);
        }
    }


 	
}