using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WorkObjects;

namespace WManufacture.Infrastructure.Services.WorkObjects.WorkObjectTaskResults
{
    public interface IWorkObjectTaskResultService
    {
        Task<WorkObjectTaskResult> GetAsync(int id);

        Task CreateAsync(WorkObjectTaskResult data);

        Task UpdateAsync(
            int id,
            WorkObjectTaskResult data);

        Task DeleteAsync(int id);
    }
}
