using System.Threading.Tasks;

namespace Result.Data;

public interface IResultDbSchemaMigrator
{
    Task MigrateAsync();
}
