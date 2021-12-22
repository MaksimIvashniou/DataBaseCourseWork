using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WeldingMachines;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.WeldingMachines.ModelOfWeldingMachines
{
    public class ModelOfWeldingMachineService : IModelOfWeldingMachineService
    {
        private readonly WManufactureContext _db;

        private readonly ILogger<ModelOfWeldingMachineService> _logger;

        public ModelOfWeldingMachineService(
            WManufactureContext db, 
            ILogger<ModelOfWeldingMachineService> logger)
        {
            _db = db;

            _logger = logger;
        }

        public async Task CreateAsync(ModelOfWeldingMachine data)
        {
            if (data.Id == 0)
            {
                if (!await _db.ModelOfWeldingMachines.AnyAsync(model => model.Name.Equals(data.Name)))
                {
                    _db.ModelOfWeldingMachines.Add(data);

                    await _db.SaveChangesAsync();
                }
            }
        }

        public async Task DeleteAsync(int id)
        {
            var modelOfWeldingMachine = await _db.ModelOfWeldingMachines.FindAsync(id);

            if (modelOfWeldingMachine != null)
            {
                _db.ModelOfWeldingMachines.Remove(modelOfWeldingMachine);

                await _db.SaveChangesAsync();
            }
        }

        public async Task<ModelOfWeldingMachine> GetAsync(int id)
        {
            var modelOfWeldingMachine = await _db.ModelOfWeldingMachines.FindAsync(id);

            return modelOfWeldingMachine;
        }

        public async Task<List<ModelOfWeldingMachine>> GetAsync()
        {
            var modelOfWeldingMachines = await _db.ModelOfWeldingMachines.ToListAsync();

            return modelOfWeldingMachines;
        }

        public async Task UpdateAsync(
            int id, 
            ModelOfWeldingMachine data)
        {
            if (data != null
                && data.Id == id)
            {
                var modelOfWeldingMachine = await _db.ModelOfWeldingMachines.FindAsync(id);

                if (modelOfWeldingMachine != null)
                {
                    modelOfWeldingMachine.Name = data.Name;

                    _db.Update(modelOfWeldingMachine);

                    await _db.SaveChangesAsync();
                }
            }
        }
    }
}
