using Yamir.Data.Abstraction;
using Yamir.Data.Enums;

namespace Yamir.Data.Models
{
    public class BillingEm : AuditableEntity
    {
        public required Guid CartId { get; set; }

        public required Guid CustomerId { get; set; }

        public required CartEm Cart { get; set; }

        public required CustomerEm Customer { get; set; }

        public decimal Value { get; set; }

        public decimal Tax { get; set; }

        public decimal? Shipping { get; set; }

        public decimal? Discount { get; set; }

        public decimal Total { get; set; }

        public BillingStatus Status { get; set; }
    }
}
