using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.Employees;

namespace WManufacture.Infrastructure.Services.Employees.Permissions
{
    public interface IPermissionService
    {
        Task<Permission> GetAsync(int id);

        Task CreateAsync(Permission data);

        Task UpdateAsync(
            int id,
            Permission data);

        Task DeleteAsync(int id);
    }
}
