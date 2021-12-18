using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.Employees;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.Employees
{
    public class EmployeeService : IEmployeeService
    {
        private readonly WManufactureContext _db;

        private readonly ILogger<EmployeeService> _logger;

        public EmployeeService(
            WManufactureContext db,
            ILogger<EmployeeService> logger)
        {
            _db = db;
            _logger = logger;
        }

        public async Task<Employee> CreateAsync(Employee data)
        {
            if (data.Id <= 0)
            {
                if (!await _db.Employees.AnyAsync(employee => employee.Login.Equals(data.Login)))
                {
                    _db.Employees.Add(data);

                    await _db.SaveChangesAsync();

                    return data;
                }
            }

            return null;
        }

        public async Task DeleteAsync(int id)
        {
            var employee = await _db.Employees.FindAsync(id);

            if (employee != null)
            {
                _db.Employees.Remove(employee);

                await _db.SaveChangesAsync();
            }
        }

        public Task<List<Employee>> GetAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Employee> GetAsync(int id)
        {
            var employee = await _db.Employees.FindAsync(id);

            return employee;
        }

        public async Task<Employee> UpdateAsync(
            int id, 
            Employee data)
        {
            if (id == data.Id)
            {
                var employee = await _db.Employees.FindAsync(id);

                if (employee != null)
                {
                    //

                    return employee;
                }
            }

            return null;
        }
    }
}
