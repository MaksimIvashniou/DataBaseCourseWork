using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.Employees;

namespace WManufacture.Infrastructure.Services.Employees.Positions
{
    public interface IPositionService
    {
        Task<Position> GetAsync(int id);

        Task CreateAsync(Position data);

        Task UpdateAsync(
            int id,
            Position data);

        Task DeleteAsync(int id);
    }
}
