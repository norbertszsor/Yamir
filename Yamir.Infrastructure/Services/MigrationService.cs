using Microsoft.EntityFrameworkCore;
using Yamir.Infrastructure.Abstraction;

namespace Yamir.Infrastructure.Services
{
    public class MigrationService(YamirDbContext context) : IMigrationService
    {
        public async Task MigrateAsync()
        {
            await context.Database.MigrateAsync();
        }
    }
}
