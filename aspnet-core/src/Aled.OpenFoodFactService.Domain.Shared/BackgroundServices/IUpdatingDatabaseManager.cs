using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace Aled.OpenFoodFactService.BackgroundServices;

public interface IUpdatingDatabaseManager : IDomainService
{
    Task UpdateDatabaseAsync(DateTime startDate);
}