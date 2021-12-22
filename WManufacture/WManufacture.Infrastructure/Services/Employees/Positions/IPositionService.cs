using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.Employees;

namespace WManufacture.Infrastructure.Services.Employees.Positions
{
    public interface IPositionService
    {
        Task<Position> GetAsync(int id);

        Task<Position> CreateAsync(Position data);

        Task<Position> UpdateAsync(
            int id,
            Position data);

        Task DeleteAsync(int id);
    }
}
