using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace Aled.OpenFoodFactService.Services;

public interface IUpdatingDatabaseService : IDomainService
{
    Task UpdateDatabaseAsync();
}