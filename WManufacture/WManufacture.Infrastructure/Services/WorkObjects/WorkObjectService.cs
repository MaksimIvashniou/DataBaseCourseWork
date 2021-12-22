using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WorkObjects;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.WorkObjects
{
    public class WorkObjectService : IWorkObjectService
    {
        private readonly WManufactureContext _db;

        private readonly ILogger<WorkObjectService> _logger;

        public WorkObjectService(
            WManufactureContext db,
            ILogger<WorkObjectService> logger)
        {
            _db = db;

            _logger = logger;
        }

        public async Task CreateAsync(WorkObject data)
        {
            if (data.Id == 0)
            {
                if (!await _db.WeldingMachines.AnyAsync(workObject => workObject.Name.Equals(data.Name)))
                {
                    _db.WorkObjects.Add(data);

                    await _db.SaveChangesAsync();
                }
            }
        }

        public async Task DeleteAsync(int id)
        {
            var workObject = await _db.WorkObjects.FindAsync(id);

            if (workObject != null)
            {
                _db.WorkObjects.Remove(workObject);

                await _db.SaveChangesAsync();
            }
        }


        public async Task<WorkObject> GetAsync(int id)
        {
            var workObject = await _db.WorkObjects.FindAsync(id);

            return workObject;
        }

        public async Task UpdateAsync(
            int id,
            WorkObject data)
        {
            if (data != null
                && data.Id == id)
            {
                var workObject = await _db.WorkObjects.FindAsync(id);

                if (workObject != null
                    && !await _db.WorkObjects.AnyAsync(workObjects => workObjects.Name.Equals(data.Name)))
                {
                    workObject.Name = data.Name;

                    workObject.Description = data.Description;

                    _db.Update(workObject);

                    await _db.SaveChangesAsync();
                }
            }
        }
    }
}
