using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WeldingMachines;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.WeldingMachines.ModelOfWeldingMachines
{
    public class ModelOfWeldingMachineService : IModelOfWeldingMachineService
    {
        private readonly WManufactureContext _db;

        public ModelOfWeldingMachineService(WManufactureContext db)
        {
            _db = db;
        }

        public async Task<ModelOfWeldingMachine> CreateAsync(ModelOfWeldingMachine data)
        {
            if (data.Id <= 0)
            {
                if (!await _db.ModelOfWeldingMachines.AnyAsync(model => model.Name.Equals(data.Name)))
                {
                    _db.ModelOfWeldingMachines.Add(data);

                    await _db.SaveChangesAsync();

                    return data;
                }
            }

            return null;
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

        public async Task<ModelOfWeldingMachine> UpdateAsync(
            int id, 
            ModelOfWeldingMachine data)
        {
            if (data.Id != id)
            {
                var modelOfWeldingMachine = await _db.ModelOfWeldingMachines.FindAsync(id);

                if (modelOfWeldingMachine != null)
                {
                    modelOfWeldingMachine.Name = data.Name;

                    _db.Update(modelOfWeldingMachine);

                    await _db.SaveChangesAsync();

                    return modelOfWeldingMachine;
                }
            }

            return null;
        }
    }
}
