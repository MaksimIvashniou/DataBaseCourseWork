using System.Collections.Generic;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.Employees;

namespace WManufacture.Infrastructure.Services.Employees
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAsync();

        Task<Employee> GetAsync(int id);

        Task<Employee> CreateAsync(Employee data);

        Task<Employee> UpdateAsync(
            int id,
            Employee data);

        Task DeleteAsync(int id);
    }
}
