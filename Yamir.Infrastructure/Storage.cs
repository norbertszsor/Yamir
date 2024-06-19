using Yamir.Data.Abstraction;
using Yamir.Data.Models;
using Yamir.Infrastructure.Abstraction;

namespace Yamir.Infrastructure
{
    public class Storage(YamirDbContext context) : IStorage
    {
        public IQueryable<UserEm> Users => context.Users;

        public IQueryable<CustomerEm> Customers => context.Customers;

        public IQueryable<CartEm> Carts => context.Carts;

        public IQueryable<CartItemEm> CartItems => context.CartItems;

        public IQueryable<BillingEm> Billings => context.Billings;

        public IQueryable<TreeEm> Trees => context.Trees;

        public IQueryable<RegionEm> Regions => context.Regions;

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }

        public async Task<Guid> InsertAsync<T>(T entity) where T : Entity
        {
            await context.AddAsync(entity);
            
            await SaveChangesAsync();
            
            return entity.Id;
        }

        public async Task InsertRangeAsync<T>(IEnumerable<T> entities) where T : Entity
        {
            await context.AddRangeAsync(entities);
            
            await SaveChangesAsync();
        }

        public async Task UpdateAsync<T>(T entity) where T : Entity
        {
            context.Update(entity);
            
            await SaveChangesAsync();
        }

        public async Task UpdateRangeAsync<T>(IEnumerable<T> entities) where T : Entity
        {
            context.UpdateRange(entities);
            
            await SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync<T>(Guid id) where T : Entity
        {
            var entity = await context.FindAsync<T>(id);

            if (entity == null)
            {
                return false;
            }
            
            context.Remove(entity);
            
            await SaveChangesAsync();
            
            return true;
        }

        public async Task<bool> DeleteAsync<T>(T entity) where T : Entity
        {
            context.Remove(entity);
            
            await SaveChangesAsync();
            
            return true;
        }
    }
}
