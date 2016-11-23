namespace Zahar.SqlClient
{
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
}
