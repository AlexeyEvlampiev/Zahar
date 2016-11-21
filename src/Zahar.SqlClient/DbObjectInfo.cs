namespace Zahar.SqlClient
{
    using System;
    using System.Diagnostics;
    using System.Text.RegularExpressions;

    public class DbObjectInfo : IEquatable<DbObjectInfo>
    {
        const string DefaultSchema = "dbo";

        #region Private Fields
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_schema = DefaultSchema;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_name;
        #endregion

        public DbObjectInfo()
        {

        }

        public DbObjectInfo(string fullName)
        {
            this.FullName = fullName;
        }

        public string Schema
        {
            get { return m_schema; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    value = DefaultSchema;
                value = GetStrippedName(value);

                if (value.Equals(m_schema, StringComparison.OrdinalIgnoreCase))
                    return;

                if (IsValidName(value))
                {
                    m_schema = value;
                }
                else
                {
                    throw new FormatException($@"""{value}"" is not a valid SQL database schema name.");
                }
            }
        }

        public string Name
        {
            get { return m_name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new InvalidOperationException($@"Name must not be null or a white space string.");
                value = GetStrippedName(value);
                if (value.Equals(m_name, StringComparison.OrdinalIgnoreCase))
                    return;
                if (IsValidName(value))
                {
                    m_name = value;
                }
                else
                {
                    throw new FormatException($@"""{value}"" is not a valid SQL database object name.");
                }
            }
        }

        public string FullName
        {
            get { return $"[{Schema}].[{Name}]"; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new InvalidOperationException("FullName must not be null or a white space string.");
                var match = Regex.Match(value, @"^@part(?:\.@part)*$".Replace("@part", @"(?<part>[^.]+)"));
                if (!match.Success)
                    throw new FormatException();
                var captures = match.Groups["part"].Captures;
                if (captures.Count == 1)
                {
                    Schema = DefaultSchema;
                    Name = GetStrippedName(captures[0].Value);
                    return;
                }
                else if (captures.Count > 4)
                {
                    throw new InvalidOperationException();
                }

                Schema = captures[captures.Count - 2].Value;
                Name = captures[captures.Count - 1].Value;
            }
        }

        public bool Equals(DbObjectInfo other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(other, this))
                return false;
            if (string.IsNullOrWhiteSpace(m_name))
                return false;
            return Schema.Equals(other.Schema, StringComparison.OrdinalIgnoreCase) &&
                   Name.Equals(other.Name, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return FullName;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
                return true;
            if (string.IsNullOrEmpty(m_name))
                return false;
            var other = obj as DbObjectInfo;
            if (ReferenceEquals(other, null))
                return false;

            return Name.Equals(other.Name, StringComparison.OrdinalIgnoreCase);
        }

        private static string GetStrippedName(string name)
        {
            return Regex.Replace(name, @"^\s*\[\s*|\s*\]\s*$", string.Empty);
        }

        private static bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"^\w+(?:[\s-]+\w+)*$");
        }
    }
}
