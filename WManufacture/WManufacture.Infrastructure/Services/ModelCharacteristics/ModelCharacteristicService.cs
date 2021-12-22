﻿using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WeldingMachines;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.ModelCharacteristics
{
    public class ModelCharacteristicService : IModelCharacteristicService
    {
        private readonly WManufactureContext _db;

        public ModelCharacteristicService(WManufactureContext db)
        {
            _db = db;
        }

        public async Task<ModelCharacteristic> CreateAsync(ModelCharacteristic data)
        {
            if (data.Id <= 0)
            {
                _db.ModelCharacteristics.Add(data);

                await _db.SaveChangesAsync();

                return data;
            }

            return null;
        }

        public async Task DeleteAsync(int id)
        {
            var modelCharacteristic = await _db.ModelCharacteristics.FindAsync(id);

            if (modelCharacteristic != null)
            {
                _db.ModelCharacteristics.Remove(modelCharacteristic);

                await _db.SaveChangesAsync();
            }
        }

        public async Task<ModelCharacteristic> GetAsync(int id)
        {
            var modelCharacteristic = await _db.ModelCharacteristics.FindAsync(id);

            return modelCharacteristic;
        }

        public async Task<ModelCharacteristic> UpdateAsync(
            int id, 
            ModelCharacteristic data)
        {
            if (data.Id == id)
            {
                var modelCharacteristic = await _db.ModelCharacteristics.FindAsync(id);

                if (modelCharacteristic != null)
                {
                    modelCharacteristic.MaxCurrent = data.MaxCurrent;

                    modelCharacteristic.MinCurrent = data.MinCurrent;

                    modelCharacteristic.MaxVoltage = data.MaxVoltage;

                    modelCharacteristic.MinVoltage = data.MinVoltage;

                    _db.Update(modelCharacteristic);

                    await _db.SaveChangesAsync();

                    return modelCharacteristic;
                }
            }

            return null;
        }
    }
}
