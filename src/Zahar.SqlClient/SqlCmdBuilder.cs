namespace Zahar.SqlClient
{
    public abstract class SqlCmdBuilder
    {
        public abstract void BuildCommand(System.Data.SqlClient.SqlCommand command);

        public void BuildCommand(
            System.Data.SqlClient.SqlCommand command, 
            System.Data.SqlClient.SqlConnection connection)
        {
            if (ReferenceEquals(command, null))
                throw new System.ArgumentNullException(nameof(command));
            if (ReferenceEquals(connection, null))
                throw new System.ArgumentNullException(nameof(connection));
            this.BuildCommand(command);
            command.Connection = connection;
        }

        public void BuildCommand(
            System.Data.SqlClient.SqlCommand command,
            System.Data.SqlClient.SqlTransaction transaction)
        {
            if (ReferenceEquals(command, null))
                throw new System.ArgumentNullException(nameof(command));
            if (ReferenceEquals(transaction, null))
                throw new System.ArgumentNullException(nameof(transaction));
            this.BuildCommand(command);
            command.Connection = transaction.Connection;
            command.Transaction = transaction;
        }

        public System.Data.SqlClient.SqlCommand BuildCommand()
        {
            var command = new System.Data.SqlClient.SqlCommand();
            this.BuildCommand(command);
            return command;
        }

        public System.Data.SqlClient.SqlCommand BuildCommand(System.Data.SqlClient.SqlConnection connection)
        {
            var command = new System.Data.SqlClient.SqlCommand();
            this.BuildCommand(command, connection);
            return command;
        }

        public System.Data.SqlClient.SqlCommand BuildCommand(System.Data.SqlClient.SqlTransaction transaction)
        {
            var command = new System.Data.SqlClient.SqlCommand();
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
            return (ReferenceEquals(value, null) || System.DBNull.Value.Equals(value))
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
                ? (object)System.DBNull.Value
                : value;
        }
    }
}
