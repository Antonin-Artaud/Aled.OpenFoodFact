using Volo.Abp.Modularity;

namespace Aled.OpenFoodFactService;

[DependsOn(
    typeof(OpenFoodFactServiceDomainModule),
    typeof(OpenFoodFactServiceTestBaseModule)
)]
public class OpenFoodFactServiceDomainTestModule : AbpModule
{

}
