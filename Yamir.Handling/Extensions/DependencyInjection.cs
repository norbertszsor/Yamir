using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Yamir.Handling.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddHandling(this IServiceCollection services)
        {
            services.AddMediatR(options =>
            {
                options.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                options.Lifetime = ServiceLifetime.Scoped;
            });

            return services;
        }

        public static IApplicationBuilder UseHandling(this IApplicationBuilder app)
        {
            return app;
        }
    }
}
