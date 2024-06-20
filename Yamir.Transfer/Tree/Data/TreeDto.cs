using Yamir.Data.Enums;
using Yamir.Data.Models;

namespace Yamir.Transfer.Tree.Data
{
    public class TreeDto
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public string? Description { get; set; }

        public TreeType Type { get; set; }

        public required Guid RegionId { get; set; }

        public required RegionEm Region { get; set; }

        public ICollection<BinaryFileEm>? Images { get; set; }
    }
}
