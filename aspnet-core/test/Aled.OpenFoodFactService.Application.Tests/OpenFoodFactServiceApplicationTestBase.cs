using Volo.Abp.Modularity;

namespace Aled.OpenFoodFactService;

public abstract class OpenFoodFactServiceApplicationTestBase<TStartupModule> : OpenFoodFactServiceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
