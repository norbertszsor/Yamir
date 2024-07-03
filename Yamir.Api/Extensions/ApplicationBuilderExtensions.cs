using Yamir.Infrastructure.Abstraction;

namespace Yamir.Api.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static async Task MigrateAsync(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();

            var migrationService = scope.ServiceProvider.GetRequiredService<IMigrationService>();

            await migrationService.MigrateAsync();
        }

        public static void Migrate(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();

            var migrationService = scope.ServiceProvider.GetRequiredService<IMigrationService>();

            migrationService.MigrateAsync().Wait();
        }
    }
}
