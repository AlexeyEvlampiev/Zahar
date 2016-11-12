namespace Zahar.SqlClient
{
    public interface IDiagnosticsCallback
    {
        void Error(string message);
        void Warning(string message);
    }
}
