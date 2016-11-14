namespace Zahar.SqlClient
{
    using System;

    public sealed class RelayDiagnosticsCallback : IDiagnosticsCallback
    {
        readonly Action<string> m_errorMessageHandler;
        readonly Action<string> m_warningMessaheHandler;

        public RelayDiagnosticsCallback(
            Action<string> onError,
            Action<string> onWarning)
        {
            m_errorMessageHandler = onError;
            m_warningMessaheHandler = onWarning;
        }

        public RelayDiagnosticsCallback(
            Action<string> onWarning)
        {
            m_errorMessageHandler = (message) => { throw new DiagnosticsCallbackErrorException(message); };
            m_warningMessaheHandler = onWarning;
        }

        public void Error(string message)
        {
            m_errorMessageHandler?.Invoke(message);
        }

        public void Warning(string message)
        {
            m_warningMessaheHandler?.Invoke(message);
        }

        public static IDiagnosticsCallback FromT4(object template)
        {
            if (ReferenceEquals(template, null))
                throw new ArgumentNullException(nameof(template));
            var type = template.GetType();
            var errorMethodInfo = type.GetMethod("Error", new[] { typeof(string) });
            var warningMethodInfo = type.GetMethod("Warning", new[] { typeof(string) });
            try
            {
                var onError = (Action<string>)Delegate.CreateDelegate(typeof(Action<string>), template, errorMethodInfo, throwOnBindFailure: true);
                var onWarning = (Action<string>)Delegate.CreateDelegate(typeof(Action<string>), template, warningMethodInfo, throwOnBindFailure: true);
                return new RelayDiagnosticsCallback(onError, onWarning);
            }
            catch (MissingMethodException)
            {
                throw new ArgumentException();
            }
        }

    }
}
