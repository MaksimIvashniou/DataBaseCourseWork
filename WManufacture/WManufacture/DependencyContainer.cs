using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WManufacture.Infrastructure.Databases;
using WManufacture.Infrastructure.Services.Employees;

namespace WManufacture
{
    public static class DependencyContainer
    {
        public static void RegistrationOfDependency(
           this IServiceCollection services,
           IConfiguration configuration)
        {
            services.AddDbContext<WManufactureContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DbConnection"),
                    builder => builder.EnableRetryOnFailure()));

            #region Services

            services.AddTransient<IEmployeeService, EmployeeService>();

            #endregion
        }
    }
}
