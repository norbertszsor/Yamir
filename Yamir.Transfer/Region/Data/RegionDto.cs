using Yamir.Data.Models;

namespace Yamir.Transfer.Region.Data
{
    public class RegionDto
    {
        public required string Name { get; set; }

        public required string Country { get; set; }

        public string? Description { get; set; }

        public string? CountryCode { get; set; }

        public ICollection<TreeEm>? Trees { get; set; }
    }
}
