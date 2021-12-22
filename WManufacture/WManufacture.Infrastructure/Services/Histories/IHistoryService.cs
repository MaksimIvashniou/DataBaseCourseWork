using System.Threading.Tasks;
using WManufacture.Common.Entity;

namespace WManufacture.Infrastructure.Services.Histories
{
    public interface IHistoryService
    {
        Task CreateAsync(History data);
    }
}
