using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies;

namespace WManufacture.Infrastructure.Services.Companies
{
    public interface ICompanyService
    {
        Task<Company> GetAsync(int id);

        Task<Company> CreateAsync(Company data);

        Task<Company> UpdateAsync(
            int id,
            Company data);

        Task DeleteAsync(int id);
    }
}
