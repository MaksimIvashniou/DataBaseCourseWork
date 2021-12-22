﻿using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WeldingMachines;

namespace WManufacture.Infrastructure.Services.WeldingMachines.ModelOfWeldingMachines
{
    public interface IModelOfWeldingMachineService
    {
        Task<ModelOfWeldingMachine> GetAsync(int id);

        Task CreateAsync(ModelOfWeldingMachine data);

        Task UpdateAsync(
            int id,
            ModelOfWeldingMachine data);

        Task DeleteAsync(int id);
    }
}