using Yamir.Data.Enums;
using Yamir.Shared.Abstraction;
using Yamir.Transfer.Tree.Data;

namespace Yamir.Transfer.Tree.Command
{
    public class CreateTreeCommand : ICommand<TreeDto>
    {
        public required string Name { get; set; }

        public string? Description { get; set; }

        public TreeType Type { get; set; }

        public required Guid RegionId { get; set; }
    }
}
