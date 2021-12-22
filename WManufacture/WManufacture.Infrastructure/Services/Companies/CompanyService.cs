using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.Companies
{
    public class CompanyService : ICompanyService
    {
        private readonly WManufactureContext _db;

        private readonly ILogger<CompanyService> _logger;

        public CompanyService(
            WManufactureContext db,
            ILogger<CompanyService> logger)
        {
            _db = db;

            _logger = logger;
        }

        public async Task CreateAsync(Company data)
        {
            if (data.Id == 0)
            {
                if (!await _db.Companies.AnyAsync(company => company.Name.Equals(data.Name)))
                {
                    _db.Companies.Add(data);

                    await _db.SaveChangesAsync();
                }
            }
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

        public async Task UpdateAsync(
            int id, 
            Company data)
        {
            if (data != null
                && data.Id == id)
            {
                var company = await _db.Companies.FindAsync(id);

                if (company != null
                    && !await _db.Companies.AnyAsync(company => company.Name.Equals(data.Name)))
                {
                    company.Name = data.Name;

                    _db.Update(company);

                    await _db.SaveChangesAsync();
                }
            }
        }
    }
}
