namespace Zahar.SqlClient
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;

    public struct SqlCommandReturnValue
    {
        readonly SqlParameter m_returnValueParameter;

        /// <summary>
        /// 
        /// </summary>
        public SqlCommandReturnValue(SqlCommand command)
	    {
		    if(ReferenceEquals(command, null))
			    throw new ArgumentNullException(nameof(command));
            for (int i = 0; i < command.Parameters.Count; ++i)
            {
                m_returnValueParameter = command.Parameters[i];
                if (m_returnValueParameter.Direction == ParameterDirection.ReturnValue)
                    return;
            }

            throw new InvalidOperationException("RETURN_VALUE parameter not found.");
	    }

        /// <summary>
        /// 
        /// </summary>
        public int? RETURN_VALUE => SqlDbClient.ToClrValue<int?>(m_returnValueParameter.Value);
    }
}
