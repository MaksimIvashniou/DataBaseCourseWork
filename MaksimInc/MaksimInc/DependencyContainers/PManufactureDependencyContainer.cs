using MaksimInc.Infrastructure.Databases;
using MaksimInc.Infrastructure.Services.PManufacture.Branches;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MaksimInc
{
    public static class PManufactureDependencyContainer
    {
        public static void PManufactureDependency(
           this IServiceCollection services,
           IConfiguration configuration)
        {
            services.AddDbContext<PManufactureContext>(options =>
                 options.UseSqlServer(
                     configuration.GetConnectionString("PManufactureDbConnection"),
                     builder => builder.EnableRetryOnFailure()));

            #region Services

            services.AddTransient<IBranchService, BranchService>();

            #endregion
        }
    }
}
