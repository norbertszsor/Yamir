using Yamir.Handling.Extensions;
using Yamir.Infrastructure.Extensions;

namespace Yamir.Api.IoC
{
    public static class ServiceContainer
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddYamirDbContext(configuration);

            services.AddInfrastructure();

            services.AddHandling();

            return services;
        }
    }
}
