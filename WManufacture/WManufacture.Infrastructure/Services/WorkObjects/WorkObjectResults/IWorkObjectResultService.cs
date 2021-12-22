using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WorkObjects;

namespace WManufacture.Infrastructure.Services.WorkObjects.WorkObjectResults
{
    public interface IWorkObjectResultService
    {
        Task<WorkObjectResult> GetAsync(int id);

        Task<WorkObjectResult> CreateAsync(WorkObjectResult data);

        Task<WorkObjectResult> UpdateAsync(
            int id,
            WorkObjectResult data);

        Task DeleteAsync(int id);
    }
}
