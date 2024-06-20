using Yamir.Shared.Abstraction;

namespace Yamir.Transfer.Region.Command
{
    public class DeleteRegionCommand : ICommand
    {
        public Guid Id { get; set; }
    }
}
