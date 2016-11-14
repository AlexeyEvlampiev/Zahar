namespace Zahar.SqlClient.Catalog
{
    using System.Threading.Tasks;

    interface ICatalogReader
    {
        Task<Catalog> ReadAsync();

        Task<ProcedureInfo> ReadSpInfoAsync(string spFullName);
    }
}
