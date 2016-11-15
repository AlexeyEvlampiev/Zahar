namespace Zahar.SqlClient
{
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
        public int? RETURN_VALUE => SqlDbClient.ToClrValue<int?>(m_returnValueParameter.Value);
    }
}
