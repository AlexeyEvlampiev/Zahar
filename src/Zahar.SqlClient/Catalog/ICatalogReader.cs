namespace Zahar.SqlClient.Catalog
{
    using System.Threading.Tasks;

    interface ICatalogReader
    {
        Task<DbCatalog> ReadAsync();

        Task<ProcedureInfo> ReadSpInfoAsync(string spFullName);
    }
}
