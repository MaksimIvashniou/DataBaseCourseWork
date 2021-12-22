using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.Employees;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.Permissions
{
    public class PermissionService : IPermissionService
    {
        private readonly WManufactureContext _db;

        public PermissionService(WManufactureContext db)
        {
            _db = db;
        }

        public async Task<Permission> CreateAsync(Permission data)
        {
            if (data.Id <= 0)
            {
                if (!await _db.Permissions.AnyAsync(permission => permission.Name.Equals(data.Name)))
                {
                    _db.Permissions.Add(data);

                    await _db.SaveChangesAsync();

                    return data;
                }
            }

            return null;
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

        public async Task<Permission> UpdateAsync(
            int id, 
            Permission data)
        {
            if (id == data.Id)
            {
                var permission = await _db.Permissions.FindAsync(id);

                if (permission != null)
                {
                    permission.Name = data.Name;

                    _db.Update(permission);

                    await _db.SaveChangesAsync();

                    return permission;
                }
            }

            return null;
        }
    }
}
