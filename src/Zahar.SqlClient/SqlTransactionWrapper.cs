namespace Zahar.SqlClient
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Zahar.SqlClient.ISqlTransaction" />
    class SqlTransactionWrapper : ISqlTransaction
    {
        readonly System.Data.SqlClient.SqlTransaction m_innerTransaction;
        readonly System.Collections.Generic.Stack<System.Data.SqlClient.SqlTransaction> m_stack;

        public SqlTransactionWrapper(
            System.Data.SqlClient.SqlTransaction innerTransaction,
            System.Collections.Generic.Stack<System.Data.SqlClient.SqlTransaction> stack)
        {
            System.Diagnostics.Debug.Assert(innerTransaction != null);
            System.Diagnostics.Debug.Assert(stack != null);
            System.Diagnostics.Debug.Assert(stack.Count == 0 || stack.Peek() != innerTransaction);
            m_innerTransaction = innerTransaction;
            m_stack = stack;
            m_stack.Push(innerTransaction);
        }

        public System.Data.IsolationLevel IsolationLevel => m_innerTransaction.IsolationLevel;

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
