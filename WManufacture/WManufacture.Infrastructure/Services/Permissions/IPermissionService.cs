﻿using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.Employees;

namespace WManufacture.Infrastructure.Services.Permissions
{
    public interface IPermissionService
    {
        Task<Permission> GetAsync(int id);

        Task<Permission> CreateAsync(Permission data);

        Task<Permission> UpdateAsync(
            int id,
            Permission data);

        Task DeleteAsync(int id);
    }
}
