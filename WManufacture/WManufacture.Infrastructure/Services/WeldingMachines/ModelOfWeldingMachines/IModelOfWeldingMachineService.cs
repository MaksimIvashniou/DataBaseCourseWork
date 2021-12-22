using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WeldingMachines;

namespace WManufacture.Infrastructure.Services.WeldingMachines.ModelOfWeldingMachines
{
    public interface IModelOfWeldingMachineService
    {
        Task<ModelOfWeldingMachine> GetAsync(int id);

        Task<ModelOfWeldingMachine> CreateAsync(ModelOfWeldingMachine data);

        Task<ModelOfWeldingMachine> UpdateAsync(
            int id,
            ModelOfWeldingMachine data);

        Task DeleteAsync(int id);
    }
}
