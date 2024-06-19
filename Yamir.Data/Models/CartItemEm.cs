using Yamir.Data.Abstraction;

namespace Yamir.Data.Models
{
    public class CartItemEm : Entity
    {
        public required int Quantity { get; set; }

        public required Guid CartId { get; set; }

        public required Guid TreeId { get; set; }

        public required TreeEm Tree { get; set; }

        public required CartEm Cart { get; set; }
    }
}
