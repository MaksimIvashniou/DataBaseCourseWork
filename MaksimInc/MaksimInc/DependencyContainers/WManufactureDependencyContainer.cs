using MaksimInc.Infrastructure.Databases;
using MaksimInc.Infrastructure.Services.WManufacture.Branches;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MaksimInc
{
    public static class WManufactureDependencyContainer
    {
        public static void WManufactureDependency(
           this IServiceCollection services,
           IConfiguration configuration)
        {
            services.AddDbContext<WManufactureContext>(options =>
                 options.UseSqlServer(
                     configuration.GetConnectionString("WManufactureDbConnection"),
                     builder => builder.EnableRetryOnFailure()));

            #region Services

            services.AddTransient<IBranchService, BranchService>();

            #endregion
        }
    }
}
