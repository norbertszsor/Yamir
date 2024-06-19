using Yamir.Data.Models;

namespace Yamir.Infrastructure.Abstraction;

public interface IReadOnlyStorage
{
    IQueryable<UserEm> Users { get; }

    IQueryable<CustomerEm> Customers { get; }

    IQueryable<CartEm> Carts { get; }

    IQueryable<CartItemEm> CartItems { get; }

    IQueryable<BillingEm> Billings { get; }

    IQueryable<TreeEm> Trees { get; }

    IQueryable<RegionEm> Regions { get; }
}