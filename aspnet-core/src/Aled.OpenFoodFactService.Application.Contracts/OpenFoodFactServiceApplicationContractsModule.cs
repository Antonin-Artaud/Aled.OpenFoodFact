using Volo.Abp.Modularity;

namespace Aled.OpenFoodFactService;

[DependsOn(
    typeof(OpenFoodFactServiceDomainSharedModule)
)]
public class OpenFoodFactServiceApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        OpenFoodFactServiceDtoExtensions.Configure();
    }
}