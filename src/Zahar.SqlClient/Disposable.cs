namespace Zahar.SqlClient
{    
    /// <summary>
    /// <see cref="System.IDisposable"/> factory.
    /// </summary>
    public static class Disposable
    {
        public static readonly System.IDisposable Null = new DisposableNullObject();

        public static System.IDisposable Create(System.Action callback) { return new RelayDisposable(callback); }

        sealed class DisposableNullObject : System.IDisposable
        {
            public void Dispose() { }
        }

        sealed class RelayDisposable : System.IDisposable
        {
            private System.Action m_callback;

            public RelayDisposable(System.Action callback)
            {
                m_callback = callback;
            }

            public void Dispose()
            {
                m_callback?.Invoke();
                m_callback = null;
            }
        }
    }
}
