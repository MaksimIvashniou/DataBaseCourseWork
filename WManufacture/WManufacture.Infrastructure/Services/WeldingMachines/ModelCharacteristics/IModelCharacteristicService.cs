using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WeldingMachines;

namespace WManufacture.Infrastructure.Services.WeldingMachines.ModelCharacteristics
{
    public interface IModelCharacteristicService
    {
        Task<ModelCharacteristic> GetAsync(int id);

        Task<ModelCharacteristic> CreateAsync(ModelCharacteristic data);

        Task<ModelCharacteristic> UpdateAsync(
            int id,
            ModelCharacteristic data);

        Task DeleteAsync(int id);
    }
}
