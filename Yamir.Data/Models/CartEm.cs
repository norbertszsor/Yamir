using Yamir.Data.Abstraction;

namespace Yamir.Data.Models
{
    public class CartEm : AuditableEntity
    {
        public ICollection<CartItemEm>? CartItems { get; set; }
    }
}
