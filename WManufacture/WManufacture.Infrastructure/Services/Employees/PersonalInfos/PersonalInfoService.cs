using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.Employees;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.Employees.PersonalInfos
{
    public class PersonalInfoService : IPersonalInfoService
    {
        private readonly WManufactureContext _db;

        private readonly ILogger<PersonalInfoService> _logger;

        public PersonalInfoService(
            WManufactureContext db, 
            ILogger<PersonalInfoService> logger)
        {
            _db = db;

            _logger = logger;
        }

        public async Task CreateAsync(PersonalInfo data)
        {
            if (data.Id == 0)
            {
                _db.PersonalInfos.Add(data);

                await _db.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            var personalInfo = await _db.PersonalInfos.FindAsync(id);

            if (personalInfo != null)
            {
                _db.PersonalInfos.Remove(personalInfo);

                await _db.SaveChangesAsync();
            }
        }

        public async Task<PersonalInfo> GetAsync(int id)
        {
            var personalInfo = await _db.PersonalInfos.FindAsync(id);

            return personalInfo;
        }

        public async Task UpdateAsync(
            int id, 
            PersonalInfo data)
        {
            if (data != null
                && data.Id == id)
            {
                var personalInfo = await _db.PersonalInfos.FindAsync(id);

                if (personalInfo != null)
                {
                    personalInfo.AdditionalInfo = data.AdditionalInfo;

                    personalInfo.WorkPhone = data.WorkPhone;
                    
                    personalInfo.Rank = data.Rank;

                    personalInfo.CertificateDate = data.CertificateDate;

                    personalInfo.IsUserBlocked = data.IsUserBlocked;

                    _db.Update(personalInfo);

                    await _db.SaveChangesAsync();
                }
            }
        }
    }
}
