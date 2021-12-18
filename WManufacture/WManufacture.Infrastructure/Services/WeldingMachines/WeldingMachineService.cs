using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WeldingMachines;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.WeldingMachines
{
    public class WeldingMachineService : IWeldingMachineService
    {
        private readonly WManufactureContext _db;

        public WeldingMachineService(WManufactureContext db)
        {
            _db = db;
        }

        public async Task<WeldingMachine> CreateAsync(WeldingMachine data)
        {
            if (data.Id <= 0)
            {
                if (!await _db.WeldingMachines.AnyAsync(weldingMachine => weldingMachine.Name.Equals(data.Name)))
                {
                    _db.WeldingMachines.Add(data);

                    await _db.SaveChangesAsync();
                }

                return data;
            }

            return null;
        }

        public async Task DeleteAsync(int id)
        {
            var weldingMachine = await _db.WeldingMachines.FindAsync(id);

            if (weldingMachine != null)
            {
                _db.WeldingMachines.Remove(weldingMachine);

                await _db.SaveChangesAsync();
            }
        }

        public async Task<WeldingMachine> GetAsync(int id)
        {
            var weldingMachine = await _db.WeldingMachines.FindAsync(id);

            return weldingMachine;
        }

        public async Task<WeldingMachine> UpdateAsync(
            int id, 
            WeldingMachine data)
        {
            if (id == data.Id)
            {
                var weldingMachine = await _db.WeldingMachines.FindAsync(id);

                if (weldingMachine != null)
                {
                    weldingMachine.Name = data.Name;

                    weldingMachine.CertificationDate = data.CertificationDate;

                    _db.Update(weldingMachine);

                    await _db.SaveChangesAsync();

                    return weldingMachine;
                }
            }

            return null;
        }
    }
}
