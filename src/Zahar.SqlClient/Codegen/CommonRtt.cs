namespace Zahar.SqlClient.Codegen
{
    using System.Text;
    using System.Text.RegularExpressions;

    public sealed class CommonRtt : RuntimeTextTemplate
    {
        readonly Regex m_csCodeNamespaceTags = new Regex(@"^[^{]*.|[}]\s*$");

        public CommonRtt(IDiagnosticsCallback diagnosticsCallback, IFormatInfo formatInfo) : base(diagnosticsCallback, formatInfo) { }

        public override string TransformText()
        {
            var parts = new string[] 
            {
                Resources.Disposable,
                Resources.SqlDbClient,
                Resources.ReturnValueSqlCommandOutput
            };

            var sb = new StringBuilder();
            foreach (var csCode in parts)
            {
                sb.AppendLine(m_csCodeNamespaceTags.Replace(csCode, string.Empty) );
            }

            return Regex.Replace(sb.ToString(), @"(?=\bSystem\.)", "global::");
        }
    }
}
