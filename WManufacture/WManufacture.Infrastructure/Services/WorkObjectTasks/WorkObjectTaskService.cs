using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WorkObjects;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.WorkObjectTasks
{
    public class WorkObjectTaskService : IWorkObjectTaskService
    {
        private readonly WManufactureContext _db;

        public WorkObjectTaskService(WManufactureContext db)
        {
            _db = db;
        }

        public async Task<WorkObjectTask> CreateAsync(WorkObjectTask data)
        {
            if (data.Id <= 0)
            {
                _db.WorkObjectTasks.Add(data);

                await _db.SaveChangesAsync();

                return data;
            }

            return null;
        }

        public async Task DeleteAsync(int id)
        {
            var workObjectTask = await _db.WorkObjectTasks.FindAsync(id);

            if (workObjectTask != null)
            {
                _db.WorkObjectTasks.Remove(workObjectTask);

                await _db.SaveChangesAsync();
            }
        }

        public async Task<WorkObjectTask> GetAsync(int id)
        {
            var workObjectTask = await _db.WorkObjectTasks.FindAsync(id);

            return workObjectTask;
        }

        public async Task<WorkObjectTask> UpdateAsync(
            int id, 
            WorkObjectTask data)
        {
            if (data.Id == id)
            {
                var workObjectTask = await _db.WorkObjectTasks.FindAsync(id);

                if (workObjectTask != null)
                {
                    workObjectTask.Name = data.Name;

                    workObjectTask.Description = data.Description;

                    _db.Update(workObjectTask);

                    await _db.SaveChangesAsync();

                    return data;
                }
            }

            return null;
        }
    }
}
