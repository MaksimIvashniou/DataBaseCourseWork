using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.Employees;

namespace WManufacture.Infrastructure.Services.Employees.PersonalInfos
{
    public interface IPersonalInfoService
    {
        Task<PersonalInfo> GetAsync(int id);

        Task CreateAsync(PersonalInfo data);

        Task UpdateAsync(
            int id,
            PersonalInfo data);

        Task DeleteAsync(int id);
    }
}
