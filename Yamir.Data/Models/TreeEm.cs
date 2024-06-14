using Yamir.Data.Abstraction;
using Yamir.Data.Enums;

namespace Yamir.Data.Models
{
    public class TreeEm : AuditableEntity
    {
        public required string Name { get; set; }

        public string? Description { get; set; }

        public TreeType Type { get; set; }

        public required Guid RegionId { get; set; }

        public required RegionEm Region { get; set; }

        public ICollection<BinaryFileEm>? Images { get; set; }
    }
}
