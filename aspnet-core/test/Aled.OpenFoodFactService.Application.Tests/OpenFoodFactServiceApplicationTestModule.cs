using Volo.Abp.Modularity;

namespace Aled.OpenFoodFactService;

[DependsOn(
    typeof(OpenFoodFactServiceApplicationModule),
    typeof(OpenFoodFactServiceDomainTestModule)
)]
public class OpenFoodFactServiceApplicationTestModule : AbpModule
{

}
