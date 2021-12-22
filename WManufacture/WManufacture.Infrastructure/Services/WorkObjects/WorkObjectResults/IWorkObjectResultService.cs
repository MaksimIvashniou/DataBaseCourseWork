using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WorkObjects;

namespace WManufacture.Infrastructure.Services.WorkObjects.WorkObjectResults
{
    public interface IWorkObjectResultService
    {
        Task<WorkObjectResult> GetAsync(int id);

        Task CreateAsync(WorkObjectResult data);

        Task UpdateAsync(
            int id,
            WorkObjectResult data);

        Task DeleteAsync(int id);
    }
}
