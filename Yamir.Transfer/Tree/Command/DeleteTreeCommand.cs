using Yamir.Shared.Abstraction;

namespace Yamir.Transfer.Tree.Command
{
    public class DeleteTreeCommand : ICommand
    {
        public required Guid Id { get; set; }
    }
}
