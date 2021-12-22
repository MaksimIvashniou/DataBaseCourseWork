using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WorkObjects;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.WorkObjects.WorkObjectTaskResults
{
    public class WorkObjectTaskResultService : IWorkObjectTaskResultService
    {
        private readonly WManufactureContext _db;

        private readonly ILogger<WorkObjectTaskResultService> _logger;

        public WorkObjectTaskResultService(
            WManufactureContext db, 
            ILogger<WorkObjectTaskResultService> logger)
        {
            _db = db;

            _logger = logger;
        }

        public async Task CreateAsync(WorkObjectTaskResult data)
        {
            if (data.Id == 0)
            {
                _db.WorkObjectTaskResults.Add(data);

                await _db.SaveChangesAsync();
            }
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

        public async Task UpdateAsync(
            int id, 
            WorkObjectTaskResult data)
        {
            if (data != null
                && data.Id == id)
            {
                var workObjectTaskResult = await _db.WorkObjectTaskResults.FindAsync(id);

                if (workObjectTaskResult != null)
                {
                    workObjectTaskResult.IsSuccess = data.IsSuccess;

                    workObjectTaskResult.CurrentStatus = data.CurrentStatus;

                    _db.Update(workObjectTaskResult);

                    await _db.SaveChangesAsync();
                }
            }
        }
    }
}
