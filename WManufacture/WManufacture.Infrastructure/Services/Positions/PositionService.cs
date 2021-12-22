using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.Employees;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.Positions
{
    public class PositionService : IPositionService
    {
        private readonly WManufactureContext _db;

        public PositionService(WManufactureContext db)
        {
            _db = db;
        }

        public async Task<Position> CreateAsync(Position data)
        {
            if (data.Id <= 0)
            {
                if (!await _db.Positions.AnyAsync(position => position.Name.Equals(data.Name)))
                {
                    _db.Positions.Add(data);

                    await _db.SaveChangesAsync();

                    return data;
                }
            }

            return null;
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

        public async Task<Position> UpdateAsync(
            int id, 
            Position data)
        {
            if (data.Id == id)
            {
                var position = await _db.Positions.FindAsync(id);

                if (position != null)
                {
                    position.Name = data.Name;

                    _db.Update(position);

                    await _db.SaveChangesAsync();

                    return position;
                }
            }

            return null;
        }
    }
}
