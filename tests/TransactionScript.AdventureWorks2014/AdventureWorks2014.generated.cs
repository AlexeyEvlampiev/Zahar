namespace TransactionScript.AdventureWorks2014
{	
	/// <summary>
	/// SQL command builder factory. Use istances of this class to construct stored procedure command builder objects.
	/// </summary>
	public sealed partial class AdventureWorks2014CmdBuilderFactory : SqlCmdBuilderFactory
	{
		#region Ctor
	
		partial void OnCreated();
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="AdventureWorks2014CmdBuilderFactory"/> class.
	    /// </summary>
	    /// <param name="connectionString">SQL Server database connection string.</param>
		/// <exception cref="global::System.ArgumentNullException">connectionString</exception>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public AdventureWorks2014CmdBuilderFactory(string connectionString) : base(connectionString) { OnCreated(); }
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="AdventureWorks2014CmdBuilderFactory"/> class.
		/// Implies the SQL Server context connection.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public AdventureWorks2014CmdBuilderFactory() : base() { OnCreated(); }
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="AdventureWorks2014CmdBuilderFactory"/> class.
	    /// </summary>
	    /// <param name="connectionStringFactory">SQL Server database connection string factory.</param>
		/// <exception cref="System.ArgumentNullException">connectionStringFactory</exception>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public AdventureWorks2014CmdBuilderFactory(System.Func<string> connectionStringFactory) : base(connectionStringFactory) { OnCreated(); }
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="AdventureWorks2014CmdBuilderFactory"/> class.
	    /// </summary>
	    /// <param name="connectionFactory">SQL Server database connection string factory.</param>
	    /// <exception cref="System.ArgumentNullException">connectionFactory</exception>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public AdventureWorks2014CmdBuilderFactory(System.Func<System.Data.SqlClient.SqlConnection> connectionFactory) : base(connectionFactory) { OnCreated(); }
		#endregion  
	
		/// <summary>
	    /// Creates a new instance of the [HumanResources].[uspUpdateEmployeeHireInfo] command builder.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public HumanResourcesUspUpdateEmployeeHireInfoCmdBuilder CreateHumanResourcesUspUpdateEmployeeHireInfoCmdBuilder() { return new HumanResourcesUspUpdateEmployeeHireInfoCmdBuilder(); } 
	
		
		/// <summary>
	    /// Creates a new instance of the [HumanResources].[uspUpdateEmployeeHireInfo] command builder.
	    /// </summary> 
		/// <param name="businessEntityID">Parameter 1 (Input)</param>  
		/// <param name="jobTitle">Parameter 2 (Input)</param>  
		/// <param name="hireDate">Parameter 3 (Input)</param>  
		/// <param name="rateChangeDate">Parameter 4 (Input)</param>  
		/// <param name="rate">Parameter 5 (Input)</param>  
		/// <param name="payFrequency">Parameter 6 (Input)</param>  
		/// <param name="currentFlag">Parameter 7 (Input)</param>  
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public HumanResourcesUspUpdateEmployeeHireInfoCmdBuilder CreateHumanResourcesUspUpdateEmployeeHireInfoCmdBuilder(int? businessEntityID, string jobTitle, System.DateTime? hireDate, System.DateTime? rateChangeDate, decimal? rate, byte? payFrequency, bool? currentFlag) 
		{ 
			return new HumanResourcesUspUpdateEmployeeHireInfoCmdBuilder()
			{ 
				BusinessEntityID = businessEntityID,  
				JobTitle = jobTitle,  
				HireDate = hireDate,  
				RateChangeDate = rateChangeDate,  
				Rate = rate,  
				PayFrequency = payFrequency,  
				CurrentFlag = currentFlag,  			
			}; 
		} 
	
			
		 
	
		/// <summary>
	    /// Creates a new instance of the [HumanResources].[uspUpdateEmployeeLogin] command builder.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public HumanResourcesUspUpdateEmployeeLoginCmdBuilder CreateHumanResourcesUspUpdateEmployeeLoginCmdBuilder() { return new HumanResourcesUspUpdateEmployeeLoginCmdBuilder(); } 
	
		
		/// <summary>
	    /// Creates a new instance of the [HumanResources].[uspUpdateEmployeeLogin] command builder.
	    /// </summary> 
		/// <param name="businessEntityID">Parameter 1 (Input)</param>  
		/// <param name="organizationNode">Parameter 2 (Input)</param>  
		/// <param name="loginID">Parameter 3 (Input)</param>  
		/// <param name="jobTitle">Parameter 4 (Input)</param>  
		/// <param name="hireDate">Parameter 5 (Input)</param>  
		/// <param name="currentFlag">Parameter 6 (Input)</param>  
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public HumanResourcesUspUpdateEmployeeLoginCmdBuilder CreateHumanResourcesUspUpdateEmployeeLoginCmdBuilder(int? businessEntityID, object organizationNode, string loginID, string jobTitle, System.DateTime? hireDate, bool? currentFlag) 
		{ 
			return new HumanResourcesUspUpdateEmployeeLoginCmdBuilder()
			{ 
				BusinessEntityID = businessEntityID,  
				OrganizationNode = organizationNode,  
				LoginID = loginID,  
				JobTitle = jobTitle,  
				HireDate = hireDate,  
				CurrentFlag = currentFlag,  			
			}; 
		} 
	
			
		 
	
		/// <summary>
	    /// Creates a new instance of the [HumanResources].[uspUpdateEmployeePersonalInfo] command builder.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public HumanResourcesUspUpdateEmployeePersonalInfoCmdBuilder CreateHumanResourcesUspUpdateEmployeePersonalInfoCmdBuilder() { return new HumanResourcesUspUpdateEmployeePersonalInfoCmdBuilder(); } 
	
		
		/// <summary>
	    /// Creates a new instance of the [HumanResources].[uspUpdateEmployeePersonalInfo] command builder.
	    /// </summary> 
		/// <param name="businessEntityID">Parameter 1 (Input)</param>  
		/// <param name="nationalIDNumber">Parameter 2 (Input)</param>  
		/// <param name="birthDate">Parameter 3 (Input)</param>  
		/// <param name="maritalStatus">Parameter 4 (Input)</param>  
		/// <param name="gender">Parameter 5 (Input)</param>  
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public HumanResourcesUspUpdateEmployeePersonalInfoCmdBuilder CreateHumanResourcesUspUpdateEmployeePersonalInfoCmdBuilder(int? businessEntityID, string nationalIDNumber, System.DateTime? birthDate, string maritalStatus, string gender) 
		{ 
			return new HumanResourcesUspUpdateEmployeePersonalInfoCmdBuilder()
			{ 
				BusinessEntityID = businessEntityID,  
				NationalIDNumber = nationalIDNumber,  
				BirthDate = birthDate,  
				MaritalStatus = maritalStatus,  
				Gender = gender,  			
			}; 
		} 
	
			
		 
	
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspGetBillOfMaterials] command builder.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspGetBillOfMaterialsCmdBuilder CreateDboUspGetBillOfMaterialsCmdBuilder() { return new DboUspGetBillOfMaterialsCmdBuilder(); } 
	
		
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspGetBillOfMaterials] command builder.
	    /// </summary> 
		/// <param name="startProductID">Parameter 1 (Input)</param>  
		/// <param name="checkDate">Parameter 2 (Input)</param>  
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspGetBillOfMaterialsCmdBuilder CreateDboUspGetBillOfMaterialsCmdBuilder(int? startProductID, System.DateTime? checkDate) 
		{ 
			return new DboUspGetBillOfMaterialsCmdBuilder()
			{ 
				StartProductID = startProductID,  
				CheckDate = checkDate,  			
			}; 
		} 
	
			
		 
	
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspGetEmployeeManagers] command builder.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspGetEmployeeManagersCmdBuilder CreateDboUspGetEmployeeManagersCmdBuilder() { return new DboUspGetEmployeeManagersCmdBuilder(); } 
	
		
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspGetEmployeeManagers] command builder.
	    /// </summary> 
		/// <param name="businessEntityID">Parameter 1 (Input)</param>  
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspGetEmployeeManagersCmdBuilder CreateDboUspGetEmployeeManagersCmdBuilder(int? businessEntityID) 
		{ 
			return new DboUspGetEmployeeManagersCmdBuilder()
			{ 
				BusinessEntityID = businessEntityID,  			
			}; 
		} 
	
			
		 
	
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspGetManagerEmployees] command builder.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspGetManagerEmployeesCmdBuilder CreateDboUspGetManagerEmployeesCmdBuilder() { return new DboUspGetManagerEmployeesCmdBuilder(); } 
	
		
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspGetManagerEmployees] command builder.
	    /// </summary> 
		/// <param name="businessEntityID">Parameter 1 (Input)</param>  
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspGetManagerEmployeesCmdBuilder CreateDboUspGetManagerEmployeesCmdBuilder(int? businessEntityID) 
		{ 
			return new DboUspGetManagerEmployeesCmdBuilder()
			{ 
				BusinessEntityID = businessEntityID,  			
			}; 
		} 
	
			
		 
	
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspGetWhereUsedProductID] command builder.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspGetWhereUsedProductIDCmdBuilder CreateDboUspGetWhereUsedProductIDCmdBuilder() { return new DboUspGetWhereUsedProductIDCmdBuilder(); } 
	
		
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspGetWhereUsedProductID] command builder.
	    /// </summary> 
		/// <param name="startProductID">Parameter 1 (Input)</param>  
		/// <param name="checkDate">Parameter 2 (Input)</param>  
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspGetWhereUsedProductIDCmdBuilder CreateDboUspGetWhereUsedProductIDCmdBuilder(int? startProductID, System.DateTime? checkDate) 
		{ 
			return new DboUspGetWhereUsedProductIDCmdBuilder()
			{ 
				StartProductID = startProductID,  
				CheckDate = checkDate,  			
			}; 
		} 
	
			
		 
	
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspLogError] command builder.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspLogErrorCmdBuilder CreateDboUspLogErrorCmdBuilder() { return new DboUspLogErrorCmdBuilder(); } 
	
		
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspLogError] command builder.
	    /// </summary> 
		/// <param name="errorLogID">Parameter 1 (InputOutput)</param>  
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspLogErrorCmdBuilder CreateDboUspLogErrorCmdBuilder(int? errorLogID) 
		{ 
			return new DboUspLogErrorCmdBuilder()
			{ 
				ErrorLogID = errorLogID,  			
			}; 
		} 
	
			
		 
	
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspPrintError] command builder.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspPrintErrorCmdBuilder CreateDboUspPrintErrorCmdBuilder() { return new DboUspPrintErrorCmdBuilder(); } 
	
			
		 
	
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspSearchCandidateResumes] command builder.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspSearchCandidateResumesCmdBuilder CreateDboUspSearchCandidateResumesCmdBuilder() { return new DboUspSearchCandidateResumesCmdBuilder(); } 
	
		
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspSearchCandidateResumes] command builder.
	    /// </summary> 
		/// <param name="searchString">Parameter 1 (Input)</param>  
		/// <param name="useInflectional">Parameter 2 (Input)</param>  
		/// <param name="useThesaurus">Parameter 3 (Input)</param>  
		/// <param name="language">Parameter 4 (Input)</param>  
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspSearchCandidateResumesCmdBuilder CreateDboUspSearchCandidateResumesCmdBuilder(string searchString, bool? useInflectional, bool? useThesaurus, int? language) 
		{ 
			return new DboUspSearchCandidateResumesCmdBuilder()
			{ 
				SearchString = searchString,  
				UseInflectional = useInflectional,  
				UseThesaurus = useThesaurus,  
				Language = language,  			
			}; 
		} 
	
			
		 
	}
	 
	
	
	/// <summary>
	/// [dbo].[uspGetBillOfMaterials] typed command builder.
	/// </summary>
	public sealed partial class DboUspGetBillOfMaterialsCmdBuilder : SqlSpCmdBuilder
	{
		#region Private Fields
		 
		#endregion
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="DboUspGetBillOfMaterialsCmdBuilder"/> class ([dbo].[uspGetBillOfMaterials]). 
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspGetBillOfMaterialsCmdBuilder() : base("dbo", "uspGetBillOfMaterials", "[dbo].[uspGetBillOfMaterials]")
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
		/// Configures the given command object to execute the [dbo].[uspGetBillOfMaterials] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public override void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
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
			command.CommandText = "[dbo].[uspGetBillOfMaterials]";
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [dbo].[uspGetBillOfMaterials] command output values set. 
		/// </summary>
		/// <param name="command">[dbo].[uspGetBillOfMaterials] command</param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public ReturnValueSqlCommandOutput BuildOutputValues(global::System.Data.SqlClient.SqlCommand command)
		{			
			return new ReturnValueSqlCommandOutput(command);
		}
		 
	
		/// <summary>
		/// Creates a typed wrapper for the given reader object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspGetBillOfMaterialsSqlDataReaderAdapter BuildRecordAdapter(global::System.Data.SqlClient.SqlDataReader reader)
		{		
			return new DboUspGetBillOfMaterialsSqlDataReaderAdapter(reader);
		}
			
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
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
		/// Parameter 1 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(1,"StartProductID", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? StartProductID { get; set; }
		/// <summary>
		/// Parameter 2 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(2,"CheckDate", global::System.Data.SqlDbType.DateTime, global::System.Data.ParameterDirection.Input)]
		public System.DateTime? CheckDate { get; set; }
	
	
		#endregion
	}
	
	
	
	
	/// <summary>
	/// [dbo].[uspGetBillOfMaterials] query result[0]. 
	/// </summary>
	public partial struct DboUspGetBillOfMaterialsSqlDataReaderAdapter
	{
		/// <summary>
		/// Gets the inner <see cref="System.Data.SqlClient.SqlDataReader"/> object.
		/// </summary>
		public global::System.Data.SqlClient.SqlDataReader InnerReader { get; }
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="DboUspGetBillOfMaterialsSqlDataReaderAdapter"/> struct.
	    /// </summary>
	    /// <param name="reader">The inner <see cref="System.Data.SqlClient.SqlDataReader"/>.</param>
	    /// <exception cref="System.ArgumentNullException">reader</exception>
		public DboUspGetBillOfMaterialsSqlDataReaderAdapter(
			global::System.Data.SqlClient.SqlDataReader reader) : this()
		{
			if(ReferenceEquals(reader, null))
				throw new global::System.ArgumentNullException(nameof(reader));
			InnerReader = reader;
		}
	
		/// <summary>
		/// An asynchronous version of Read, which advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record in a result set. 
		/// This method invokes ReadAsync with CancellationToken.None.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public global::System.Threading.Tasks.Task<bool> ReadAsync() { return InnerReader.ReadAsync(global::System.Threading.CancellationToken.None); }
	
		/// <summary>
		/// An asynchronous version of Read, which advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record in a result set. 
		/// </summary>
		/// <param name="token">The cancellation instruction.</param>
		/// <returns>A task representing the asynchronous operation.</returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public global::System.Threading.Tasks.Task<bool> ReadAsync(global::System.Threading.CancellationToken token) { return InnerReader.ReadAsync(token); }
	
	
		/// <summary>
		/// Advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record.
		/// </summary>
		/// <returns>true if there are more rows; otherwise false.</returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public bool Read() { return InnerReader.Read(); }  
	
		 
		/// <summary>
		/// 
		/// </summary>
		public int? ProductAssemblyID => SqlCmdBuilder.ToClrValue<int?>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public int? ComponentID => SqlCmdBuilder.ToClrValue<int?>(InnerReader[1]);  
		/// <summary>
		/// 
		/// </summary>
		public string ComponentDesc => SqlCmdBuilder.ToClrValue<string>(InnerReader[2]);  
		/// <summary>
		/// 
		/// </summary>
		public decimal? TotalQuantity => SqlCmdBuilder.ToClrValue<decimal?>(InnerReader[3]);  
		/// <summary>
		/// 
		/// </summary>
		public decimal? StandardCost => SqlCmdBuilder.ToClrValue<decimal?>(InnerReader[4]);  
		/// <summary>
		/// 
		/// </summary>
		public decimal? ListPrice => SqlCmdBuilder.ToClrValue<decimal?>(InnerReader[5]);  
		/// <summary>
		/// 
		/// </summary>
		public short? BOMLevel => SqlCmdBuilder.ToClrValue<short?>(InnerReader[6]);  
		/// <summary>
		/// 
		/// </summary>
		public int? RecursionLevel => SqlCmdBuilder.ToClrValue<int?>(InnerReader[7]);  
	}

	 
	
	
	/// <summary>
	/// [dbo].[uspGetEmployeeManagers] typed command builder.
	/// </summary>
	public sealed partial class DboUspGetEmployeeManagersCmdBuilder : SqlSpCmdBuilder
	{
		#region Private Fields
		 
		#endregion
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="DboUspGetEmployeeManagersCmdBuilder"/> class ([dbo].[uspGetEmployeeManagers]). 
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspGetEmployeeManagersCmdBuilder() : base("dbo", "uspGetEmployeeManagers", "[dbo].[uspGetEmployeeManagers]")
		{
			OnInit();
		}
	
		#region Partial Methods
		static partial void OnInit();
		static partial void OnCommandCreated(global::System.Data.SqlClient.SqlCommand command);
		 
		static partial void OnBusinessEntityIDParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		#endregion
	
		/// <summary>
		/// Configures the given command object to execute the [dbo].[uspGetEmployeeManagers] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public override void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
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
			command.CommandText = "[dbo].[uspGetEmployeeManagers]";
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [dbo].[uspGetEmployeeManagers] command output values set. 
		/// </summary>
		/// <param name="command">[dbo].[uspGetEmployeeManagers] command</param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public ReturnValueSqlCommandOutput BuildOutputValues(global::System.Data.SqlClient.SqlCommand command)
		{			
			return new ReturnValueSqlCommandOutput(command);
		}
		 
	
		/// <summary>
		/// Creates a typed wrapper for the given reader object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspGetEmployeeManagersSqlDataReaderAdapter BuildRecordAdapter(global::System.Data.SqlClient.SqlDataReader reader)
		{		
			return new DboUspGetEmployeeManagersSqlDataReaderAdapter(reader);
		}
			
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
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
		/// Parameter 1 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(1,"BusinessEntityID", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? BusinessEntityID { get; set; }
	
	
		#endregion
	}
	
	
	
	
	/// <summary>
	/// [dbo].[uspGetEmployeeManagers] query result[0]. 
	/// </summary>
	public partial struct DboUspGetEmployeeManagersSqlDataReaderAdapter
	{
		/// <summary>
		/// Gets the inner <see cref="System.Data.SqlClient.SqlDataReader"/> object.
		/// </summary>
		public global::System.Data.SqlClient.SqlDataReader InnerReader { get; }
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="DboUspGetEmployeeManagersSqlDataReaderAdapter"/> struct.
	    /// </summary>
	    /// <param name="reader">The inner <see cref="System.Data.SqlClient.SqlDataReader"/>.</param>
	    /// <exception cref="System.ArgumentNullException">reader</exception>
		public DboUspGetEmployeeManagersSqlDataReaderAdapter(
			global::System.Data.SqlClient.SqlDataReader reader) : this()
		{
			if(ReferenceEquals(reader, null))
				throw new global::System.ArgumentNullException(nameof(reader));
			InnerReader = reader;
		}
	
		/// <summary>
		/// An asynchronous version of Read, which advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record in a result set. 
		/// This method invokes ReadAsync with CancellationToken.None.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public global::System.Threading.Tasks.Task<bool> ReadAsync() { return InnerReader.ReadAsync(global::System.Threading.CancellationToken.None); }
	
		/// <summary>
		/// An asynchronous version of Read, which advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record in a result set. 
		/// </summary>
		/// <param name="token">The cancellation instruction.</param>
		/// <returns>A task representing the asynchronous operation.</returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public global::System.Threading.Tasks.Task<bool> ReadAsync(global::System.Threading.CancellationToken token) { return InnerReader.ReadAsync(token); }
	
	
		/// <summary>
		/// Advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record.
		/// </summary>
		/// <returns>true if there are more rows; otherwise false.</returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public bool Read() { return InnerReader.Read(); }  
	
		 
		/// <summary>
		/// 
		/// </summary>
		public int? RecursionLevel => SqlCmdBuilder.ToClrValue<int?>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public int? BusinessEntityID => SqlCmdBuilder.ToClrValue<int?>(InnerReader[1]);  
		/// <summary>
		/// 
		/// </summary>
		public string FirstName => SqlCmdBuilder.ToClrValue<string>(InnerReader[2]);  
		/// <summary>
		/// 
		/// </summary>
		public string LastName => SqlCmdBuilder.ToClrValue<string>(InnerReader[3]);  
		/// <summary>
		/// 
		/// </summary>
		public string OrganizationNode => SqlCmdBuilder.ToClrValue<string>(InnerReader[4]);  
		/// <summary>
		/// 
		/// </summary>
		public string ManagerFirstName => SqlCmdBuilder.ToClrValue<string>(InnerReader[5]);  
		/// <summary>
		/// 
		/// </summary>
		public string ManagerLastName => SqlCmdBuilder.ToClrValue<string>(InnerReader[6]);  
	}

	 
	
	
	/// <summary>
	/// [dbo].[uspGetManagerEmployees] typed command builder.
	/// </summary>
	public sealed partial class DboUspGetManagerEmployeesCmdBuilder : SqlSpCmdBuilder
	{
		#region Private Fields
		 
		#endregion
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="DboUspGetManagerEmployeesCmdBuilder"/> class ([dbo].[uspGetManagerEmployees]). 
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspGetManagerEmployeesCmdBuilder() : base("dbo", "uspGetManagerEmployees", "[dbo].[uspGetManagerEmployees]")
		{
			OnInit();
		}
	
		#region Partial Methods
		static partial void OnInit();
		static partial void OnCommandCreated(global::System.Data.SqlClient.SqlCommand command);
		 
		static partial void OnBusinessEntityIDParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		#endregion
	
		/// <summary>
		/// Configures the given command object to execute the [dbo].[uspGetManagerEmployees] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public override void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
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
			command.CommandText = "[dbo].[uspGetManagerEmployees]";
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [dbo].[uspGetManagerEmployees] command output values set. 
		/// </summary>
		/// <param name="command">[dbo].[uspGetManagerEmployees] command</param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public ReturnValueSqlCommandOutput BuildOutputValues(global::System.Data.SqlClient.SqlCommand command)
		{			
			return new ReturnValueSqlCommandOutput(command);
		}
		 
	
		/// <summary>
		/// Creates a typed wrapper for the given reader object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspGetManagerEmployeesSqlDataReaderAdapter BuildRecordAdapter(global::System.Data.SqlClient.SqlDataReader reader)
		{		
			return new DboUspGetManagerEmployeesSqlDataReaderAdapter(reader);
		}
			
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
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
		/// Parameter 1 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(1,"BusinessEntityID", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? BusinessEntityID { get; set; }
	
	
		#endregion
	}
	
	
	
	
	/// <summary>
	/// [dbo].[uspGetManagerEmployees] query result[0]. 
	/// </summary>
	public partial struct DboUspGetManagerEmployeesSqlDataReaderAdapter
	{
		/// <summary>
		/// Gets the inner <see cref="System.Data.SqlClient.SqlDataReader"/> object.
		/// </summary>
		public global::System.Data.SqlClient.SqlDataReader InnerReader { get; }
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="DboUspGetManagerEmployeesSqlDataReaderAdapter"/> struct.
	    /// </summary>
	    /// <param name="reader">The inner <see cref="System.Data.SqlClient.SqlDataReader"/>.</param>
	    /// <exception cref="System.ArgumentNullException">reader</exception>
		public DboUspGetManagerEmployeesSqlDataReaderAdapter(
			global::System.Data.SqlClient.SqlDataReader reader) : this()
		{
			if(ReferenceEquals(reader, null))
				throw new global::System.ArgumentNullException(nameof(reader));
			InnerReader = reader;
		}
	
		/// <summary>
		/// An asynchronous version of Read, which advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record in a result set. 
		/// This method invokes ReadAsync with CancellationToken.None.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public global::System.Threading.Tasks.Task<bool> ReadAsync() { return InnerReader.ReadAsync(global::System.Threading.CancellationToken.None); }
	
		/// <summary>
		/// An asynchronous version of Read, which advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record in a result set. 
		/// </summary>
		/// <param name="token">The cancellation instruction.</param>
		/// <returns>A task representing the asynchronous operation.</returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public global::System.Threading.Tasks.Task<bool> ReadAsync(global::System.Threading.CancellationToken token) { return InnerReader.ReadAsync(token); }
	
	
		/// <summary>
		/// Advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record.
		/// </summary>
		/// <returns>true if there are more rows; otherwise false.</returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public bool Read() { return InnerReader.Read(); }  
	
		 
		/// <summary>
		/// 
		/// </summary>
		public int? RecursionLevel => SqlCmdBuilder.ToClrValue<int?>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public string OrganizationNode => SqlCmdBuilder.ToClrValue<string>(InnerReader[1]);  
		/// <summary>
		/// 
		/// </summary>
		public string ManagerFirstName => SqlCmdBuilder.ToClrValue<string>(InnerReader[2]);  
		/// <summary>
		/// 
		/// </summary>
		public string ManagerLastName => SqlCmdBuilder.ToClrValue<string>(InnerReader[3]);  
		/// <summary>
		/// 
		/// </summary>
		public int? BusinessEntityID => SqlCmdBuilder.ToClrValue<int?>(InnerReader[4]);  
		/// <summary>
		/// 
		/// </summary>
		public string FirstName => SqlCmdBuilder.ToClrValue<string>(InnerReader[5]);  
		/// <summary>
		/// 
		/// </summary>
		public string LastName => SqlCmdBuilder.ToClrValue<string>(InnerReader[6]);  
	}

	 
	
	
	/// <summary>
	/// [dbo].[uspGetWhereUsedProductID] typed command builder.
	/// </summary>
	public sealed partial class DboUspGetWhereUsedProductIDCmdBuilder : SqlSpCmdBuilder
	{
		#region Private Fields
		 
		#endregion
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="DboUspGetWhereUsedProductIDCmdBuilder"/> class ([dbo].[uspGetWhereUsedProductID]). 
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspGetWhereUsedProductIDCmdBuilder() : base("dbo", "uspGetWhereUsedProductID", "[dbo].[uspGetWhereUsedProductID]")
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
		/// Configures the given command object to execute the [dbo].[uspGetWhereUsedProductID] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public override void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
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
			command.CommandText = "[dbo].[uspGetWhereUsedProductID]";
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [dbo].[uspGetWhereUsedProductID] command output values set. 
		/// </summary>
		/// <param name="command">[dbo].[uspGetWhereUsedProductID] command</param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public ReturnValueSqlCommandOutput BuildOutputValues(global::System.Data.SqlClient.SqlCommand command)
		{			
			return new ReturnValueSqlCommandOutput(command);
		}
		 
	
		/// <summary>
		/// Creates a typed wrapper for the given reader object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspGetWhereUsedProductIDSqlDataReaderAdapter BuildRecordAdapter(global::System.Data.SqlClient.SqlDataReader reader)
		{		
			return new DboUspGetWhereUsedProductIDSqlDataReaderAdapter(reader);
		}
			
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
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
		/// Parameter 1 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(1,"StartProductID", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? StartProductID { get; set; }
		/// <summary>
		/// Parameter 2 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(2,"CheckDate", global::System.Data.SqlDbType.DateTime, global::System.Data.ParameterDirection.Input)]
		public System.DateTime? CheckDate { get; set; }
	
	
		#endregion
	}
	
	
	
	
	/// <summary>
	/// [dbo].[uspGetWhereUsedProductID] query result[0]. 
	/// </summary>
	public partial struct DboUspGetWhereUsedProductIDSqlDataReaderAdapter
	{
		/// <summary>
		/// Gets the inner <see cref="System.Data.SqlClient.SqlDataReader"/> object.
		/// </summary>
		public global::System.Data.SqlClient.SqlDataReader InnerReader { get; }
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="DboUspGetWhereUsedProductIDSqlDataReaderAdapter"/> struct.
	    /// </summary>
	    /// <param name="reader">The inner <see cref="System.Data.SqlClient.SqlDataReader"/>.</param>
	    /// <exception cref="System.ArgumentNullException">reader</exception>
		public DboUspGetWhereUsedProductIDSqlDataReaderAdapter(
			global::System.Data.SqlClient.SqlDataReader reader) : this()
		{
			if(ReferenceEquals(reader, null))
				throw new global::System.ArgumentNullException(nameof(reader));
			InnerReader = reader;
		}
	
		/// <summary>
		/// An asynchronous version of Read, which advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record in a result set. 
		/// This method invokes ReadAsync with CancellationToken.None.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public global::System.Threading.Tasks.Task<bool> ReadAsync() { return InnerReader.ReadAsync(global::System.Threading.CancellationToken.None); }
	
		/// <summary>
		/// An asynchronous version of Read, which advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record in a result set. 
		/// </summary>
		/// <param name="token">The cancellation instruction.</param>
		/// <returns>A task representing the asynchronous operation.</returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public global::System.Threading.Tasks.Task<bool> ReadAsync(global::System.Threading.CancellationToken token) { return InnerReader.ReadAsync(token); }
	
	
		/// <summary>
		/// Advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record.
		/// </summary>
		/// <returns>true if there are more rows; otherwise false.</returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public bool Read() { return InnerReader.Read(); }  
	
		 
		/// <summary>
		/// 
		/// </summary>
		public int? ProductAssemblyID => SqlCmdBuilder.ToClrValue<int?>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public int? ComponentID => SqlCmdBuilder.ToClrValue<int?>(InnerReader[1]);  
		/// <summary>
		/// 
		/// </summary>
		public string ComponentDesc => SqlCmdBuilder.ToClrValue<string>(InnerReader[2]);  
		/// <summary>
		/// 
		/// </summary>
		public decimal? TotalQuantity => SqlCmdBuilder.ToClrValue<decimal?>(InnerReader[3]);  
		/// <summary>
		/// 
		/// </summary>
		public decimal? StandardCost => SqlCmdBuilder.ToClrValue<decimal?>(InnerReader[4]);  
		/// <summary>
		/// 
		/// </summary>
		public decimal? ListPrice => SqlCmdBuilder.ToClrValue<decimal?>(InnerReader[5]);  
		/// <summary>
		/// 
		/// </summary>
		public short? BOMLevel => SqlCmdBuilder.ToClrValue<short?>(InnerReader[6]);  
		/// <summary>
		/// 
		/// </summary>
		public int? RecursionLevel => SqlCmdBuilder.ToClrValue<int?>(InnerReader[7]);  
	}

	 
	
	
	/// <summary>
	/// [dbo].[uspLogError] typed command builder.
	/// </summary>
	public sealed partial class DboUspLogErrorCmdBuilder : SqlSpCmdBuilder
	{
		#region Private Fields
		 
		#endregion
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="DboUspLogErrorCmdBuilder"/> class ([dbo].[uspLogError]). 
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspLogErrorCmdBuilder() : base("dbo", "uspLogError", "[dbo].[uspLogError]")
		{
			OnInit();
		}
	
		#region Partial Methods
		static partial void OnInit();
		static partial void OnCommandCreated(global::System.Data.SqlClient.SqlCommand command);
		 
		static partial void OnErrorLogIDParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		#endregion
	
		/// <summary>
		/// Configures the given command object to execute the [dbo].[uspLogError] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public override void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
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
			command.CommandText = "[dbo].[uspLogError]";
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [dbo].[uspLogError] command output values set. 
		/// </summary>
		/// <param name="command">[dbo].[uspLogError] command</param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspLogErrorOutputValueSet BuildOutputValues(global::System.Data.SqlClient.SqlCommand command)
		{			
			return new DboUspLogErrorOutputValueSet(command);
		}
			
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
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
		/// Parameter 1 (InputOutput).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(1,"ErrorLogID", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.InputOutput)]
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
		[SqlParameter(0,"RETURN_VALUE", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.ReturnValue)]
		public int? RETURN_VALUE => SqlCmdBuilder.ToClrValue<int?>(m_command.Parameters["@RETURN_VALUE"].Value);
		 
		/// <summary>
		/// 
		/// </summary>
		[SqlParameter(1,"ErrorLogID", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.InputOutput)]
		public int? ErrorLogID => SqlCmdBuilder.ToClrValue<int?>(m_command.Parameters["@ErrorLogID"].Value);
		 
	}
	
	

	 
	
	
	/// <summary>
	/// [dbo].[uspPrintError] typed command builder.
	/// </summary>
	public sealed partial class DboUspPrintErrorCmdBuilder : SqlSpCmdBuilder
	{
		#region Private Fields
		 
		#endregion
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="DboUspPrintErrorCmdBuilder"/> class ([dbo].[uspPrintError]). 
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspPrintErrorCmdBuilder() : base("dbo", "uspPrintError", "[dbo].[uspPrintError]")
		{
			OnInit();
		}
	
		#region Partial Methods
		static partial void OnInit();
		static partial void OnCommandCreated(global::System.Data.SqlClient.SqlCommand command);
		 
		#endregion
	
		/// <summary>
		/// Configures the given command object to execute the [dbo].[uspPrintError] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public override void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
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
			command.CommandText = "[dbo].[uspPrintError]";
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [dbo].[uspPrintError] command output values set. 
		/// </summary>
		/// <param name="command">[dbo].[uspPrintError] command</param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public ReturnValueSqlCommandOutput BuildOutputValues(global::System.Data.SqlClient.SqlCommand command)
		{			
			return new ReturnValueSqlCommandOutput(command);
		}
			
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
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
	/// [dbo].[uspSearchCandidateResumes] typed command builder.
	/// </summary>
	public sealed partial class DboUspSearchCandidateResumesCmdBuilder : SqlSpCmdBuilder
	{
		#region Private Fields
		 
		#endregion
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="DboUspSearchCandidateResumesCmdBuilder"/> class ([dbo].[uspSearchCandidateResumes]). 
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspSearchCandidateResumesCmdBuilder() : base("dbo", "uspSearchCandidateResumes", "[dbo].[uspSearchCandidateResumes]")
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
		/// Configures the given command object to execute the [dbo].[uspSearchCandidateResumes] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public override void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
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
			command.CommandText = "[dbo].[uspSearchCandidateResumes]";
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [dbo].[uspSearchCandidateResumes] command output values set. 
		/// </summary>
		/// <param name="command">[dbo].[uspSearchCandidateResumes] command</param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public ReturnValueSqlCommandOutput BuildOutputValues(global::System.Data.SqlClient.SqlCommand command)
		{			
			return new ReturnValueSqlCommandOutput(command);
		}
		 
	
		/// <summary>
		/// Creates a typed wrapper for the given reader object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspSearchCandidateResumesSqlDataReaderAdapter BuildRecordAdapter(global::System.Data.SqlClient.SqlDataReader reader)
		{		
			return new DboUspSearchCandidateResumesSqlDataReaderAdapter(reader);
		}
			
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
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
		/// Parameter 1 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(1,"searchString", global::System.Data.SqlDbType.NVarChar, global::System.Data.ParameterDirection.Input, 1000)]
		public string SearchString { get; set; }
		/// <summary>
		/// Parameter 2 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(2,"useInflectional", global::System.Data.SqlDbType.Bit, global::System.Data.ParameterDirection.Input)]
		public bool? UseInflectional { get; set; }
		/// <summary>
		/// Parameter 3 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(3,"useThesaurus", global::System.Data.SqlDbType.Bit, global::System.Data.ParameterDirection.Input)]
		public bool? UseThesaurus { get; set; }
		/// <summary>
		/// Parameter 4 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(4,"language", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Language { get; set; }
	
	
		#endregion
	}
	
	
	
	
	/// <summary>
	/// [dbo].[uspSearchCandidateResumes] query result[0]. 
	/// </summary>
	public partial struct DboUspSearchCandidateResumesSqlDataReaderAdapter
	{
		/// <summary>
		/// Gets the inner <see cref="System.Data.SqlClient.SqlDataReader"/> object.
		/// </summary>
		public global::System.Data.SqlClient.SqlDataReader InnerReader { get; }
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="DboUspSearchCandidateResumesSqlDataReaderAdapter"/> struct.
	    /// </summary>
	    /// <param name="reader">The inner <see cref="System.Data.SqlClient.SqlDataReader"/>.</param>
	    /// <exception cref="System.ArgumentNullException">reader</exception>
		public DboUspSearchCandidateResumesSqlDataReaderAdapter(
			global::System.Data.SqlClient.SqlDataReader reader) : this()
		{
			if(ReferenceEquals(reader, null))
				throw new global::System.ArgumentNullException(nameof(reader));
			InnerReader = reader;
		}
	
		/// <summary>
		/// An asynchronous version of Read, which advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record in a result set. 
		/// This method invokes ReadAsync with CancellationToken.None.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public global::System.Threading.Tasks.Task<bool> ReadAsync() { return InnerReader.ReadAsync(global::System.Threading.CancellationToken.None); }
	
		/// <summary>
		/// An asynchronous version of Read, which advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record in a result set. 
		/// </summary>
		/// <param name="token">The cancellation instruction.</param>
		/// <returns>A task representing the asynchronous operation.</returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public global::System.Threading.Tasks.Task<bool> ReadAsync(global::System.Threading.CancellationToken token) { return InnerReader.ReadAsync(token); }
	
	
		/// <summary>
		/// Advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record.
		/// </summary>
		/// <returns>true if there are more rows; otherwise false.</returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public bool Read() { return InnerReader.Read(); }  
	
		/// <summary>
		/// Advances the inner data reader to the next result, when reading the results of batch Transact-SQL statements.
		/// </summary>
		/// <returns>Next result <see cref="DboUspSearchCandidateResumesSqlDataReaderAdapter2"/> typed record adapter.</returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspSearchCandidateResumesSqlDataReaderAdapter2 NextResult() 
		{ 
			if(!InnerReader.NextResult())
				throw new global::System.InvalidOperationException($"[dbo].[uspSearchCandidateResumes] > InnerReader.NextResult() returned false (next result number: 1).");
			return new DboUspSearchCandidateResumesSqlDataReaderAdapter2(InnerReader); 
		}
	
		/// <summary>
		/// An asynchronous version of NextResult, which advances the inner reader to the next result when reading the results of a batch of statements.
		/// </summary>
		/// <param name="token">The cancellation instruction.</param>
		/// <returns>Next result <see cref="DboUspSearchCandidateResumesSqlDataReaderAdapter2"/> typed record adapter.</returns>
		/// <exception cref="System.InvalidOperationException"></exception>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public async global::System.Threading.Tasks.Task<DboUspSearchCandidateResumesSqlDataReaderAdapter2> NextResultAsync(global::System.Threading.CancellationToken token) 
		{ 
			if(!(await InnerReader.NextResultAsync(token)))
				throw new global::System.InvalidOperationException($"[dbo].[uspSearchCandidateResumes] > InnerReader.NextResult() returned false (next result number: 1).");
			return new DboUspSearchCandidateResumesSqlDataReaderAdapter2(InnerReader); 
		}
	
		/// <summary>
		/// An asynchronous version of NextResult, which advances the inner reader to the next result when reading the results of a batch of statements.
		/// This method invokes NextResultAsync with CancellationToken.None.
		/// </summary>
		/// <returns>Next result <see cref="DboUspSearchCandidateResumesSqlDataReaderAdapter2"/> typed record adapter.</returns>
		/// <exception cref="System.InvalidOperationException"></exception>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public global::System.Threading.Tasks.Task<DboUspSearchCandidateResumesSqlDataReaderAdapter2> NextResultAsync() { return this.NextResultAsync(global::System.Threading.CancellationToken.None); }
		 
	
		 
		/// <summary>
		/// 
		/// </summary>
		public int JobCandidateID => SqlCmdBuilder.ToClrValue<int>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public int? RANK => SqlCmdBuilder.ToClrValue<int?>(InnerReader[1]);  
	}
	/// <summary>
	/// [dbo].[uspSearchCandidateResumes] query result[1]. 
	/// </summary>
	public partial struct DboUspSearchCandidateResumesSqlDataReaderAdapter2
	{
		/// <summary>
		/// Gets the inner <see cref="System.Data.SqlClient.SqlDataReader"/> object.
		/// </summary>
		public global::System.Data.SqlClient.SqlDataReader InnerReader { get; }
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="DboUspSearchCandidateResumesSqlDataReaderAdapter2"/> struct.
	    /// </summary>
	    /// <param name="reader">The inner <see cref="System.Data.SqlClient.SqlDataReader"/>.</param>
	    /// <exception cref="System.ArgumentNullException">reader</exception>
		public DboUspSearchCandidateResumesSqlDataReaderAdapter2(
			global::System.Data.SqlClient.SqlDataReader reader) : this()
		{
			if(ReferenceEquals(reader, null))
				throw new global::System.ArgumentNullException(nameof(reader));
			InnerReader = reader;
		}
	
		/// <summary>
		/// An asynchronous version of Read, which advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record in a result set. 
		/// This method invokes ReadAsync with CancellationToken.None.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public global::System.Threading.Tasks.Task<bool> ReadAsync() { return InnerReader.ReadAsync(global::System.Threading.CancellationToken.None); }
	
		/// <summary>
		/// An asynchronous version of Read, which advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record in a result set. 
		/// </summary>
		/// <param name="token">The cancellation instruction.</param>
		/// <returns>A task representing the asynchronous operation.</returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public global::System.Threading.Tasks.Task<bool> ReadAsync(global::System.Threading.CancellationToken token) { return InnerReader.ReadAsync(token); }
	
	
		/// <summary>
		/// Advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record.
		/// </summary>
		/// <returns>true if there are more rows; otherwise false.</returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public bool Read() { return InnerReader.Read(); }  
	
		/// <summary>
		/// Advances the inner data reader to the next result, when reading the results of batch Transact-SQL statements.
		/// </summary>
		/// <returns>Next result <see cref="DboUspSearchCandidateResumesSqlDataReaderAdapter3"/> typed record adapter.</returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspSearchCandidateResumesSqlDataReaderAdapter3 NextResult() 
		{ 
			if(!InnerReader.NextResult())
				throw new global::System.InvalidOperationException($"[dbo].[uspSearchCandidateResumes] > InnerReader.NextResult() returned false (next result number: 2).");
			return new DboUspSearchCandidateResumesSqlDataReaderAdapter3(InnerReader); 
		}
	
		/// <summary>
		/// An asynchronous version of NextResult, which advances the inner reader to the next result when reading the results of a batch of statements.
		/// </summary>
		/// <param name="token">The cancellation instruction.</param>
		/// <returns>Next result <see cref="DboUspSearchCandidateResumesSqlDataReaderAdapter3"/> typed record adapter.</returns>
		/// <exception cref="System.InvalidOperationException"></exception>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public async global::System.Threading.Tasks.Task<DboUspSearchCandidateResumesSqlDataReaderAdapter3> NextResultAsync(global::System.Threading.CancellationToken token) 
		{ 
			if(!(await InnerReader.NextResultAsync(token)))
				throw new global::System.InvalidOperationException($"[dbo].[uspSearchCandidateResumes] > InnerReader.NextResult() returned false (next result number: 2).");
			return new DboUspSearchCandidateResumesSqlDataReaderAdapter3(InnerReader); 
		}
	
		/// <summary>
		/// An asynchronous version of NextResult, which advances the inner reader to the next result when reading the results of a batch of statements.
		/// This method invokes NextResultAsync with CancellationToken.None.
		/// </summary>
		/// <returns>Next result <see cref="DboUspSearchCandidateResumesSqlDataReaderAdapter3"/> typed record adapter.</returns>
		/// <exception cref="System.InvalidOperationException"></exception>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public global::System.Threading.Tasks.Task<DboUspSearchCandidateResumesSqlDataReaderAdapter3> NextResultAsync() { return this.NextResultAsync(global::System.Threading.CancellationToken.None); }
		 
	
		 
		/// <summary>
		/// 
		/// </summary>
		public int JobCandidateID => SqlCmdBuilder.ToClrValue<int>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public int? RANK => SqlCmdBuilder.ToClrValue<int?>(InnerReader[1]);  
	}
	/// <summary>
	/// [dbo].[uspSearchCandidateResumes] query result[2]. 
	/// </summary>
	public partial struct DboUspSearchCandidateResumesSqlDataReaderAdapter3
	{
		/// <summary>
		/// Gets the inner <see cref="System.Data.SqlClient.SqlDataReader"/> object.
		/// </summary>
		public global::System.Data.SqlClient.SqlDataReader InnerReader { get; }
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="DboUspSearchCandidateResumesSqlDataReaderAdapter3"/> struct.
	    /// </summary>
	    /// <param name="reader">The inner <see cref="System.Data.SqlClient.SqlDataReader"/>.</param>
	    /// <exception cref="System.ArgumentNullException">reader</exception>
		public DboUspSearchCandidateResumesSqlDataReaderAdapter3(
			global::System.Data.SqlClient.SqlDataReader reader) : this()
		{
			if(ReferenceEquals(reader, null))
				throw new global::System.ArgumentNullException(nameof(reader));
			InnerReader = reader;
		}
	
		/// <summary>
		/// An asynchronous version of Read, which advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record in a result set. 
		/// This method invokes ReadAsync with CancellationToken.None.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public global::System.Threading.Tasks.Task<bool> ReadAsync() { return InnerReader.ReadAsync(global::System.Threading.CancellationToken.None); }
	
		/// <summary>
		/// An asynchronous version of Read, which advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record in a result set. 
		/// </summary>
		/// <param name="token">The cancellation instruction.</param>
		/// <returns>A task representing the asynchronous operation.</returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public global::System.Threading.Tasks.Task<bool> ReadAsync(global::System.Threading.CancellationToken token) { return InnerReader.ReadAsync(token); }
	
	
		/// <summary>
		/// Advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record.
		/// </summary>
		/// <returns>true if there are more rows; otherwise false.</returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public bool Read() { return InnerReader.Read(); }  
	
		/// <summary>
		/// Advances the inner data reader to the next result, when reading the results of batch Transact-SQL statements.
		/// </summary>
		/// <returns>Next result <see cref="DboUspSearchCandidateResumesSqlDataReaderAdapter4"/> typed record adapter.</returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspSearchCandidateResumesSqlDataReaderAdapter4 NextResult() 
		{ 
			if(!InnerReader.NextResult())
				throw new global::System.InvalidOperationException($"[dbo].[uspSearchCandidateResumes] > InnerReader.NextResult() returned false (next result number: 3).");
			return new DboUspSearchCandidateResumesSqlDataReaderAdapter4(InnerReader); 
		}
	
		/// <summary>
		/// An asynchronous version of NextResult, which advances the inner reader to the next result when reading the results of a batch of statements.
		/// </summary>
		/// <param name="token">The cancellation instruction.</param>
		/// <returns>Next result <see cref="DboUspSearchCandidateResumesSqlDataReaderAdapter4"/> typed record adapter.</returns>
		/// <exception cref="System.InvalidOperationException"></exception>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public async global::System.Threading.Tasks.Task<DboUspSearchCandidateResumesSqlDataReaderAdapter4> NextResultAsync(global::System.Threading.CancellationToken token) 
		{ 
			if(!(await InnerReader.NextResultAsync(token)))
				throw new global::System.InvalidOperationException($"[dbo].[uspSearchCandidateResumes] > InnerReader.NextResult() returned false (next result number: 3).");
			return new DboUspSearchCandidateResumesSqlDataReaderAdapter4(InnerReader); 
		}
	
		/// <summary>
		/// An asynchronous version of NextResult, which advances the inner reader to the next result when reading the results of a batch of statements.
		/// This method invokes NextResultAsync with CancellationToken.None.
		/// </summary>
		/// <returns>Next result <see cref="DboUspSearchCandidateResumesSqlDataReaderAdapter4"/> typed record adapter.</returns>
		/// <exception cref="System.InvalidOperationException"></exception>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public global::System.Threading.Tasks.Task<DboUspSearchCandidateResumesSqlDataReaderAdapter4> NextResultAsync() { return this.NextResultAsync(global::System.Threading.CancellationToken.None); }
		 
	
		 
		/// <summary>
		/// 
		/// </summary>
		public int JobCandidateID => SqlCmdBuilder.ToClrValue<int>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public int? RANK => SqlCmdBuilder.ToClrValue<int?>(InnerReader[1]);  
	}
	/// <summary>
	/// [dbo].[uspSearchCandidateResumes] query result[3]. 
	/// </summary>
	public partial struct DboUspSearchCandidateResumesSqlDataReaderAdapter4
	{
		/// <summary>
		/// Gets the inner <see cref="System.Data.SqlClient.SqlDataReader"/> object.
		/// </summary>
		public global::System.Data.SqlClient.SqlDataReader InnerReader { get; }
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="DboUspSearchCandidateResumesSqlDataReaderAdapter4"/> struct.
	    /// </summary>
	    /// <param name="reader">The inner <see cref="System.Data.SqlClient.SqlDataReader"/>.</param>
	    /// <exception cref="System.ArgumentNullException">reader</exception>
		public DboUspSearchCandidateResumesSqlDataReaderAdapter4(
			global::System.Data.SqlClient.SqlDataReader reader) : this()
		{
			if(ReferenceEquals(reader, null))
				throw new global::System.ArgumentNullException(nameof(reader));
			InnerReader = reader;
		}
	
		/// <summary>
		/// An asynchronous version of Read, which advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record in a result set. 
		/// This method invokes ReadAsync with CancellationToken.None.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public global::System.Threading.Tasks.Task<bool> ReadAsync() { return InnerReader.ReadAsync(global::System.Threading.CancellationToken.None); }
	
		/// <summary>
		/// An asynchronous version of Read, which advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record in a result set. 
		/// </summary>
		/// <param name="token">The cancellation instruction.</param>
		/// <returns>A task representing the asynchronous operation.</returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public global::System.Threading.Tasks.Task<bool> ReadAsync(global::System.Threading.CancellationToken token) { return InnerReader.ReadAsync(token); }
	
	
		/// <summary>
		/// Advances the inner <see cref="System.Data.SqlClient.SqlDataReader"/> to the next record.
		/// </summary>
		/// <returns>true if there are more rows; otherwise false.</returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public bool Read() { return InnerReader.Read(); }  
	
		 
		/// <summary>
		/// 
		/// </summary>
		public int JobCandidateID => SqlCmdBuilder.ToClrValue<int>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public int? RANK => SqlCmdBuilder.ToClrValue<int?>(InnerReader[1]);  
	}

	 
	
	
	/// <summary>
	/// [HumanResources].[uspUpdateEmployeeHireInfo] typed command builder.
	/// </summary>
	public sealed partial class HumanResourcesUspUpdateEmployeeHireInfoCmdBuilder : SqlSpCmdBuilder
	{
		#region Private Fields
		 
		#endregion
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="HumanResourcesUspUpdateEmployeeHireInfoCmdBuilder"/> class ([HumanResources].[uspUpdateEmployeeHireInfo]). 
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public HumanResourcesUspUpdateEmployeeHireInfoCmdBuilder() : base("HumanResources", "uspUpdateEmployeeHireInfo", "[HumanResources].[uspUpdateEmployeeHireInfo]")
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
		/// Configures the given command object to execute the [HumanResources].[uspUpdateEmployeeHireInfo] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public override void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
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
			command.CommandText = "[HumanResources].[uspUpdateEmployeeHireInfo]";
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [HumanResources].[uspUpdateEmployeeHireInfo] command output values set. 
		/// </summary>
		/// <param name="command">[HumanResources].[uspUpdateEmployeeHireInfo] command</param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public ReturnValueSqlCommandOutput BuildOutputValues(global::System.Data.SqlClient.SqlCommand command)
		{			
			return new ReturnValueSqlCommandOutput(command);
		}
			
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
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
		/// Parameter 1 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(1,"BusinessEntityID", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? BusinessEntityID { get; set; }
		/// <summary>
		/// Parameter 2 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(2,"JobTitle", global::System.Data.SqlDbType.NVarChar, global::System.Data.ParameterDirection.Input, 50)]
		public string JobTitle { get; set; }
		/// <summary>
		/// Parameter 3 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(3,"HireDate", global::System.Data.SqlDbType.DateTime, global::System.Data.ParameterDirection.Input)]
		public System.DateTime? HireDate { get; set; }
		/// <summary>
		/// Parameter 4 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(4,"RateChangeDate", global::System.Data.SqlDbType.DateTime, global::System.Data.ParameterDirection.Input)]
		public System.DateTime? RateChangeDate { get; set; }
		/// <summary>
		/// Parameter 5 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(5,"Rate", global::System.Data.SqlDbType.Money, global::System.Data.ParameterDirection.Input)]
		public decimal? Rate { get; set; }
		/// <summary>
		/// Parameter 6 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(6,"PayFrequency", global::System.Data.SqlDbType.TinyInt, global::System.Data.ParameterDirection.Input)]
		public byte? PayFrequency { get; set; }
		/// <summary>
		/// Parameter 7 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(7,"CurrentFlag", global::System.Data.SqlDbType.Bit, global::System.Data.ParameterDirection.Input)]
		public bool? CurrentFlag { get; set; }
	
	
		#endregion
	}
	
	
	
	

	 
	
	
	/// <summary>
	/// [HumanResources].[uspUpdateEmployeeLogin] typed command builder.
	/// </summary>
	public sealed partial class HumanResourcesUspUpdateEmployeeLoginCmdBuilder : SqlSpCmdBuilder
	{
		#region Private Fields
		 
		#endregion
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="HumanResourcesUspUpdateEmployeeLoginCmdBuilder"/> class ([HumanResources].[uspUpdateEmployeeLogin]). 
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public HumanResourcesUspUpdateEmployeeLoginCmdBuilder() : base("HumanResources", "uspUpdateEmployeeLogin", "[HumanResources].[uspUpdateEmployeeLogin]")
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
		/// Configures the given command object to execute the [HumanResources].[uspUpdateEmployeeLogin] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public override void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
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
			command.CommandText = "[HumanResources].[uspUpdateEmployeeLogin]";
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [HumanResources].[uspUpdateEmployeeLogin] command output values set. 
		/// </summary>
		/// <param name="command">[HumanResources].[uspUpdateEmployeeLogin] command</param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public ReturnValueSqlCommandOutput BuildOutputValues(global::System.Data.SqlClient.SqlCommand command)
		{			
			return new ReturnValueSqlCommandOutput(command);
		}
			
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
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
		/// Parameter 1 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(1,"BusinessEntityID", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? BusinessEntityID { get; set; }
		/// <summary>
		/// Parameter 2 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(2,"OrganizationNode", global::System.Data.SqlDbType.Udt, global::System.Data.ParameterDirection.Input, 892)]
		public object OrganizationNode { get; set; }
		/// <summary>
		/// Parameter 3 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(3,"LoginID", global::System.Data.SqlDbType.NVarChar, global::System.Data.ParameterDirection.Input, 256)]
		public string LoginID { get; set; }
		/// <summary>
		/// Parameter 4 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(4,"JobTitle", global::System.Data.SqlDbType.NVarChar, global::System.Data.ParameterDirection.Input, 50)]
		public string JobTitle { get; set; }
		/// <summary>
		/// Parameter 5 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(5,"HireDate", global::System.Data.SqlDbType.DateTime, global::System.Data.ParameterDirection.Input)]
		public System.DateTime? HireDate { get; set; }
		/// <summary>
		/// Parameter 6 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(6,"CurrentFlag", global::System.Data.SqlDbType.Bit, global::System.Data.ParameterDirection.Input)]
		public bool? CurrentFlag { get; set; }
	
	
		#endregion
	}
	
	
	
	

	 
	
	
	/// <summary>
	/// [HumanResources].[uspUpdateEmployeePersonalInfo] typed command builder.
	/// </summary>
	public sealed partial class HumanResourcesUspUpdateEmployeePersonalInfoCmdBuilder : SqlSpCmdBuilder
	{
		#region Private Fields
		 
		#endregion
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="HumanResourcesUspUpdateEmployeePersonalInfoCmdBuilder"/> class ([HumanResources].[uspUpdateEmployeePersonalInfo]). 
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public HumanResourcesUspUpdateEmployeePersonalInfoCmdBuilder() : base("HumanResources", "uspUpdateEmployeePersonalInfo", "[HumanResources].[uspUpdateEmployeePersonalInfo]")
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
		/// Configures the given command object to execute the [HumanResources].[uspUpdateEmployeePersonalInfo] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public override void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
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
			command.CommandText = "[HumanResources].[uspUpdateEmployeePersonalInfo]";
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [HumanResources].[uspUpdateEmployeePersonalInfo] command output values set. 
		/// </summary>
		/// <param name="command">[HumanResources].[uspUpdateEmployeePersonalInfo] command</param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public ReturnValueSqlCommandOutput BuildOutputValues(global::System.Data.SqlClient.SqlCommand command)
		{			
			return new ReturnValueSqlCommandOutput(command);
		}
			
	
		/// <summary>
		/// 
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
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
		/// Parameter 1 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(1,"BusinessEntityID", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? BusinessEntityID { get; set; }
		/// <summary>
		/// Parameter 2 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(2,"NationalIDNumber", global::System.Data.SqlDbType.NVarChar, global::System.Data.ParameterDirection.Input, 15)]
		public string NationalIDNumber { get; set; }
		/// <summary>
		/// Parameter 3 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(3,"BirthDate", global::System.Data.SqlDbType.DateTime, global::System.Data.ParameterDirection.Input)]
		public System.DateTime? BirthDate { get; set; }
		/// <summary>
		/// Parameter 4 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(4,"MaritalStatus", global::System.Data.SqlDbType.NChar, global::System.Data.ParameterDirection.Input, 1)]
		public string MaritalStatus { get; set; }
		/// <summary>
		/// Parameter 5 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(5,"Gender", global::System.Data.SqlDbType.NChar, global::System.Data.ParameterDirection.Input, 1)]
		public string Gender { get; set; }
	
	
		#endregion
	}
	
	
	
	


    public abstract class SqlCmdBuilder
    {
        public abstract void BuildCommand(global::System.Data.SqlClient.SqlCommand command);

        public void BuildCommand(
            global::System.Data.SqlClient.SqlCommand command, 
            global::System.Data.SqlClient.SqlConnection connection)
        {
            if (ReferenceEquals(command, null))
                throw new global::System.ArgumentNullException(nameof(command));
            if (ReferenceEquals(connection, null))
                throw new global::System.ArgumentNullException(nameof(connection));
            this.BuildCommand(command);
            command.Connection = connection;
        }

        public void BuildCommand(
            global::System.Data.SqlClient.SqlCommand command,
            global::System.Data.SqlClient.SqlTransaction transaction)
        {
            if (ReferenceEquals(command, null))
                throw new global::System.ArgumentNullException(nameof(command));
            if (ReferenceEquals(transaction, null))
                throw new global::System.ArgumentNullException(nameof(transaction));
            this.BuildCommand(command);
            command.Connection = transaction.Connection;
            command.Transaction = transaction;
        }

        public global::System.Data.SqlClient.SqlCommand BuildCommand()
        {
            var command = new global::System.Data.SqlClient.SqlCommand();
            this.BuildCommand(command);
            return command;
        }

        public global::System.Data.SqlClient.SqlCommand BuildCommand(global::System.Data.SqlClient.SqlConnection connection)
        {
            var command = new global::System.Data.SqlClient.SqlCommand();
            this.BuildCommand(command, connection);
            return command;
        }

        public global::System.Data.SqlClient.SqlCommand BuildCommand(global::System.Data.SqlClient.SqlTransaction transaction)
        {
            var command = new global::System.Data.SqlClient.SqlCommand();
            this.BuildCommand(command, transaction);
            return command;
        }

        /// <summary>
        /// Converts the given SQL value to the corresponding CLR primitive
        /// </summary>
        /// <typeparam name="T">Target CLR primitive type</typeparam>
        /// <param name="value">SQL value.</param>
        public static T ToClrValue<T>(object value)
        {
            return (ReferenceEquals(value, null) || global::System.DBNull.Value.Equals(value))
                    ? default(T)
                    : (T)value;
        }

        /// <summary>
        /// Converts the given CLR primitive to the corresponding SQL value
        /// </summary>
        /// <typeparam name="T">CLR primitive type</typeparam>
        /// <param name="value">The SQL value.</param>
        /// <returns></returns>
        public static object ToSqlValue<T>(T value)
        {
            return value == null
                ? (object)global::System.DBNull.Value
                : value;
        }
    }


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


    /// <summary>
    /// 
    /// </summary>
    public class SqlCmdBuilderFactory
    {
        #region Private Fields

        readonly global::System.Func<global::System.Data.SqlClient.SqlConnection> m_connectionFactory;

        #endregion

        #region Ctor
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlCmdBuilderFactory"/> class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <exception cref="global::System.ArgumentNullException">connectionString</exception>
        public SqlCmdBuilderFactory(string connectionString)
        {
            if (ReferenceEquals(connectionString, null))
                throw new global::System.ArgumentNullException(nameof(connectionString));
            m_connectionFactory = () => new global::System.Data.SqlClient.SqlConnection(connectionString);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlCmdBuilderFactory"/> class.
        /// Implies SQL Server database context connection.
        /// </summary>
        public SqlCmdBuilderFactory() : this("context connection=true") { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlCmdBuilderFactory"/> class.
        /// </summary>
        /// <param name="connectionStringFactory">The connection string factory.</param>
        /// <exception cref="System.ArgumentNullException">connectionStringFactory</exception>
        public SqlCmdBuilderFactory(global::System.Func<string> connectionStringFactory)
        {
            if (ReferenceEquals(null, connectionStringFactory))
                throw new global::System.ArgumentNullException(nameof(connectionStringFactory));
            this.m_connectionFactory = () =>
            {
                var connectionString = connectionStringFactory();
                var connection = new global::System.Data.SqlClient.SqlConnection(connectionString);
                return connection;
            };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlCmdBuilderFactory"/> class.
        /// </summary>
        /// <param name="connectionFactory">The connection factory.</param>
        /// <exception cref="System.ArgumentNullException">connectionFactory</exception>
        public SqlCmdBuilderFactory(global::System.Func<global::System.Data.SqlClient.SqlConnection> connectionFactory)
        {
            if (ReferenceEquals(null, connectionFactory))
                throw new global::System.ArgumentNullException(nameof(connectionFactory));
            this.m_connectionFactory = connectionFactory;
        }
        #endregion

        public global::System.Data.SqlClient.SqlConnection CreateConnection() { return m_connectionFactory(); }
    }


    public struct ReturnValueSqlCommandOutput
    {
        readonly System.Data.SqlClient.SqlParameter m_returnValueParameter;

        /// <summary>
        /// 
        /// </summary>
        public ReturnValueSqlCommandOutput(System.Data.SqlClient.SqlCommand command)
	    {
		    if(ReferenceEquals(command, null))
			    throw new System.ArgumentNullException(nameof(command));
            for (int i = 0; i < command.Parameters.Count; ++i)
            {
                m_returnValueParameter = command.Parameters[i];
                if (m_returnValueParameter.Direction == System.Data.ParameterDirection.ReturnValue)
                    return;
            }

            throw new System.InvalidOperationException("RETURN_VALUE parameter not found.");
	    }

        /// <summary>
        /// 
        /// </summary>
        [SqlParameter(0, "RETURN_VALUE", System.Data.SqlDbType.Int, System.Data.ParameterDirection.ReturnValue)]
        public int? RETURN_VALUE => SqlCmdBuilder.ToClrValue<int?>(m_returnValueParameter.Value);
    }


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