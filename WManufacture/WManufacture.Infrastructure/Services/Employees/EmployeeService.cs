using Microsoft.Extensions.Logging;
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
    }
}
