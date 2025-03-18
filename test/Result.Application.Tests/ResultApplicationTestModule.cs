using Volo.Abp.Modularity;

namespace Result;

[DependsOn(
    typeof(ResultApplicationModule),
    typeof(ResultDomainTestModule)
    )]
public class ResultApplicationTestModule : AbpModule
{

}
