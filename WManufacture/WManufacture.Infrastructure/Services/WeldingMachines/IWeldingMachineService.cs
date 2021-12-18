using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WeldingMachines;

namespace WManufacture.Infrastructure.Services.WeldingMachines
{
    public interface IWeldingMachineService
    {
        Task<WeldingMachine> GetAsync(int id);

        Task<WeldingMachine> CreateAsync(WeldingMachine data);

        Task<WeldingMachine> UpdateAsync(
            int id,
            WeldingMachine data);

        Task DeleteAsync(int id);
    }
}
