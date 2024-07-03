using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Yamir.Infrastructure.Abstraction;
using Yamir.Infrastructure.Services;

namespace Yamir.Infrastructure.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddYamirDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<YamirDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });

            return services;
        }

        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IReadOnlyStorage, ReadOnlyStorage>();
            services.AddScoped<IStorage, Storage>();
            services.AddScoped<IMigrationService, MigrationService>();

            return services;
        }
    }
}
