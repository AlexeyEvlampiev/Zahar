namespace TransactionScript.UseCaseDb
{	
	/// <summary>
	/// SQL command builder factory. Use istances of this class to construct stored procedure command builder objects.
	/// </summary>
	public sealed partial class UseCaseDbCmdBuilderFactory : SqlCmdBuilderFactory
	{
		#region Ctor
	
		partial void OnCreated();
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="UseCaseDbCmdBuilderFactory"/> class.
	    /// </summary>
	    /// <param name="connectionString">SQL Server database connection string.</param>
		/// <exception cref="global::System.ArgumentNullException">connectionString</exception>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public UseCaseDbCmdBuilderFactory(string connectionString) : base(connectionString) { OnCreated(); }
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="UseCaseDbCmdBuilderFactory"/> class.
		/// Implies the SQL Server context connection.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public UseCaseDbCmdBuilderFactory() : base() { OnCreated(); }
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="UseCaseDbCmdBuilderFactory"/> class.
	    /// </summary>
	    /// <param name="connectionStringFactory">SQL Server database connection string factory.</param>
		/// <exception cref="System.ArgumentNullException">connectionStringFactory</exception>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public UseCaseDbCmdBuilderFactory(System.Func<string> connectionStringFactory) : base(connectionStringFactory) { OnCreated(); }
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="UseCaseDbCmdBuilderFactory"/> class.
	    /// </summary>
	    /// <param name="connectionFactory">SQL Server database connection string factory.</param>
	    /// <exception cref="System.ArgumentNullException">connectionFactory</exception>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public UseCaseDbCmdBuilderFactory(System.Func<System.Data.SqlClient.SqlConnection> connectionFactory) : base(connectionFactory) { OnCreated(); }
		#endregion  
	
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspDefinedWithCSharpKeywords] command builder.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspDefinedWithCSharpKeywordsCmdBuilder CreateDboUspDefinedWithCSharpKeywordsCmdBuilder() { return new DboUspDefinedWithCSharpKeywordsCmdBuilder(); } 
	
		
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspDefinedWithCSharpKeywords] command builder.
	    /// </summary> 
		/// <param name="@abstract">Parameter 1 (Input)</param>  
		/// <param name="@as">Parameter 2 (Input)</param>  
		/// <param name="@base">Parameter 3 (Input)</param>  
		/// <param name="@bool">Parameter 4 (Input)</param>  
		/// <param name="@break">Parameter 5 (Input)</param>  
		/// <param name="@byte">Parameter 6 (Input)</param>  
		/// <param name="@case">Parameter 7 (Input)</param>  
		/// <param name="@catch">Parameter 8 (Input)</param>  
		/// <param name="@char">Parameter 9 (Input)</param>  
		/// <param name="@checked">Parameter 10 (Input)</param>  
		/// <param name="@class">Parameter 11 (Input)</param>  
		/// <param name="@const">Parameter 12 (Input)</param>  
		/// <param name="@continue">Parameter 13 (Input)</param>  
		/// <param name="@decimal">Parameter 14 (Input)</param>  
		/// <param name="@default">Parameter 15 (Input)</param>  
		/// <param name="@delegate">Parameter 16 (Input)</param>  
		/// <param name="@do">Parameter 17 (Input)</param>  
		/// <param name="@double">Parameter 18 (Input)</param>  
		/// <param name="@else">Parameter 19 (Input)</param>  
		/// <param name="@enum">Parameter 20 (Input)</param>  
		/// <param name="@event">Parameter 21 (Input)</param>  
		/// <param name="@explicit">Parameter 22 (Input)</param>  
		/// <param name="@extern">Parameter 23 (Input)</param>  
		/// <param name="@false">Parameter 24 (Input)</param>  
		/// <param name="@finally">Parameter 25 (Input)</param>  
		/// <param name="@fixed">Parameter 26 (Input)</param>  
		/// <param name="@float">Parameter 27 (Input)</param>  
		/// <param name="@for">Parameter 28 (Input)</param>  
		/// <param name="@foreach">Parameter 29 (Input)</param>  
		/// <param name="@goto">Parameter 30 (Input)</param>  
		/// <param name="@if">Parameter 31 (Input)</param>  
		/// <param name="@implicit">Parameter 32 (Input)</param>  
		/// <param name="@in">Parameter 33 (Input)</param>  
		/// <param name="@int">Parameter 34 (Input)</param>  
		/// <param name="@interface">Parameter 35 (Input)</param>  
		/// <param name="@internal">Parameter 36 (Input)</param>  
		/// <param name="@is">Parameter 37 (Input)</param>  
		/// <param name="@lock">Parameter 38 (Input)</param>  
		/// <param name="@long">Parameter 39 (Input)</param>  
		/// <param name="@namespace">Parameter 40 (Input)</param>  
		/// <param name="@new">Parameter 41 (Input)</param>  
		/// <param name="@null">Parameter 42 (Input)</param>  
		/// <param name="@object">Parameter 43 (Input)</param>  
		/// <param name="@operator">Parameter 44 (Input)</param>  
		/// <param name="@out">Parameter 45 (Input)</param>  
		/// <param name="@override">Parameter 46 (Input)</param>  
		/// <param name="@params">Parameter 47 (Input)</param>  
		/// <param name="@private">Parameter 48 (Input)</param>  
		/// <param name="@protected">Parameter 49 (Input)</param>  
		/// <param name="@public">Parameter 50 (Input)</param>  
		/// <param name="@readonly">Parameter 51 (Input)</param>  
		/// <param name="@ref">Parameter 52 (Input)</param>  
		/// <param name="@return">Parameter 53 (Input)</param>  
		/// <param name="@sbyte">Parameter 54 (Input)</param>  
		/// <param name="@sealed">Parameter 55 (Input)</param>  
		/// <param name="@short">Parameter 56 (Input)</param>  
		/// <param name="@sizeof">Parameter 57 (Input)</param>  
		/// <param name="@stackalloc">Parameter 58 (Input)</param>  
		/// <param name="@static">Parameter 59 (Input)</param>  
		/// <param name="@string">Parameter 60 (Input)</param>  
		/// <param name="@struct">Parameter 61 (Input)</param>  
		/// <param name="@switch">Parameter 62 (Input)</param>  
		/// <param name="@this">Parameter 63 (Input)</param>  
		/// <param name="@throw">Parameter 64 (Input)</param>  
		/// <param name="@true">Parameter 65 (Input)</param>  
		/// <param name="@try">Parameter 66 (Input)</param>  
		/// <param name="@typeof">Parameter 67 (Input)</param>  
		/// <param name="@uint">Parameter 68 (Input)</param>  
		/// <param name="@ulong">Parameter 69 (Input)</param>  
		/// <param name="@unchecked">Parameter 70 (Input)</param>  
		/// <param name="@unsafe">Parameter 71 (Input)</param>  
		/// <param name="@ushort">Parameter 72 (Input)</param>  
		/// <param name="@using">Parameter 73 (Input)</param>  
		/// <param name="@virtual">Parameter 74 (Input)</param>  
		/// <param name="@void">Parameter 75 (Input)</param>  
		/// <param name="@volatile">Parameter 76 (Input)</param>  
		/// <param name="@while">Parameter 77 (Input)</param>  
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspDefinedWithCSharpKeywordsCmdBuilder CreateDboUspDefinedWithCSharpKeywordsCmdBuilder(int? @abstract, int? @as, int? @base, int? @bool, int? @break, int? @byte, int? @case, int? @catch, int? @char, int? @checked, int? @class, int? @const, int? @continue, int? @decimal, int? @default, int? @delegate, int? @do, int? @double, int? @else, int? @enum, int? @event, int? @explicit, int? @extern, int? @false, int? @finally, int? @fixed, int? @float, int? @for, int? @foreach, int? @goto, int? @if, int? @implicit, int? @in, int? @int, int? @interface, int? @internal, int? @is, int? @lock, int? @long, int? @namespace, int? @new, int? @null, int? @object, int? @operator, int? @out, int? @override, int? @params, int? @private, int? @protected, int? @public, int? @readonly, int? @ref, int? @return, int? @sbyte, int? @sealed, int? @short, int? @sizeof, int? @stackalloc, int? @static, int? @string, int? @struct, int? @switch, int? @this, int? @throw, int? @true, int? @try, int? @typeof, int? @uint, int? @ulong, int? @unchecked, int? @unsafe, int? @ushort, int? @using, int? @virtual, int? @void, int? @volatile, int? @while) 
		{ 
			return new DboUspDefinedWithCSharpKeywordsCmdBuilder()
			{ 
				Abstract = @abstract,  
				As = @as,  
				Base = @base,  
				Bool = @bool,  
				Break = @break,  
				Byte = @byte,  
				Case = @case,  
				Catch = @catch,  
				Char = @char,  
				Checked = @checked,  
				Class = @class,  
				Const = @const,  
				Continue = @continue,  
				Decimal = @decimal,  
				Default = @default,  
				Delegate = @delegate,  
				Do = @do,  
				Double = @double,  
				Else = @else,  
				Enum = @enum,  
				Event = @event,  
				Explicit = @explicit,  
				Extern = @extern,  
				False = @false,  
				Finally = @finally,  
				Fixed = @fixed,  
				Float = @float,  
				For = @for,  
				Foreach = @foreach,  
				Goto = @goto,  
				If = @if,  
				Implicit = @implicit,  
				In = @in,  
				Int = @int,  
				Interface = @interface,  
				Internal = @internal,  
				Is = @is,  
				Lock = @lock,  
				Long = @long,  
				Namespace = @namespace,  
				New = @new,  
				Null = @null,  
				Object = @object,  
				Operator = @operator,  
				Out = @out,  
				Override = @override,  
				Params = @params,  
				Private = @private,  
				Protected = @protected,  
				Public = @public,  
				Readonly = @readonly,  
				Ref = @ref,  
				Return = @return,  
				Sbyte = @sbyte,  
				Sealed = @sealed,  
				Short = @short,  
				Sizeof = @sizeof,  
				Stackalloc = @stackalloc,  
				Static = @static,  
				String = @string,  
				Struct = @struct,  
				Switch = @switch,  
				This = @this,  
				Throw = @throw,  
				True = @true,  
				Try = @try,  
				Typeof = @typeof,  
				Uint = @uint,  
				Ulong = @ulong,  
				Unchecked = @unchecked,  
				Unsafe = @unsafe,  
				Ushort = @ushort,  
				Using = @using,  
				Virtual = @virtual,  
				Void = @void,  
				Volatile = @volatile,  
				While = @while,  			
			}; 
		} 
	
			
		 
	
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspEcho01] command builder.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspEcho01CmdBuilder CreateDboUspEcho01CmdBuilder() { return new DboUspEcho01CmdBuilder(); } 
	
		
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspEcho01] command builder.
	    /// </summary> 
		/// <param name="firstInputParameter">Parameter 1 (Input)</param>  
		/// <param name="secondInputParameter">Parameter 2 (Input)</param>  
		/// <param name="firstTableValueParam">Parameter 3 (Input)</param>  
		/// <param name="firstOutputParameter">Parameter 4 (InputOutput)</param>  
		/// <param name="secondOutputParameter">Parameter 5 (InputOutput)</param>  
		/// <param name="secondTableValueParam">Parameter 6 (Input)</param>  
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspEcho01CmdBuilder CreateDboUspEcho01CmdBuilder(int? firstInputParameter, int? secondInputParameter, DboUdtt01UserDefinedDataTable firstTableValueParam, int? firstOutputParameter, int? secondOutputParameter, DboUdtt02UserDefinedDataTable secondTableValueParam) 
		{ 
			return new DboUspEcho01CmdBuilder()
			{ 
				FirstInputParameter = firstInputParameter,  
				SecondInputParameter = secondInputParameter,  
				FirstTableValueParam = firstTableValueParam,  
				FirstOutputParameter = firstOutputParameter,  
				SecondOutputParameter = secondOutputParameter,  
				SecondTableValueParam = secondTableValueParam,  			
			}; 
		} 
	
			
		 
	
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspSelectFromTemporaryTable2] command builder.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspSelectFromTemporaryTable2CmdBuilder CreateDboUspSelectFromTemporaryTable2CmdBuilder() { return new DboUspSelectFromTemporaryTable2CmdBuilder(); } 
	
		
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspSelectFromTemporaryTable2] command builder.
	    /// </summary> 
		/// <param name="param1">Parameter 1 (Input)</param>  
		/// <param name="param2">Parameter 2 (Input)</param>  
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspSelectFromTemporaryTable2CmdBuilder CreateDboUspSelectFromTemporaryTable2CmdBuilder(int? param1, int? param2) 
		{ 
			return new DboUspSelectFromTemporaryTable2CmdBuilder()
			{ 
				Param1 = param1,  
				Param2 = param2,  			
			}; 
		} 
	
			
		 
	
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspSelectFromTemporaryTable] command builder.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspSelectFromTemporaryTableCmdBuilder CreateDboUspSelectFromTemporaryTableCmdBuilder() { return new DboUspSelectFromTemporaryTableCmdBuilder(); } 
	
		
		/// <summary>
	    /// Creates a new instance of the [dbo].[uspSelectFromTemporaryTable] command builder.
	    /// </summary> 
		/// <param name="param1">Parameter 1 (Input)</param>  
		/// <param name="param2">Parameter 2 (Input)</param>  
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspSelectFromTemporaryTableCmdBuilder CreateDboUspSelectFromTemporaryTableCmdBuilder(int? param1, int? param2) 
		{ 
			return new DboUspSelectFromTemporaryTableCmdBuilder()
			{ 
				Param1 = param1,  
				Param2 = param2,  			
			}; 
		} 
	
			
		 
	}
	 
	
	
	/// <summary>
	/// [dbo].[uspDefinedWithCSharpKeywords] typed command builder.
	/// </summary>
	public sealed partial class DboUspDefinedWithCSharpKeywordsCmdBuilder : SqlSpCmdBuilder
	{
		#region Private Fields
		 
		#endregion
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="DboUspDefinedWithCSharpKeywordsCmdBuilder"/> class ([dbo].[uspDefinedWithCSharpKeywords]). 
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspDefinedWithCSharpKeywordsCmdBuilder() : base("dbo", "uspDefinedWithCSharpKeywords", "[dbo].[uspDefinedWithCSharpKeywords]")
		{
			OnInit();
		}
	
		#region Partial Methods
		static partial void OnInit();
		static partial void OnCommandCreated(global::System.Data.SqlClient.SqlCommand command);
		 
		static partial void OnAbstractParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnAsParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnBaseParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnBoolParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnBreakParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnByteParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnCaseParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnCatchParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnCharParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnCheckedParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnClassParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnConstParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnContinueParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnDecimalParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnDefaultParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnDelegateParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnDoParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnDoubleParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnElseParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnEnumParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnEventParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnExplicitParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnExternParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnFalseParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnFinallyParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnFixedParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnFloatParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnForParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnForeachParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnGotoParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnIfParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnImplicitParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnInParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnIntParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnInterfaceParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnInternalParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnIsParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnLockParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnLongParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnNamespaceParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnNewParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnNullParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnObjectParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnOperatorParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnOutParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnOverrideParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnParamsParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnPrivateParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnProtectedParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnPublicParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnReadonlyParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnRefParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnReturnParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnSbyteParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnSealedParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnShortParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnSizeofParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnStackallocParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnStaticParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnStringParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnStructParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnSwitchParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnThisParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnThrowParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnTrueParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnTryParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnTypeofParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnUintParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnUlongParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnUncheckedParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnUnsafeParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnUshortParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnUsingParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnVirtualParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnVoidParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnVolatileParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnWhileParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		#endregion
	
		/// <summary>
		/// Configures the given command object to execute the [dbo].[uspDefinedWithCSharpKeywords] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public override void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
		{
			if(ReferenceEquals(command, null))
				throw new global::System.ArgumentNullException(nameof(command));		
			var parameters = CreateParametersArray(); 
			parameters[1].Value = this.Abstract;  
			parameters[2].Value = this.As;  
			parameters[3].Value = this.Base;  
			parameters[4].Value = this.Bool;  
			parameters[5].Value = this.Break;  
			parameters[6].Value = this.Byte;  
			parameters[7].Value = this.Case;  
			parameters[8].Value = this.Catch;  
			parameters[9].Value = this.Char;  
			parameters[10].Value = this.Checked;  
			parameters[11].Value = this.Class;  
			parameters[12].Value = this.Const;  
			parameters[13].Value = this.Continue;  
			parameters[14].Value = this.Decimal;  
			parameters[15].Value = this.Default;  
			parameters[16].Value = this.Delegate;  
			parameters[17].Value = this.Do;  
			parameters[18].Value = this.Double;  
			parameters[19].Value = this.Else;  
			parameters[20].Value = this.Enum;  
			parameters[21].Value = this.Event;  
			parameters[22].Value = this.Explicit;  
			parameters[23].Value = this.Extern;  
			parameters[24].Value = this.False;  
			parameters[25].Value = this.Finally;  
			parameters[26].Value = this.Fixed;  
			parameters[27].Value = this.Float;  
			parameters[28].Value = this.For;  
			parameters[29].Value = this.Foreach;  
			parameters[30].Value = this.Goto;  
			parameters[31].Value = this.If;  
			parameters[32].Value = this.Implicit;  
			parameters[33].Value = this.In;  
			parameters[34].Value = this.Int;  
			parameters[35].Value = this.Interface;  
			parameters[36].Value = this.Internal;  
			parameters[37].Value = this.Is;  
			parameters[38].Value = this.Lock;  
			parameters[39].Value = this.Long;  
			parameters[40].Value = this.Namespace;  
			parameters[41].Value = this.New;  
			parameters[42].Value = this.Null;  
			parameters[43].Value = this.Object;  
			parameters[44].Value = this.Operator;  
			parameters[45].Value = this.Out;  
			parameters[46].Value = this.Override;  
			parameters[47].Value = this.Params;  
			parameters[48].Value = this.Private;  
			parameters[49].Value = this.Protected;  
			parameters[50].Value = this.Public;  
			parameters[51].Value = this.Readonly;  
			parameters[52].Value = this.Ref;  
			parameters[53].Value = this.Return;  
			parameters[54].Value = this.Sbyte;  
			parameters[55].Value = this.Sealed;  
			parameters[56].Value = this.Short;  
			parameters[57].Value = this.Sizeof;  
			parameters[58].Value = this.Stackalloc;  
			parameters[59].Value = this.Static;  
			parameters[60].Value = this.String;  
			parameters[61].Value = this.Struct;  
			parameters[62].Value = this.Switch;  
			parameters[63].Value = this.This;  
			parameters[64].Value = this.Throw;  
			parameters[65].Value = this.True;  
			parameters[66].Value = this.Try;  
			parameters[67].Value = this.Typeof;  
			parameters[68].Value = this.Uint;  
			parameters[69].Value = this.Ulong;  
			parameters[70].Value = this.Unchecked;  
			parameters[71].Value = this.Unsafe;  
			parameters[72].Value = this.Ushort;  
			parameters[73].Value = this.Using;  
			parameters[74].Value = this.Virtual;  
			parameters[75].Value = this.Void;  
			parameters[76].Value = this.Volatile;  
			parameters[77].Value = this.While;  
			for (int i = 0; i < parameters.Length; ++i)
			{
				var parameter = parameters[i];
				if (parameter.Value == null)
					parameter.Value = global::System.DBNull.Value;
			}
			command.CommandText = "[dbo].[uspDefinedWithCSharpKeywords]";
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [dbo].[uspDefinedWithCSharpKeywords] command output values set. 
		/// </summary>
		/// <param name="command">[dbo].[uspDefinedWithCSharpKeywords] command</param>
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
				new global::System.Data.SqlClient.SqlParameter("@abstract", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@as", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@base", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@bool", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@break", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@byte", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@case", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@catch", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@char", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@checked", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@class", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@const", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@continue", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@decimal", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@default", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@delegate", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@do", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@double", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@else", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@enum", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@event", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@explicit", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@extern", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@false", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@finally", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@fixed", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@float", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@for", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@foreach", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@goto", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@if", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@implicit", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@in", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@int", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@interface", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@internal", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@is", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@lock", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@long", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@namespace", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@new", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@null", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@object", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@operator", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@out", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@override", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@params", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@private", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@protected", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@public", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@readonly", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@ref", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@return", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@sbyte", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@sealed", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@short", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@sizeof", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@stackalloc", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@static", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@string", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@struct", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@switch", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@this", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@throw", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@true", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@try", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@typeof", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@uint", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@ulong", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@unchecked", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@unsafe", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@ushort", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@using", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@virtual", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@void", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@volatile", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@while", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.Input}, 
			};
	
			 
			OnAbstractParameterCreated(parameters[1]);  
			OnAsParameterCreated(parameters[2]);  
			OnBaseParameterCreated(parameters[3]);  
			OnBoolParameterCreated(parameters[4]);  
			OnBreakParameterCreated(parameters[5]);  
			OnByteParameterCreated(parameters[6]);  
			OnCaseParameterCreated(parameters[7]);  
			OnCatchParameterCreated(parameters[8]);  
			OnCharParameterCreated(parameters[9]);  
			OnCheckedParameterCreated(parameters[10]);  
			OnClassParameterCreated(parameters[11]);  
			OnConstParameterCreated(parameters[12]);  
			OnContinueParameterCreated(parameters[13]);  
			OnDecimalParameterCreated(parameters[14]);  
			OnDefaultParameterCreated(parameters[15]);  
			OnDelegateParameterCreated(parameters[16]);  
			OnDoParameterCreated(parameters[17]);  
			OnDoubleParameterCreated(parameters[18]);  
			OnElseParameterCreated(parameters[19]);  
			OnEnumParameterCreated(parameters[20]);  
			OnEventParameterCreated(parameters[21]);  
			OnExplicitParameterCreated(parameters[22]);  
			OnExternParameterCreated(parameters[23]);  
			OnFalseParameterCreated(parameters[24]);  
			OnFinallyParameterCreated(parameters[25]);  
			OnFixedParameterCreated(parameters[26]);  
			OnFloatParameterCreated(parameters[27]);  
			OnForParameterCreated(parameters[28]);  
			OnForeachParameterCreated(parameters[29]);  
			OnGotoParameterCreated(parameters[30]);  
			OnIfParameterCreated(parameters[31]);  
			OnImplicitParameterCreated(parameters[32]);  
			OnInParameterCreated(parameters[33]);  
			OnIntParameterCreated(parameters[34]);  
			OnInterfaceParameterCreated(parameters[35]);  
			OnInternalParameterCreated(parameters[36]);  
			OnIsParameterCreated(parameters[37]);  
			OnLockParameterCreated(parameters[38]);  
			OnLongParameterCreated(parameters[39]);  
			OnNamespaceParameterCreated(parameters[40]);  
			OnNewParameterCreated(parameters[41]);  
			OnNullParameterCreated(parameters[42]);  
			OnObjectParameterCreated(parameters[43]);  
			OnOperatorParameterCreated(parameters[44]);  
			OnOutParameterCreated(parameters[45]);  
			OnOverrideParameterCreated(parameters[46]);  
			OnParamsParameterCreated(parameters[47]);  
			OnPrivateParameterCreated(parameters[48]);  
			OnProtectedParameterCreated(parameters[49]);  
			OnPublicParameterCreated(parameters[50]);  
			OnReadonlyParameterCreated(parameters[51]);  
			OnRefParameterCreated(parameters[52]);  
			OnReturnParameterCreated(parameters[53]);  
			OnSbyteParameterCreated(parameters[54]);  
			OnSealedParameterCreated(parameters[55]);  
			OnShortParameterCreated(parameters[56]);  
			OnSizeofParameterCreated(parameters[57]);  
			OnStackallocParameterCreated(parameters[58]);  
			OnStaticParameterCreated(parameters[59]);  
			OnStringParameterCreated(parameters[60]);  
			OnStructParameterCreated(parameters[61]);  
			OnSwitchParameterCreated(parameters[62]);  
			OnThisParameterCreated(parameters[63]);  
			OnThrowParameterCreated(parameters[64]);  
			OnTrueParameterCreated(parameters[65]);  
			OnTryParameterCreated(parameters[66]);  
			OnTypeofParameterCreated(parameters[67]);  
			OnUintParameterCreated(parameters[68]);  
			OnUlongParameterCreated(parameters[69]);  
			OnUncheckedParameterCreated(parameters[70]);  
			OnUnsafeParameterCreated(parameters[71]);  
			OnUshortParameterCreated(parameters[72]);  
			OnUsingParameterCreated(parameters[73]);  
			OnVirtualParameterCreated(parameters[74]);  
			OnVoidParameterCreated(parameters[75]);  
			OnVolatileParameterCreated(parameters[76]);  
			OnWhileParameterCreated(parameters[77]);  
	
			return parameters;
		}
		#region Sql Parameter Properties
		/// <summary>
		/// Parameter 1 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(1,"abstract", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Abstract { get; set; }
		/// <summary>
		/// Parameter 2 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(2,"as", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? As { get; set; }
		/// <summary>
		/// Parameter 3 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(3,"base", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Base { get; set; }
		/// <summary>
		/// Parameter 4 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(4,"bool", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Bool { get; set; }
		/// <summary>
		/// Parameter 5 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(5,"break", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Break { get; set; }
		/// <summary>
		/// Parameter 6 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(6,"byte", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Byte { get; set; }
		/// <summary>
		/// Parameter 7 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(7,"case", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Case { get; set; }
		/// <summary>
		/// Parameter 8 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(8,"catch", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Catch { get; set; }
		/// <summary>
		/// Parameter 9 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(9,"char", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Char { get; set; }
		/// <summary>
		/// Parameter 10 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(10,"checked", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Checked { get; set; }
		/// <summary>
		/// Parameter 11 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(11,"class", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Class { get; set; }
		/// <summary>
		/// Parameter 12 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(12,"const", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Const { get; set; }
		/// <summary>
		/// Parameter 13 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(13,"continue", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Continue { get; set; }
		/// <summary>
		/// Parameter 14 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(14,"decimal", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Decimal { get; set; }
		/// <summary>
		/// Parameter 15 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(15,"default", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Default { get; set; }
		/// <summary>
		/// Parameter 16 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(16,"delegate", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Delegate { get; set; }
		/// <summary>
		/// Parameter 17 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(17,"do", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Do { get; set; }
		/// <summary>
		/// Parameter 18 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(18,"double", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Double { get; set; }
		/// <summary>
		/// Parameter 19 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(19,"else", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Else { get; set; }
		/// <summary>
		/// Parameter 20 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(20,"enum", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Enum { get; set; }
		/// <summary>
		/// Parameter 21 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(21,"event", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Event { get; set; }
		/// <summary>
		/// Parameter 22 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(22,"explicit", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Explicit { get; set; }
		/// <summary>
		/// Parameter 23 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(23,"extern", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Extern { get; set; }
		/// <summary>
		/// Parameter 24 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(24,"false", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? False { get; set; }
		/// <summary>
		/// Parameter 25 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(25,"finally", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Finally { get; set; }
		/// <summary>
		/// Parameter 26 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(26,"fixed", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Fixed { get; set; }
		/// <summary>
		/// Parameter 27 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(27,"float", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Float { get; set; }
		/// <summary>
		/// Parameter 28 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(28,"for", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? For { get; set; }
		/// <summary>
		/// Parameter 29 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(29,"foreach", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Foreach { get; set; }
		/// <summary>
		/// Parameter 30 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(30,"goto", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Goto { get; set; }
		/// <summary>
		/// Parameter 31 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(31,"if", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? If { get; set; }
		/// <summary>
		/// Parameter 32 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(32,"implicit", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Implicit { get; set; }
		/// <summary>
		/// Parameter 33 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(33,"in", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? In { get; set; }
		/// <summary>
		/// Parameter 34 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(34,"int", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Int { get; set; }
		/// <summary>
		/// Parameter 35 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(35,"interface", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Interface { get; set; }
		/// <summary>
		/// Parameter 36 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(36,"internal", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Internal { get; set; }
		/// <summary>
		/// Parameter 37 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(37,"is", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Is { get; set; }
		/// <summary>
		/// Parameter 38 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(38,"lock", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Lock { get; set; }
		/// <summary>
		/// Parameter 39 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(39,"long", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Long { get; set; }
		/// <summary>
		/// Parameter 40 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(40,"namespace", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Namespace { get; set; }
		/// <summary>
		/// Parameter 41 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(41,"new", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? New { get; set; }
		/// <summary>
		/// Parameter 42 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(42,"null", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Null { get; set; }
		/// <summary>
		/// Parameter 43 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(43,"object", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Object { get; set; }
		/// <summary>
		/// Parameter 44 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(44,"operator", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Operator { get; set; }
		/// <summary>
		/// Parameter 45 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(45,"out", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Out { get; set; }
		/// <summary>
		/// Parameter 46 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(46,"override", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Override { get; set; }
		/// <summary>
		/// Parameter 47 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(47,"params", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Params { get; set; }
		/// <summary>
		/// Parameter 48 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(48,"private", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Private { get; set; }
		/// <summary>
		/// Parameter 49 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(49,"protected", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Protected { get; set; }
		/// <summary>
		/// Parameter 50 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(50,"public", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Public { get; set; }
		/// <summary>
		/// Parameter 51 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(51,"readonly", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Readonly { get; set; }
		/// <summary>
		/// Parameter 52 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(52,"ref", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Ref { get; set; }
		/// <summary>
		/// Parameter 53 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(53,"return", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Return { get; set; }
		/// <summary>
		/// Parameter 54 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(54,"sbyte", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Sbyte { get; set; }
		/// <summary>
		/// Parameter 55 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(55,"sealed", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Sealed { get; set; }
		/// <summary>
		/// Parameter 56 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(56,"short", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Short { get; set; }
		/// <summary>
		/// Parameter 57 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(57,"sizeof", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Sizeof { get; set; }
		/// <summary>
		/// Parameter 58 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(58,"stackalloc", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Stackalloc { get; set; }
		/// <summary>
		/// Parameter 59 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(59,"static", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Static { get; set; }
		/// <summary>
		/// Parameter 60 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(60,"string", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? String { get; set; }
		/// <summary>
		/// Parameter 61 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(61,"struct", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Struct { get; set; }
		/// <summary>
		/// Parameter 62 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(62,"switch", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Switch { get; set; }
		/// <summary>
		/// Parameter 63 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(63,"this", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? This { get; set; }
		/// <summary>
		/// Parameter 64 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(64,"throw", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Throw { get; set; }
		/// <summary>
		/// Parameter 65 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(65,"true", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? True { get; set; }
		/// <summary>
		/// Parameter 66 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(66,"try", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Try { get; set; }
		/// <summary>
		/// Parameter 67 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(67,"typeof", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Typeof { get; set; }
		/// <summary>
		/// Parameter 68 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(68,"uint", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Uint { get; set; }
		/// <summary>
		/// Parameter 69 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(69,"ulong", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Ulong { get; set; }
		/// <summary>
		/// Parameter 70 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(70,"unchecked", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Unchecked { get; set; }
		/// <summary>
		/// Parameter 71 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(71,"unsafe", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Unsafe { get; set; }
		/// <summary>
		/// Parameter 72 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(72,"ushort", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Ushort { get; set; }
		/// <summary>
		/// Parameter 73 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(73,"using", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Using { get; set; }
		/// <summary>
		/// Parameter 74 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(74,"virtual", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Virtual { get; set; }
		/// <summary>
		/// Parameter 75 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(75,"void", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Void { get; set; }
		/// <summary>
		/// Parameter 76 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(76,"volatile", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Volatile { get; set; }
		/// <summary>
		/// Parameter 77 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(77,"while", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? While { get; set; }
	
	
		#endregion
	}
	
	
	
	

	 
	
	
	/// <summary>
	/// [dbo].[uspEcho01] typed command builder.
	/// </summary>
	public sealed partial class DboUspEcho01CmdBuilder : SqlSpCmdBuilder
	{
		#region Private Fields
		 
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		private DboUdtt01UserDefinedDataTable m_firstTableValueParam;  
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		private DboUdtt02UserDefinedDataTable m_secondTableValueParam;  
		#endregion
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="DboUspEcho01CmdBuilder"/> class ([dbo].[uspEcho01]). 
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspEcho01CmdBuilder() : base("dbo", "uspEcho01", "[dbo].[uspEcho01]")
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
		/// Configures the given command object to execute the [dbo].[uspEcho01] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public override void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
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
			command.CommandText = "[dbo].[uspEcho01]";
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [dbo].[uspEcho01] command output values set. 
		/// </summary>
		/// <param name="command">[dbo].[uspEcho01] command</param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspEcho01OutputValueSet BuildOutputValues(global::System.Data.SqlClient.SqlCommand command)
		{			
			return new DboUspEcho01OutputValueSet(command);
		}
		 
	
		/// <summary>
		/// Creates a typed wrapper for the given reader object.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspEcho01SqlDataReaderAdapter BuildRecordAdapter(global::System.Data.SqlClient.SqlDataReader reader)
		{		
			return new DboUspEcho01SqlDataReaderAdapter(reader);
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
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(1,"FirstInputParameter", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? FirstInputParameter { get; set; }
		/// <summary>
		/// Parameter 2 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(2,"SecondInputParameter", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? SecondInputParameter { get; set; }
		/// <summary>
		/// Parameter 4 (InputOutput).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(4,"FirstOutputParameter", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.InputOutput)]
		public int? FirstOutputParameter { get; set; }
		/// <summary>
		/// Parameter 5 (InputOutput).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(5,"SecondOutputParameter", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.InputOutput)]
		public int? SecondOutputParameter { get; set; }
	
	
		/// <summary>
		/// Parameter 3 (User defined table type: [dbo].[Udtt01])
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(3,"FirstTableValueParam", global::System.Data.SqlDbType.Structured, global::System.Data.ParameterDirection.Input)]
		public DboUdtt01UserDefinedDataTable FirstTableValueParam
		{
			get { return this.m_firstTableValueParam ?? (this.m_firstTableValueParam = new DboUdtt01UserDefinedDataTable()); }
			set { this.m_firstTableValueParam = value; }
		}
		/// <summary>
		/// Parameter 6 (User defined table type: [dbo].[Udtt02])
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
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
		public int? RETURN_VALUE => SqlCmdBuilder.ToClrValue<int?>(m_command.Parameters["@RETURN_VALUE"].Value);
		 
		/// <summary>
		/// 
		/// </summary>
		[SqlParameter(4,"FirstOutputParameter", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.InputOutput)]
		public int? FirstOutputParameter => SqlCmdBuilder.ToClrValue<int?>(m_command.Parameters["@FirstOutputParameter"].Value);
		 
		/// <summary>
		/// 
		/// </summary>
		[SqlParameter(5,"SecondOutputParameter", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.InputOutput)]
		public int? SecondOutputParameter => SqlCmdBuilder.ToClrValue<int?>(m_command.Parameters["@SecondOutputParameter"].Value);
		 
	}
	
	
	/// <summary>
	/// [dbo].[uspEcho01] query result[0]. 
	/// </summary>
	public partial struct DboUspEcho01SqlDataReaderAdapter
	{
		/// <summary>
		/// Gets the inner <see cref="System.Data.SqlClient.SqlDataReader"/> object.
		/// </summary>
		public global::System.Data.SqlClient.SqlDataReader InnerReader { get; }
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="DboUspEcho01SqlDataReaderAdapter"/> struct.
	    /// </summary>
	    /// <param name="reader">The inner <see cref="System.Data.SqlClient.SqlDataReader"/>.</param>
	    /// <exception cref="System.ArgumentNullException">reader</exception>
		public DboUspEcho01SqlDataReaderAdapter(
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
		/// <returns>Next result <see cref="DboUspEcho01SqlDataReaderAdapter2"/> typed record adapter.</returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspEcho01SqlDataReaderAdapter2 NextResult() 
		{ 
			if(!InnerReader.NextResult())
				throw new global::System.InvalidOperationException($"[dbo].[uspEcho01] > InnerReader.NextResult() returned false (next result number: 1).");
			return new DboUspEcho01SqlDataReaderAdapter2(InnerReader); 
		}
	
		/// <summary>
		/// An asynchronous version of NextResult, which advances the inner reader to the next result when reading the results of a batch of statements.
		/// </summary>
		/// <param name="token">The cancellation instruction.</param>
		/// <returns>Next result <see cref="DboUspEcho01SqlDataReaderAdapter2"/> typed record adapter.</returns>
		/// <exception cref="System.InvalidOperationException"></exception>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public async global::System.Threading.Tasks.Task<DboUspEcho01SqlDataReaderAdapter2> NextResultAsync(global::System.Threading.CancellationToken token) 
		{ 
			if(!(await InnerReader.NextResultAsync(token)))
				throw new global::System.InvalidOperationException($"[dbo].[uspEcho01] > InnerReader.NextResult() returned false (next result number: 1).");
			return new DboUspEcho01SqlDataReaderAdapter2(InnerReader); 
		}
	
		/// <summary>
		/// An asynchronous version of NextResult, which advances the inner reader to the next result when reading the results of a batch of statements.
		/// This method invokes NextResultAsync with CancellationToken.None.
		/// </summary>
		/// <returns>Next result <see cref="DboUspEcho01SqlDataReaderAdapter2"/> typed record adapter.</returns>
		/// <exception cref="System.InvalidOperationException"></exception>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public global::System.Threading.Tasks.Task<DboUspEcho01SqlDataReaderAdapter2> NextResultAsync() { return this.NextResultAsync(global::System.Threading.CancellationToken.None); }
		 
	
		 
		/// <summary>
		/// 
		/// </summary>
		public int? Field1 => SqlCmdBuilder.ToClrValue<int?>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public int? Field2 => SqlCmdBuilder.ToClrValue<int?>(InnerReader[1]);  
	}
	/// <summary>
	/// [dbo].[uspEcho01] query result[1]. 
	/// </summary>
	public partial struct DboUspEcho01SqlDataReaderAdapter2
	{
		/// <summary>
		/// Gets the inner <see cref="System.Data.SqlClient.SqlDataReader"/> object.
		/// </summary>
		public global::System.Data.SqlClient.SqlDataReader InnerReader { get; }
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="DboUspEcho01SqlDataReaderAdapter2"/> struct.
	    /// </summary>
	    /// <param name="reader">The inner <see cref="System.Data.SqlClient.SqlDataReader"/>.</param>
	    /// <exception cref="System.ArgumentNullException">reader</exception>
		public DboUspEcho01SqlDataReaderAdapter2(
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
		/// <returns>Next result <see cref="DboUspEcho01SqlDataReaderAdapter3"/> typed record adapter.</returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspEcho01SqlDataReaderAdapter3 NextResult() 
		{ 
			if(!InnerReader.NextResult())
				throw new global::System.InvalidOperationException($"[dbo].[uspEcho01] > InnerReader.NextResult() returned false (next result number: 2).");
			return new DboUspEcho01SqlDataReaderAdapter3(InnerReader); 
		}
	
		/// <summary>
		/// An asynchronous version of NextResult, which advances the inner reader to the next result when reading the results of a batch of statements.
		/// </summary>
		/// <param name="token">The cancellation instruction.</param>
		/// <returns>Next result <see cref="DboUspEcho01SqlDataReaderAdapter3"/> typed record adapter.</returns>
		/// <exception cref="System.InvalidOperationException"></exception>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public async global::System.Threading.Tasks.Task<DboUspEcho01SqlDataReaderAdapter3> NextResultAsync(global::System.Threading.CancellationToken token) 
		{ 
			if(!(await InnerReader.NextResultAsync(token)))
				throw new global::System.InvalidOperationException($"[dbo].[uspEcho01] > InnerReader.NextResult() returned false (next result number: 2).");
			return new DboUspEcho01SqlDataReaderAdapter3(InnerReader); 
		}
	
		/// <summary>
		/// An asynchronous version of NextResult, which advances the inner reader to the next result when reading the results of a batch of statements.
		/// This method invokes NextResultAsync with CancellationToken.None.
		/// </summary>
		/// <returns>Next result <see cref="DboUspEcho01SqlDataReaderAdapter3"/> typed record adapter.</returns>
		/// <exception cref="System.InvalidOperationException"></exception>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public global::System.Threading.Tasks.Task<DboUspEcho01SqlDataReaderAdapter3> NextResultAsync() { return this.NextResultAsync(global::System.Threading.CancellationToken.None); }
		 
	
		 
		/// <summary>
		/// 
		/// </summary>
		public int Id => SqlCmdBuilder.ToClrValue<int>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public string Name => SqlCmdBuilder.ToClrValue<string>(InnerReader[1]);  
		/// <summary>
		/// 
		/// </summary>
		public System.DateTime? Date => SqlCmdBuilder.ToClrValue<System.DateTime?>(InnerReader[2]);  
	}
	/// <summary>
	/// [dbo].[uspEcho01] query result[2]. 
	/// </summary>
	public partial struct DboUspEcho01SqlDataReaderAdapter3
	{
		/// <summary>
		/// Gets the inner <see cref="System.Data.SqlClient.SqlDataReader"/> object.
		/// </summary>
		public global::System.Data.SqlClient.SqlDataReader InnerReader { get; }
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="DboUspEcho01SqlDataReaderAdapter3"/> struct.
	    /// </summary>
	    /// <param name="reader">The inner <see cref="System.Data.SqlClient.SqlDataReader"/>.</param>
	    /// <exception cref="System.ArgumentNullException">reader</exception>
		public DboUspEcho01SqlDataReaderAdapter3(
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
		public int? Id => SqlCmdBuilder.ToClrValue<int?>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public string Name => SqlCmdBuilder.ToClrValue<string>(InnerReader[1]);  
	}

	 
	
	
	/// <summary>
	/// [dbo].[uspSelectFromTemporaryTable] typed command builder.
	/// </summary>
	public sealed partial class DboUspSelectFromTemporaryTableCmdBuilder : SqlSpCmdBuilder
	{
		#region Private Fields
		 
		#endregion
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="DboUspSelectFromTemporaryTableCmdBuilder"/> class ([dbo].[uspSelectFromTemporaryTable]). 
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspSelectFromTemporaryTableCmdBuilder() : base("dbo", "uspSelectFromTemporaryTable", "[dbo].[uspSelectFromTemporaryTable]")
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
		/// Configures the given command object to execute the [dbo].[uspSelectFromTemporaryTable] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public override void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
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
			command.CommandText = "[dbo].[uspSelectFromTemporaryTable]";
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [dbo].[uspSelectFromTemporaryTable] command output values set. 
		/// </summary>
		/// <param name="command">[dbo].[uspSelectFromTemporaryTable] command</param>
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
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(1,"param1", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Param1 { get; set; }
		/// <summary>
		/// Parameter 2 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(2,"param2", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Param2 { get; set; }
	
	
		#endregion
	}
	
	
	
	

	 
	
	
	/// <summary>
	/// [dbo].[uspSelectFromTemporaryTable2] typed command builder.
	/// </summary>
	public sealed partial class DboUspSelectFromTemporaryTable2CmdBuilder : SqlSpCmdBuilder
	{
		#region Private Fields
		 
		#endregion
	
		/// <summary>
	    /// Initializes a new instance of the <see cref="DboUspSelectFromTemporaryTable2CmdBuilder"/> class ([dbo].[uspSelectFromTemporaryTable2]). 
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUspSelectFromTemporaryTable2CmdBuilder() : base("dbo", "uspSelectFromTemporaryTable2", "[dbo].[uspSelectFromTemporaryTable2]")
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
		/// Configures the given command object to execute the [dbo].[uspSelectFromTemporaryTable2] -procedure.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public override void BuildCommand(global::System.Data.SqlClient.SqlCommand command)
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
			command.CommandText = "[dbo].[uspSelectFromTemporaryTable2]";
			command.CommandType = global::System.Data.CommandType.StoredProcedure;		
			command.Parameters.Clear();
			command.Parameters.AddRange(parameters);
			OnCommandCreated(command);
		}
	
		/// <summary>
		/// Creates new [dbo].[uspSelectFromTemporaryTable2] command output values set. 
		/// </summary>
		/// <param name="command">[dbo].[uspSelectFromTemporaryTable2] command</param>
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
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		[SqlParameter(1,"param1", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.Input)]
		public int? Param1 { get; set; }
		/// <summary>
		/// Parameter 2 (Input).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
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
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUdtt01UserDefinedDataTable()
		{
			this.TableName = @"[dbo].[Udtt01]";
			this.BeginInit();
			this.InitClass();
			this.EndInit();
		}
	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		protected DboUdtt01UserDefinedDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
				base(info, context) 
		{
			
		}
	
		public void AddRows<T>(
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
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public new DboUdtt01UserDefinedDataTableRow NewRow() { return ((DboUdtt01UserDefinedDataTableRow)(base.NewRow())); }
				
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) { return new DboUdtt01UserDefinedDataTableRow(builder); }
				
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
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
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		internal DboUdtt01UserDefinedDataTableRow(global::System.Data.DataRowBuilder rb) : base(rb) 
		{
		}
	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public new DboUdtt01UserDefinedDataTable Table => (DboUdtt01UserDefinedDataTable)base.Table;
	
		 
		/// <summary>
	    /// Gets or sets the "Id" value.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")] 
		[global::System.ComponentModel.DataAnnotations.Key()]  
		[global::System.ComponentModel.DataAnnotations.Schema.Column("Id", Order = 0)]
		public int Id
		{
			get { return SqlCmdBuilder.ToClrValue<int>(this[0]); }
			set { this[0] = SqlCmdBuilder.ToSqlValue(value); }
		}
		 
		/// <summary>
	    /// Gets or sets the "Name" value.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")] 
		[global::System.ComponentModel.DataAnnotations.Schema.Column("Name", Order = 1)]
		public string Name
		{
			get { return SqlCmdBuilder.ToClrValue<string>(this[1]); }
			set { this[1] = SqlCmdBuilder.ToSqlValue(value); }
		}
		 
		/// <summary>
	    /// Gets or sets the "Date" value.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")] 
		[global::System.ComponentModel.DataAnnotations.Schema.Column("Date", Order = 2)]
		public System.DateTime? Date
		{
			get { return SqlCmdBuilder.ToClrValue<System.DateTime?>(this[2]); }
			set { this[2] = SqlCmdBuilder.ToSqlValue(value); }
		}
		 
	}

	
	/// <summary>
	/// [dbo].[Udtt02] user defined tabletype.
	/// </summary>	
	[global::System.Serializable()]
	public partial class DboUdtt02UserDefinedDataTable : global::System.Data.TypedTableBase<DboUdtt02UserDefinedDataTableRow>
	{
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public DboUdtt02UserDefinedDataTable()
		{
			this.TableName = @"[dbo].[Udtt02]";
			this.BeginInit();
			this.InitClass();
			this.EndInit();
		}
	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		protected DboUdtt02UserDefinedDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
				base(info, context) 
		{
			
		}
	
		public void AddRows<T>(
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
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public new DboUdtt02UserDefinedDataTableRow NewRow() { return ((DboUdtt02UserDefinedDataTableRow)(base.NewRow())); }
				
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) { return new DboUdtt02UserDefinedDataTableRow(builder); }
				
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
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
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		internal DboUdtt02UserDefinedDataTableRow(global::System.Data.DataRowBuilder rb) : base(rb) 
		{
		}
	
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")]
		public new DboUdtt02UserDefinedDataTable Table => (DboUdtt02UserDefinedDataTable)base.Table;
	
		 
		/// <summary>
	    /// Gets or sets the "Id" value.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")] 
		[global::System.ComponentModel.DataAnnotations.Schema.Column("Id", Order = 0)]
		public int? Id
		{
			get { return SqlCmdBuilder.ToClrValue<int?>(this[0]); }
			set { this[0] = SqlCmdBuilder.ToSqlValue(value); }
		}
		 
		/// <summary>
	    /// Gets or sets the "Name" value.
	    /// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.4.30937")] 
		[global::System.ComponentModel.DataAnnotations.Schema.Column("Name", Order = 1)]
		public string Name
		{
			get { return SqlCmdBuilder.ToClrValue<string>(this[1]); }
			set { this[1] = SqlCmdBuilder.ToSqlValue(value); }
		}
		 
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