namespace Zahar.SqlClient.Codegen
{
    public interface IRuntimeTextTemplate
    {
        void PushIndent(string indent);

        string TransformText();
    }
}
