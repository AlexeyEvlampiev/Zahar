namespace Zahar.SqlClient
{
    using System;

    [Serializable]
    public sealed class DiagnosticsCallbackErrorException : ProcessingCancelledException
    {
        public DiagnosticsCallbackErrorException(string message) : base(message) { }
    }
}
