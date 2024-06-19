using Yamir.Data.Abstraction;
using Yamir.Data.Models;

namespace Yamir.Infrastructure.Abstraction;

public interface IStorage
{
    IQueryable<UserEm> Users { get; }

    IQueryable<CustomerEm> Customers { get; }

    IQueryable<CartEm> Carts { get; }

    IQueryable<CartItemEm> CartItems { get; }

    IQueryable<BillingEm> Billings { get; }

    IQueryable<TreeEm> Trees { get; }

    IQueryable<RegionEm> Regions { get; }

    Task<int> SaveChangesAsync();

    Task<Guid> InsertAsync<T>(T entity) where T : Entity;

    Task InsertRangeAsync<T>(IEnumerable<T> entities) where T : Entity;

    Task UpdateAsync<T>(T entity) where T : Entity;

    Task UpdateRangeAsync<T>(IEnumerable<T> entities) where T : Entity;

    Task<bool> DeleteAsync<T>(Guid id) where T : Entity;

    Task<bool> DeleteAsync<T>(T entity) where T : Entity;
}