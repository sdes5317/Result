using Result.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Result;

[DependsOn(
    typeof(ResultEntityFrameworkCoreTestModule)
    )]
public class ResultDomainTestModule : AbpModule
{

}
