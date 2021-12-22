using System.Collections.Generic;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies;

namespace WManufacture.Infrastructure.Services.Companies
{
    public interface ICompanyService
    {
        Task<Company> GetAsync(int id);

        Task<List<Company>> GetAsync();

        Task CreateAsync(Company data);

        Task UpdateAsync(
            int id,
            Company data);

        Task DeleteAsync(int id);
    }
}
