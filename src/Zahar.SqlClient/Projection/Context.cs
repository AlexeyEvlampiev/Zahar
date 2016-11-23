namespace Zahar.SqlClient.Projection
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    class Context : Catalog.IContext
    {
        #region Nested Types
        [DebuggerDisplay("IgnoreQueryResult: {IgnoreQueryResult}")]
        class SpSelectorInfo
        {
            public bool IgnoreQueryResult;
        }
        #endregion

        #region Private Fields
        readonly Dictionary<string, SpSelectorInfo>
            m_spSelectorInfos = new Dictionary<string, SpSelectorInfo>(StringComparer.OrdinalIgnoreCase); 
        #endregion

        public Context(Mapping.Mapping mapping)
        {
            if (ReferenceEquals(mapping, null))
                throw new ArgumentNullException(nameof(mapping));
            var procedures = mapping.Procedures ?? new Mapping.Procedure[0];
            foreach (var selector in procedures)
            {
                m_spSelectorInfos[selector.FullName] = new SpSelectorInfo
                {
                    IgnoreQueryResult = selector.IgnoreQueryResult
                };
            }
        }

        public IEnumerable<string> SelectedSpFullNames => m_spSelectorInfos.Keys;

        public bool IsSelected(string spFullName)
        {
            return m_spSelectorInfos.ContainsKey(spFullName);
        }

        public bool IgnoreQueryResult(string spFullName)
        {
            try
            {
                return m_spSelectorInfos[spFullName].IgnoreQueryResult;
            }
            catch (KeyNotFoundException)
            {
                return false;
            }
        }
    }
}
