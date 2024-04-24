using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Aled.OpenFoodFactService.Services;

public class UpdatingDatabaseService : IUpdatingDatabaseService
{
    private readonly ILogger<UpdatingDatabaseService> _logger;

    public UpdatingDatabaseService(ILogger<UpdatingDatabaseService> logger)
    {
        _logger = logger;
    }

    public Task UpdateDatabaseAsync()
    {
        _logger.LogWarning("Need to implement this method to update the database!");
        return Task.CompletedTask;
    }
}