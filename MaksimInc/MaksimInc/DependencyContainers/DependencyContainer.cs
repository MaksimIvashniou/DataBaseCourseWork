using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MaksimInc.DependencyContainers
{
    public static class DependencyContainer
    {
        public static void RegistrationOfDependency(
           this IServiceCollection services,
           IConfiguration configuration)
        {
            services.PManufactureDependency(configuration);

            services.WManufactureDependency(configuration);
        }
    }
}
