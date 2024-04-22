using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Aled.OpenFoodFactService;

[Authorize]
public class HealthCheckAppService : OpenFoodFactServiceAppService, IHealthCheckAppService
{
    public Task<string> CheckAsync() => Task.FromResult("Healthy!");
}