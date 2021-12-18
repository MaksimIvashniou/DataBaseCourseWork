using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.Companies
{
    public class CompanyService : ICompanyService
    {
        private readonly WManufactureContext _db;

        public CompanyService(WManufactureContext db)
        {
            _db = db;
        }

        public async Task<Company> CreateAsync(Company data)
        {
            if (data.Id <= 0)
            {
                if (!await _db.Companies.AnyAsync(company => company.Name.Equals(data.Name)))
                {
                    _db.Companies.Add(data);

                    await _db.SaveChangesAsync();
                }

                return data;
            }

            return null;
        }

        public async Task DeleteAsync(int id)
        {
            var company = await _db.Companies.FindAsync(id);

            if (company != null)
            {
                _db.Companies.Remove(company);

                await _db.SaveChangesAsync();
            }
        }

        public async Task<Company> GetAsync(int id)
        {
            var company = await _db.Companies.FindAsync(id);

            return company;
        }

        public async Task<Company> UpdateAsync(
            int id, 
            Company data)
        {
            if (id == data.Id)
            {
                var company = await _db.Companies.FindAsync(id);

                if (company != null)
                {
                    company.Name = data.Name;

                    _db.Update(company);

                    await _db.SaveChangesAsync();

                    return company;
                }
            }

            return null;
        }
    }
}
