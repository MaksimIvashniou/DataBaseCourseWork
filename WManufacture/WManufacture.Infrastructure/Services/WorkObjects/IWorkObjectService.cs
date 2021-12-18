using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WorkObjects;

namespace WManufacture.Infrastructure.Services.WorkObjects
{
    public interface IWorkObjectService
    {
        Task<WorkObject> GetAsync(int id);

        Task<WorkObject> CreateAsync(WorkObject data);

        Task<WorkObject> UpdateAsync(
            int id,
            WorkObject data);

        Task DeleteAsync(int id);
    }
}
