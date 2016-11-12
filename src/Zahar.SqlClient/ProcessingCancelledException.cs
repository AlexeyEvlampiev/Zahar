namespace Zahar.SqlClient
{
    using System;

    [Serializable]
    public abstract class ProcessingCancelledException : Exception
    {
        protected ProcessingCancelledException()
        {
        }

        protected ProcessingCancelledException(string message)
            : base(message)
        {
        }

        protected ProcessingCancelledException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
