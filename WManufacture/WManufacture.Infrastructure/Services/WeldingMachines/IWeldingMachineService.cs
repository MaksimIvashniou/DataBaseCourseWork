using System.Collections.Generic;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WeldingMachines;

namespace WManufacture.Infrastructure.Services.WeldingMachines
{
    public interface IWeldingMachineService
    {
        Task<List<WeldingMachine>> GetAsync();

        Task<WeldingMachine> GetAsync(int id);

        Task CreateAsync(WeldingMachine data);

        Task UpdateAsync(
            int id,
            WeldingMachine data);

        Task DeleteAsync(int id);
    }
}
