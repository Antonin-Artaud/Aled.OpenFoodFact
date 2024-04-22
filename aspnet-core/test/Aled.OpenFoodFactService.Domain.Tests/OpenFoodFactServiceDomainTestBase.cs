using Volo.Abp.Modularity;

namespace Aled.OpenFoodFactService;

/* Inherit from this class for your domain layer tests. */
public abstract class OpenFoodFactServiceDomainTestBase<TStartupModule> : OpenFoodFactServiceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
