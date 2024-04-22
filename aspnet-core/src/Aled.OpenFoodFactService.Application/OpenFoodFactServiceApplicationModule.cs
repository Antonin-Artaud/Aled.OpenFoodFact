using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Aled.OpenFoodFactService;

[DependsOn(
    typeof(OpenFoodFactServiceDomainModule),
    typeof(OpenFoodFactServiceApplicationContractsModule)
)]
public class OpenFoodFactServiceApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options => { options.AddMaps<OpenFoodFactServiceApplicationModule>(); });
    }
}