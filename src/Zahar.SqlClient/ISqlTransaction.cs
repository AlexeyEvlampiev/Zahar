namespace Zahar.SqlClient
{
    /// <summary>
    /// Represents a Transact-SQL transaction to be made in a SQL Server database.
    /// </summary>
    public interface ISqlTransaction : System.IDisposable
    {
        /// <summary>
        /// Gets the isolation level for this transaction.
        /// </summary>
        System.Data.IsolationLevel IsolationLevel { get; }

        /// <summary>
        /// Commits the database transaction.
        /// </summary>
        /// <exception cref="System.Exception">An error occurred while trying to commit the transaction.</exception>
        /// <exception cref="System.InvalidOperationException">The transaction has already been committed or rolled back or 
        /// the connection is broken.</exception>
        void Commit();

        /// <summary>
        /// Rolls back a transaction from a pending state.
        /// </summary>
        /// <exception cref="System.Exception">An error occurred while trying to rollback the transaction.</exception>
        /// <exception cref="System.InvalidOperationException">The transaction has already been committed or rolled back or 
        /// the connection is broken.</exception>
        void Rollback();

        /// <summary>
        /// Rolls back a transaction from a pending state, and specifies the transaction or savepoint name.
        /// </summary>
        /// <param name="transactionName">The name of the transaction to roll back, or the savepoint to which to roll back.</param>
        /// <exception cref="System.ArgumentException">No transaction name was specified.</exception>
        /// <exception cref="System.InvalidOperationException">The transaction has already been committed or rolled back or 
        /// the connection is broken.</exception>
        void Rollback(string transactionName);

        /// <summary>
        /// Creates a savepoint in the transaction that can be used to roll back a part of the transaction, and specifies the savepoint name.
        /// </summary>
        /// <param name="savePointName">The name of the savepoint.</param>
        /// <exception cref="System.Exception">An error occurred while trying to commit the transaction..</exception>
        /// <exception cref="System.InvalidOperationException">The transaction has already been committed or rolled back or 
        /// the connection is broken.</exception>
        void Save(string savePointName);
    }
}
