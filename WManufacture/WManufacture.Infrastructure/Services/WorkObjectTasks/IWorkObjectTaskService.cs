using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WorkObjects;

namespace WManufacture.Infrastructure.Services.WorkObjectTasks
{
    public interface IWorkObjectTaskService
    {
        Task<WorkObjectTask> GetAsync(int id);

        Task<WorkObjectTask> CreateAsync(WorkObjectTask data);

        Task<WorkObjectTask> UpdateAsync(
            int id,
            WorkObjectTask data);

        Task DeleteAsync(int id);
    }
}
