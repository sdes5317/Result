using Result.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Result.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ResultEntityFrameworkCoreModule),
    typeof(ResultApplicationContractsModule)
    )]
public class ResultDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
