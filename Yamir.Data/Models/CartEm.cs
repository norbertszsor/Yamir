using Yamir.Data.Abstraction;

namespace Yamir.Data.Models
{
    public class CartEm : AuditableEntity
    {
        public ICollection<CartItem>? CartItems { get; set; }
    }
}
