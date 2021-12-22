using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.Employees;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.Employees.Permissions
{
    public class PermissionService : IPermissionService
    {
        private readonly WManufactureContext _db;

        private readonly ILogger<PermissionService> _logger;

        public PermissionService(
            WManufactureContext db,
            ILogger<PermissionService> logger)
        {
            _db = db;

            _logger = logger;
        }

        public async Task CreateAsync(Permission data)
        {
            if (data.Id == 0)
            {
                if (!await _db.Permissions.AnyAsync(permission => permission.Name.Equals(data.Name)))
                {
                    _db.Permissions.Add(data);

                    await _db.SaveChangesAsync();
                }
            }
        }

        public async Task DeleteAsync(int id)
        {
            var permission = await _db.Permissions.FindAsync(id);

            if (permission != null)
            {
                _db.Permissions.Remove(permission);

                await _db.SaveChangesAsync();
            }
        }

        public async Task<Permission> GetAsync(int id)
        {
            var permission = await _db.Permissions.FindAsync(id);

            return permission;
        }

        public async Task UpdateAsync(
            int id, 
            Permission data)
        {
            if (data != null 
                && data.Id == id)
            {
                var permission = await _db.Permissions.FindAsync(id);

                if (permission != null
                    && !await _db.Permissions.AnyAsync(permission => permission.Name.Equals(data.Name)))
                {
                    permission.Name = data.Name;

                    _db.Update(permission);

                    await _db.SaveChangesAsync();
                }
            }
        }
    }
}
