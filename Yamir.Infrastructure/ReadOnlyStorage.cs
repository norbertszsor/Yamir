using Microsoft.EntityFrameworkCore;
using Yamir.Data.Models;
using Yamir.Infrastructure.Abstraction;

namespace Yamir.Infrastructure
{
    public class ReadOnlyStorage(YamirDbContext context) : IReadOnlyStorage
    {
        public IQueryable<UserEm> Users => context.Users.AsNoTracking();

        public IQueryable<CustomerEm> Customers => context.Customers.AsNoTracking();

        public IQueryable<CartEm> Carts => context.Carts.AsNoTracking();

        public IQueryable<CartItemEm> CartItems => context.CartItems.AsNoTracking();

        public IQueryable<BillingEm> Billings => context.Billings.AsNoTracking();

        public IQueryable<TreeEm> Trees => context.Trees.AsNoTracking();

        public IQueryable<RegionEm> Regions => context.Regions.AsNoTracking();
    }
}
