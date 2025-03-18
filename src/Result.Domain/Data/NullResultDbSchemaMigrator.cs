using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Result.Data;

/* This is used if database provider does't define
 * IResultDbSchemaMigrator implementation.
 */
public class NullResultDbSchemaMigrator : IResultDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
