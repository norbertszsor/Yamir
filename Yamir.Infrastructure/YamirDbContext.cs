using Microsoft.EntityFrameworkCore;
using Yamir.Data.Models;

namespace Yamir.Infrastructure
{
    public class YamirDbContext(DbContextOptions<YamirDbContext> options) : DbContext(options)
    {
        public required DbSet<UserEm> Users { get; set; }

        public required DbSet<CustomerEm> Customers { get; set; }

        public required DbSet<CartEm> Carts { get; set; }

        public required DbSet<CartItemEm> CartItems { get; set; }

        public required DbSet<BillingEm> Billings { get; set; }

        public required DbSet<TreeEm> Trees { get; set; }

        public required DbSet<RegionEm> Regions { get; set; }
    }
}
