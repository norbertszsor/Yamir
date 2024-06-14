using Yamir.Data.Abstraction;

namespace Yamir.Data.Models
{
    public class RegionEm : Entity
    {
        public required string Name { get; set; }

        public required string Country { get; set; }

        public string? Description { get; set; }

        public string? CountryCode { get; set; }

        public ICollection<TreeEm>? Trees { get; set; }
    }
}
