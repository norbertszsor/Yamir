using Yamir.Data.Abstraction;

namespace Yamir.Data.Models
{
    public class BillingEm : Entity
    {
        public required string Name { get; set; }

        public required string Address { get; set; }

        public required string City { get; set; }

        public required string State { get; set; }

        public required string Zip { get; set; }

        public required string Country { get; set; }

        public required string Phone { get; set; }

        public required string Email { get; set; }

        public Guid? UserId { get; set; }

        public UserEm? User { get; set; }
    }
}
