using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WorkObjects;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.WorkObjects
{
    class WorkObjectService : IWorkObjectService
    {
        private readonly WManufactureContext _db;

        public WorkObjectService(WManufactureContext db)
        {
            _db = db;
        }

        public async Task<WorkObject> CreateAsync(WorkObject data)
        {
            if (data.Id <= 0)
            {
                if (!await _db.WeldingMachines.AnyAsync(workObject => workObject.Name.Equals(data.Name)))
                {
                    _db.WorkObjects.Add(data);

                    await _db.SaveChangesAsync();
                }

                return data;
            }

            return null;
        }

        public async Task DeleteAsync(int id)
        {
            var workObject = await _db.WorkObjects.FindAsync(id);

            if (workObject != null)
            {
                _db.Remove(workObject);

                await _db.SaveChangesAsync();
            }
        }

        public async Task<WorkObject> GetAsync(int id)
        {
            var workObject = await _db.WorkObjects.FindAsync(id);

            return workObject;
        }

        public async Task<WorkObject> UpdateAsync(
            int id,
            WorkObject data)
        {
            if (id == data.Id)
            {
                var workObject = await _db.WorkObjects.FindAsync(id);

                if (workObject != null)
                {
                    workObject.Name = data.Name;

                    workObject.Description = data.Description;

                    _db.Update(workObject);

                    await _db.SaveChangesAsync();

                    return workObject;
                }
            }

            return null;
        }
    }
}
