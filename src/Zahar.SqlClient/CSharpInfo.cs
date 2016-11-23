namespace Zahar.SqlClient
{
    using System;
    using System.Collections.Generic;

    public class CSharpInfo
    {
        readonly HashSet<string> m_keywords = new HashSet<string>(StringComparer.Ordinal) {
            "abstract", "as",   "base", "bool",
            "break",    "byte", "case", "catch",
            "char", "checked",  "class",   "const",
            "continue", "decimal",  "default",  "delegate",
            "do",   "double",  "else",  "enum",
            "event",   "explicit",    "extern", "false",
            "finally",  "fixed", "float",   "for",
            "foreach",  "goto", "if",   "implicit",
            "in",   "in",   "int", "interface",
            "internal", "is",   "lock", "long",
            "namespace",   "new",   "null", "object",
            "operator",    "out",   "out",  "override",
            "params",   "private", "protected", "public",
            "readonly", "ref",  "return",   "sbyte",
            "sealed", "short",  "sizeof",   "stackalloc",
            "static", "string", "struct",  "switch",
            "this",    "throw", "true", "try",
            "typeof",   "uint",    "ulong",   "unchecked",
            "unsafe", "ushort", "using",    "virtual",
            "void", "volatile", "while", "async", "await",

        };
        public bool IsKeyword(string text)
        {
            return m_keywords.Contains(text);
        }
    }
}
