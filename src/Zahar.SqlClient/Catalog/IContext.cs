namespace Zahar.SqlClient.Catalog
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IContext
    {
        bool IgnoreQueryResult(string spFullName);
    }
}
