using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Aled.OpenFoodFactService;

[DependsOn(
    typeof(OpenFoodFactServiceApplicationContractsModule)
)]
public class OpenFoodFactServiceHttpApiClientModule : AbpModule
{
    public const string RemoteServiceName = "Default";

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(OpenFoodFactServiceApplicationContractsModule).Assembly
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<OpenFoodFactServiceHttpApiClientModule>();
        });
    }
}