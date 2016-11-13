namespace Zahar.SqlClient
{
    using System;
    using System.Diagnostics;
    using System.Threading;

    public class DiagnosticsCallbackScope : IDiagnosticsCallback
    {
        #region Private Fields
        readonly IDiagnosticsCallback m_innerCallback;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_errors;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_warnings;

        #endregion

        [DebuggerStepThrough]
        public DiagnosticsCallbackScope(IDiagnosticsCallback callback)
        {
            if (ReferenceEquals(callback, null))
                throw new ArgumentNullException(nameof(callback));
            m_innerCallback = callback;
        }

        public int ErrorsCount => m_errors;

        public int WarningsCount => m_warnings;

        [DebuggerStepThrough]
        public void Error(string message)
        {
            m_innerCallback.Error(message);
            Interlocked.Increment(ref m_errors);
        }

        [DebuggerStepThrough]
        public void Warning(string message)
        {
            m_innerCallback.Warning(message);
            Interlocked.Increment(ref m_warnings);
        }
    }
}
