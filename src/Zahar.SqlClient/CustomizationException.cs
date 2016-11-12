using System;

namespace Zahar.SqlClient
{
    [Serializable]
    public sealed class CustomizationException : ProcessingCancelledException
    {
        public CustomizationException(string message) : base(message)
        {
        }
    }
}
