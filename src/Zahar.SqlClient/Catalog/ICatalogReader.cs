namespace Zahar.SqlClient.Catalog
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    interface ICatalogReader
    {
        Task<Catalog> ReadAsync();

        Task<ProcedureInfo> ReadSpInfoAsync(string spFullName, IDictionary<string, object> session);
    }
}
