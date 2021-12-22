using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.Employees;

namespace WManufacture.Infrastructure.Services.Employees.PersonalInfos
{
    public interface IPersonalInfoService
    {
        Task<PersonalInfo> GetAsync(int id);

        Task<PersonalInfo> CreateAsync(PersonalInfo data);

        Task<PersonalInfo> UpdateAsync(
            int id,
            PersonalInfo data);

        Task DeleteAsync(int id);
    }
}
