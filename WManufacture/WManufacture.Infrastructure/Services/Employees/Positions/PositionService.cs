using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.Employees;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.Employees.Positions
{
    public class PositionService : IPositionService
    {
        private readonly WManufactureContext _db;

        private readonly ILogger<PositionService> _logger;

        public PositionService(
            WManufactureContext db,
            ILogger<PositionService> logger)
        {
            _db = db;

            _logger = logger;
        }

        public async Task CreateAsync(Position data)
        {
            if (data.Id == 0)
            {
                if (!await _db.Positions.AnyAsync(position => position.Name.Equals(data.Name)))
                {
                    _db.Positions.Add(data);

                    await _db.SaveChangesAsync();
                }
            }
        }

        public async Task DeleteAsync(int id)
        {
            var position = await _db.Positions.FindAsync(id);

            if (position != null)
            {
                _db.Positions.Remove(position);

                await _db.SaveChangesAsync();
            }
        }

        public async Task<Position> GetAsync(int id)
        {
            var position = await _db.Positions.FindAsync(id);

            return position;
        }

        public async Task UpdateAsync(
            int id, 
            Position data)
        {
            if (data != null
                && data.Id == id)
            {
                var position = await _db.Positions.FindAsync(id);

                if (position != null)
                {
                    position.Name = data.Name;

                    _db.Update(position);

                    await _db.SaveChangesAsync();
                }
            }
        }
    }
}
