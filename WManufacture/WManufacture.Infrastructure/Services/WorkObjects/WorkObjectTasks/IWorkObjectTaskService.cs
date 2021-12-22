using System.Collections.Generic;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WorkObjects;

namespace WManufacture.Infrastructure.Services.WorkObjects.WorkObjectTasks
{
    public interface IWorkObjectTaskService
    {

        Task<WorkObjectTask> GetAsync(int id);

        Task CreateAsync(WorkObjectTask data);

        Task UpdateAsync(
            int id,
            WorkObjectTask data);

        Task DeleteAsync(int id);
    }
}
