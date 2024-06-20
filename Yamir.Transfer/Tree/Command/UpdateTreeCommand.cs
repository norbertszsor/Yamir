using Yamir.Data.Enums;
using Yamir.Shared.Abstraction;

namespace Yamir.Transfer.Tree.Command
{
    public class UpdateTreeCommand : ICommand
    {
        public required Guid Id { get; set; }

        public required string Name { get; set; }

        public string? Description { get; set; }

        public TreeType Type { get; set; }

        public required Guid RegionId { get; set; }
    }
}
