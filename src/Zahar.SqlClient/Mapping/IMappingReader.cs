namespace Zahar.SqlClient.Mapping
{
    using System.Threading.Tasks;

    interface IMappingReader
    {
        Task<Mapping> ReadAsync();
    }
}
