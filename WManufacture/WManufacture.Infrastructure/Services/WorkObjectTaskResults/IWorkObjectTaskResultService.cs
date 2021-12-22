using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WorkObjects;

namespace WManufacture.Infrastructure.Services.WorkObjectTaskResults
{
    public interface IWorkObjectTaskResultService
    {
        Task<WorkObjectTaskResult> GetAsync(int id);

        Task<WorkObjectTaskResult> CreateAsync(WorkObjectTaskResult data);

        Task<WorkObjectTaskResult> UpdateAsync(
            int id,
            WorkObjectTaskResult data);

        Task DeleteAsync(int id);
    }
}
