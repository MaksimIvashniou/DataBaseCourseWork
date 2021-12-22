using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WManufacture.Infrastructure.Databases;
using WManufacture.Infrastructure.Services.Companies;
using WManufacture.Infrastructure.Services.Employees;
using WManufacture.Infrastructure.Services.WeldingMachines;
using WManufacture.Infrastructure.Services.WorkObjects;
using WManufacture.Infrastructure.Services.WorkObjects.BookingWorkObjectTasks;
using WManufacture.Infrastructure.Services.WeldingMachines.ModelCharacteristics;
using WManufacture.Infrastructure.Services.WeldingMachines.ModelOfWeldingMachines;
using WManufacture.Infrastructure.Services.Employees.Permissions;
using WManufacture.Infrastructure.Services.Employees.PersonalInfos;
using WManufacture.Infrastructure.Services.WorkObjects.WorkObjectResults;
using WManufacture.Infrastructure.Services.WorkObjects.WorkObjectTaskResults;
using WManufacture.Infrastructure.Services.WorkObjects.WorkObjectTasks;
using WManufacture.Infrastructure.Services.Employees.Positions;

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

            services.AddTransient<ICompanyService, CompanyService>();

            services.AddTransient<IWorkObjectService, WorkObjectService>();

            services.AddTransient<IWeldingMachineService, WeldingMachineService>();

            services.AddTransient<IBookingWorkObjectTaskService, BookingWorkObjectTaskService>();

            services.AddTransient<IModelCharacteristicService, ModelCharacteristicService>();
            
            services.AddTransient<IModelOfWeldingMachineService, ModelOfWeldingMachineService>();
            
            services.AddTransient<IPermissionService, PermissionService>();

            services.AddTransient<IPersonalInfoService, PersonalInfoService>();

            services.AddTransient<IPositionService, PositionService>();
            
            services.AddTransient<IWorkObjectResultService, WorkObjectResultService>();

            services.AddTransient<IWorkObjectTaskResultService, WorkObjectTaskResultService>();

            services.AddTransient<IWorkObjectTaskService, WorkObjectTaskService>();

            #endregion
        }
    }
}
