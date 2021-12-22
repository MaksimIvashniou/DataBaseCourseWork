using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WeldingMachines;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.WeldingMachines
{
    public class WeldingMachineService : IWeldingMachineService
    {
        private readonly WManufactureContext _db;

        private readonly ILogger<WeldingMachineService> _logger;

        public WeldingMachineService(
            WManufactureContext db,
            ILogger<WeldingMachineService> logger)
        {
            _db = db;

            _logger = logger;
        }

        public async Task CreateAsync(WeldingMachine data)
        {
            if (data.Id == 0)
            {
                if (!await _db.WeldingMachines.AnyAsync(weldingMachine => weldingMachine.Name.Equals(data.Name)))
                {
                    _db.WeldingMachines.Add(data);

                    await _db.SaveChangesAsync();
                }
            }
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

        public async Task<List<WeldingMachine>> GetAsync()
        {
            var weldingMachines = await _db.WeldingMachines.ToListAsync();

            return weldingMachines;
        }

        public async Task UpdateAsync(
            int id, 
            WeldingMachine data)
        {
            if (data != null
                && data.Id == id)
            {
                var weldingMachine = await _db.WeldingMachines.FindAsync(id);

                if (weldingMachine != null)
                {
                    weldingMachine.Name = data.Name;

                    weldingMachine.CertificationDate = data.CertificationDate;

                    _db.Update(weldingMachine);

                    await _db.SaveChangesAsync();
                }
            }
        }
    }
}
