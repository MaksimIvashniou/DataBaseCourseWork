using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.Employees;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.PersonalInfos
{
    public class PersonalInfoService : IPersonalInfoService
    {
        private readonly WManufactureContext _db;

        public PersonalInfoService(WManufactureContext db)
        {
            _db = db;
        }

        public async Task<PersonalInfo> CreateAsync(PersonalInfo data)
        {
            if (data.Id <= 0)
            {
                _db.PersonalInfos.Add(data);

                await _db.SaveChangesAsync();

                return data;
            }

            return null;
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

        public async Task<PersonalInfo> UpdateAsync(
            int id, 
            PersonalInfo data)
        {
            if (data.Id == id)
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

                    return personalInfo;
                }
            }

            return null;
        }
    }
}
