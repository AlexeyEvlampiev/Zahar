namespace Zahar
{	 
	
	
	/// <summary>
	/// [dbo].[uspEcho01] typed component factory.
	/// </summary>
	public partial class DboUspEcho01ComponentFactory
	{
		public const string ProcedureName = "[dbo].[uspEcho01]";
	
		#region Private Fields
		 
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		private DboUdtt01UserDefinedDataTable m_udtt01;  
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
		 
		static partial void OnParam1ParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnParam2ParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnUdtt01ParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnOutput1ParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
		static partial void OnOutput2ParameterCreated(global::System.Data.SqlClient.SqlParameter parameter);  
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
			parameters[1].Value = this.Param1;  
			parameters[2].Value = this.Param2;  
			parameters[3].Value = this.Udtt01;  
			parameters[4].Value = this.Output1;  
			parameters[5].Value = this.Output2;  
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
		public static global::System.Data.SqlClient.SqlCommand CreateCommand(int? param1, int? param2, DboUdtt01UserDefinedDataTable udtt01, int? output1, int? output2)
		{
			var builder = new DboUspEcho01ComponentFactory()		
			{ 
				Param1 = param1,  
				Param2 = param2,  
				Udtt01 = udtt01,  
				Output1 = output1,  
				Output2 = output2,  
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
				new global::System.Data.SqlClient.SqlParameter("@udtt01", global::System.Data.SqlDbType.Structured){ Direction = global::System.Data.ParameterDirection.Input}, 
				new global::System.Data.SqlClient.SqlParameter("@output1", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.InputOutput}, 
				new global::System.Data.SqlClient.SqlParameter("@output2", global::System.Data.SqlDbType.Int){ Direction = global::System.Data.ParameterDirection.InputOutput}, 
			};
	
			 
			OnParam1ParameterCreated(parameters[1]);  
			OnParam2ParameterCreated(parameters[2]);  
			OnUdtt01ParameterCreated(parameters[3]);  
			OnOutput1ParameterCreated(parameters[4]);  
			OnOutput2ParameterCreated(parameters[5]);  
	
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
		/// <summary>
		/// Parameter 4 (InputOutput).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		[SqlParameter(4,"output1", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.InputOutput)]
		public int? Output1 { get; set; }
		/// <summary>
		/// Parameter 5 (InputOutput).
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		[SqlParameter(5,"output2", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.InputOutput)]
		public int? Output2 { get; set; }
	
	
		/// <summary>
		/// Parameter 3
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Zahar", "1.0.0.0")]
		[SqlParameter(3,"udtt01", global::System.Data.SqlDbType.Structured, global::System.Data.ParameterDirection.Input)]
		public DboUdtt01UserDefinedDataTable Udtt01
		{
			get { return this.m_udtt01 ?? (this.m_udtt01 = new DboUdtt01UserDefinedDataTable()); }
			set { this.m_udtt01 = value; }
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
			global::System.Diagnostics.Debug.Assert(command.Parameters.Contains("@output1"));  
			global::System.Diagnostics.Debug.Assert(command.Parameters.Contains("@output2")); 	
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
		[SqlParameter(4,"output1", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.InputOutput)]
		public int? Output1 => SqlDbClient.ToClrValue<int?>(m_command.Parameters["@output1"].Value);
		 
		/// <summary>
		/// 
		/// </summary>
		[SqlParameter(5,"output2", global::System.Data.SqlDbType.Int, global::System.Data.ParameterDirection.InputOutput)]
		public int? Output2 => SqlDbClient.ToClrValue<int?>(m_command.Parameters["@output2"].Value);
		 
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
		public int? Param1 => SqlDbClient.ToClrValue<int?>(InnerReader[0]);  
		/// <summary>
		/// 
		/// </summary>
		public int? Param2 => SqlDbClient.ToClrValue<int?>(InnerReader[1]);  
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
            if ((Connection.State | global::System.Data.ConnectionState.Closed) != global::System.Data.ConnectionState.Closed)
                return false;
            Connection.Close();
            return true;
        }

        public global::System.IDisposable OpenSession()
        {
            if ((Connection.State | global::System.Data.ConnectionState.Closed) == global::System.Data.ConnectionState.Closed)
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
            commandBehavior = commandBehavior & ~global::System.Data.CommandBehavior.CloseConnection;
            StatementCompletedHandler manager = null;
            global::System.IDisposable session = null;
            var initialState = new SqlCommandState(command);
            try
            {
                session = OpenSession();
                manager = new StatementCompletedHandler(command, session, initialState);
                command.Connection = Connection;
                //if (m_transactions.Count > 0)
                //    command.Transaction = m_transactions.Peek();
                return command.ExecuteReader(commandBehavior);
            }
            catch
            {
                session?.Dispose();
                manager?.Dispose();
                initialState.ApplyTo(command);
                throw;
            }
        }

        public async global::System.Threading.Tasks.Task<global::System.Data.SqlClient.SqlDataReader> ExecuteReaderAsync(
            global::System.Data.SqlClient.SqlCommand command,
            global::System.Threading.CancellationToken token, 
            global::System.Data.CommandBehavior commandBehavior = global::System.Data.CommandBehavior.Default)
        {
            commandBehavior = commandBehavior & ~global::System.Data.CommandBehavior.CloseConnection;
            StatementCompletedHandler handler = null;
            global::System.IDisposable session = null;
            var initialState = new SqlCommandState(command);
            try
            {
                session = await OpenSessionAsync(token);
                handler = new StatementCompletedHandler(command, session, initialState);
                command.Connection = Connection;
                //if (m_transactions.Count > 0)
                //    command.Transaction = m_transactions.Peek();
                return await command.ExecuteReaderAsync(commandBehavior);
            }
            catch
            {
                session?.Dispose();
                handler?.Dispose();
                initialState.ApplyTo(command);
                throw;
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


 	
}