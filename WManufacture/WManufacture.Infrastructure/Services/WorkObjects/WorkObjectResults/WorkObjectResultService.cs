using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WorkObjects;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.WorkObjects.WorkObjectResults
{
    public class WorkObjectResultService : IWorkObjectResultService
    {
        private readonly WManufactureContext _db;

        public WorkObjectResultService(WManufactureContext db)
        {
            _db = db;
        }

        public async Task<WorkObjectResult> CreateAsync(WorkObjectResult data)
        {
            if (data.Id <= 0)
            {
                _db.WorkObjectResults.Add(data);

                await _db.SaveChangesAsync();

                return data;
            }

            return null;
        }

        public async Task DeleteAsync(int id)
        {
            var workObjectResult = await _db.WorkObjectResults.FindAsync(id);

            if (workObjectResult != null)
            {
                _db.WorkObjectResults.Remove(workObjectResult);

                await _db.SaveChangesAsync();
            }
        }

        public async Task<WorkObjectResult> GetAsync(int id)
        {
            var workObjectResult = await _db.WorkObjectResults.FindAsync(id);

            return workObjectResult;
        }

        public async Task<WorkObjectResult> UpdateAsync(
            int id,
            WorkObjectResult data)
        {
            if (data.Id == id)
            {
                var workObjectResult = await _db.WorkObjectResults.FindAsync(id);

                if (workObjectResult != null)
                {
                    workObjectResult.IsSuccess = data.IsSuccess;

                    workObjectResult.CurrentStatus = data.CurrentStatus;

                    _db.Update(workObjectResult);

                    await _db.SaveChangesAsync();

                    return data;
                }
            }

            return null;
        }
    }
}
