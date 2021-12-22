using System.Collections.Generic;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.Employees;

namespace WManufacture.Infrastructure.Services.Employees
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAsync();

        Task<Employee> GetAsync(int id);

        Task CreateAsync(Employee data);

        Task UpdateAsync(
            int id,
            Employee data);

        Task DeleteAsync(int id);
    }
}
