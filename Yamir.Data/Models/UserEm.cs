using Yamir.Data.Abstraction;
using Yamir.Data.Enums;

namespace Yamir.Data.Models
{
    public class UserEm : AuditableEntity
    {
        public required string Email { get; set; }

        public required string Password { get; set; }

        public UserType UserType { get; set; }
    }
}
