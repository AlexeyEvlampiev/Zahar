namespace Zahar.SqlClient.Codegen
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Reflection;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Base class for this transformation
    /// </summary>
    public abstract partial class RuntimeTextTemplate : IRuntimeTextTemplate
    {
        #region Private Fields
        const int GenerationEnvironmentInitialCapacity = 100000;
        private IDiagnosticsCallback m_diagnosticsCallback;
        private IFormatInfo m_formatInfo;
        private Lazy<StringBuilder> m_generationEnvironment = new Lazy<StringBuilder>(() => new StringBuilder(GenerationEnvironmentInitialCapacity));
        private CompilerErrorCollection m_errors;
        private List<int> m_indentLengths;
        private string m_currentIndent = string.Empty;
        private bool m_endsWithNewline;
        private IDictionary<string, object> m_session;
        private static Lazy<string> s_generatedCodeAttribute;
        private const string ToolName = "Zahar";
        protected const string DebuggerNonUserCodeAttribute = "global::System.Diagnostics.DebuggerNonUserCodeAttribute()";
        public readonly string SqlParameterAttribute = Regex.Replace(typeof(SqlParameterAttribute).Name, @"Attribute$", string.Empty);
        #endregion

        static RuntimeTextTemplate()
        {
            s_generatedCodeAttribute = new Lazy<string>(() =>
            {
                var version = Assembly.GetAssembly(typeof(RuntimeTextTemplate)).GetName().Version.ToString();
                return $"global::System.CodeDom.Compiler.GeneratedCodeAttribute(\"{ToolName}\", \"{version}\")";
            });
        }

        protected RuntimeTextTemplate(IDiagnosticsCallback diagnosticsCallback, IFormatInfo formatInfo)
        {
            if (ReferenceEquals(diagnosticsCallback, null))
                throw new ArgumentException(nameof(diagnosticsCallback));
            if (ReferenceEquals(diagnosticsCallback, null))
                throw new ArgumentException(nameof(formatInfo));
            m_diagnosticsCallback = diagnosticsCallback;
            m_formatInfo = formatInfo;
        }

        #region Properties

        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected StringBuilder GenerationEnvironment => m_generationEnvironment.Value;
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public CompilerErrorCollection Errors
        {
            get
            {
                if ((m_errors == null))
                {
                    m_errors = new CompilerErrorCollection();
                }
                return m_errors;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private List<int> indentLengths
        {
            get
            {
                if ((m_indentLengths == null))
                {
                    m_indentLengths = new List<int>();
                }
                return m_indentLengths;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return m_currentIndent;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual IDictionary<string, object> Session
        {
            get
            {
                return m_session;
            }
            set
            {
                m_session = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((GenerationEnvironment.Length == 0)
                        || m_endsWithNewline))
            {
                GenerationEnvironment.Append(m_currentIndent);
                m_endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(Environment.NewLine, StringComparison.CurrentCulture))
            {
                m_endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((m_currentIndent.Length == 0))
            {
                GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(Environment.NewLine, (Environment.NewLine + m_currentIndent));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (m_endsWithNewline)
            {
                GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - m_currentIndent.Length));
            }
            else
            {
                GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            Write(textToAppend);
            GenerationEnvironment.AppendLine();
            m_endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            Write(string.Format(CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            WriteLine(string.Format(CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            m_diagnosticsCallback.Error(message);
            CompilerError error = new CompilerError();
            error.ErrorText = message;
            Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            m_diagnosticsCallback.Warning(message);
            CompilerError error = new CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new ArgumentNullException("indent");
            }
            m_currentIndent = (m_currentIndent + indent);
            indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((indentLengths.Count > 0))
            {
                int indentLength = indentLengths[(indentLengths.Count - 1)];
                indentLengths.RemoveAt((indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = m_currentIndent.Substring((m_currentIndent.Length - indentLength));
                    m_currentIndent = m_currentIndent.Remove((m_currentIndent.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            indentLengths.Clear();
            m_currentIndent = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private IFormatProvider formatProviderField = CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public IFormatProvider FormatProvider
            {
                get
                {
                    return formatProviderField;
                }
                set
                {
                    if ((value != null))
                    {
                        formatProviderField = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new ArgumentNullException("objectToConvert");
                }
                Type t = objectToConvert.GetType();
                MethodInfo method = t.GetMethod("ToString", new[] {
                            typeof(IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                return ((string)(method.Invoke(objectToConvert, new object[] {
                    formatProviderField })));
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return toStringHelperField;
            }
        }
        #endregion

        public abstract string TransformText();

        protected string GeneratedCodeAttribute => s_generatedCodeAttribute.Value;

        string IRuntimeTextTemplate.TransformText()
        {
            string output = this.TransformText();
            m_generationEnvironment = new Lazy<StringBuilder>(()=> new StringBuilder(GenerationEnvironmentInitialCapacity));
            return output;
        }
    }
}
