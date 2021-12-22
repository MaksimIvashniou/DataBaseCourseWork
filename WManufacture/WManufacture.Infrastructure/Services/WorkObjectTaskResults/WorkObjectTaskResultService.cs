using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WorkObjects;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.WorkObjectTaskResults
{
    public class WorkObjectTaskResultService : IWorkObjectTaskResultService
    {
        private readonly WManufactureContext _db;

        public WorkObjectTaskResultService(WManufactureContext db)
        {
            _db = db;
        }

        public async Task<WorkObjectTaskResult> CreateAsync(WorkObjectTaskResult data)
        {
            if (data.Id <= 0)
            {
                _db.WorkObjectTaskResults.Add(data);

                await _db.SaveChangesAsync();

                return data;
            }

            return null;
        }

        public async Task DeleteAsync(int id)
        {
            var workObjectTaskResult = await _db.WorkObjectTaskResults.FindAsync(id);

            if (workObjectTaskResult != null)
            {
                _db.WorkObjectTaskResults.Remove(workObjectTaskResult);

                await _db.SaveChangesAsync();
            }
        }

        public async Task<WorkObjectTaskResult> GetAsync(int id)
        {
            var workObjectTaskResult = await _db.WorkObjectTaskResults.FindAsync(id);

            return workObjectTaskResult;
        }

        public async Task<WorkObjectTaskResult> UpdateAsync(
            int id, 
            WorkObjectTaskResult data)
        {
            if (data.Id == id)
            {
                var workObjectTaskResult = await _db.WorkObjectTaskResults.FindAsync(id);

                if (workObjectTaskResult != null)
                {
                    workObjectTaskResult.IsSuccess = data.IsSuccess;

                    workObjectTaskResult.CurrentStatus = data.CurrentStatus;

                    _db.Update(workObjectTaskResult);

                    await _db.SaveChangesAsync();

                    return data;
                }
            }

            return null;
        }
    }
}
