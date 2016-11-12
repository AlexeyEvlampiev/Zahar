namespace Zahar.SqlClient
{
    using System;

    /// <summary>
    /// <see cref="System.IDisposable"/> factory.
    /// </summary>
    public static class Disposable
    {
        public static readonly IDisposable Null = new DisposableNullObject();

        public static IDisposable Create(Action callback) { return new RelayDisposable(callback); }

        sealed class DisposableNullObject : IDisposable
        {
            public void Dispose() { }
        }

        sealed class RelayDisposable : IDisposable
        {
            private Action m_callback;

            public RelayDisposable(Action callback)
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
