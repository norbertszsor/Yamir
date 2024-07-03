using Mapster;
using Microsoft.EntityFrameworkCore;
using Yamir.Data.Models;
using Yamir.Handling.Abstraction;
using Yamir.Infrastructure.Abstraction;
using Yamir.Transfer.Tree.Command;
using Yamir.Transfer.Tree.Data;

namespace Yamir.Handling.Handlers.Tree
{
    public class TreeCommandHandler(IStorage storage) : ICommandHandler<CreateTreeCommand, TreeDto>,
        ICommandHandler<UpdateTreeCommand>,
        ICommandHandler<DeleteTreeCommand>
    {
        public async Task<TreeDto> Handle(CreateTreeCommand request, CancellationToken cancellationToken)
        {
            var mappedTree = request.Adapt<TreeEm>();

            var id = await storage.InsertAsync(mappedTree);

            var result = await storage.Trees.Where(x => x.Id == id)
                .ProjectToType<TreeDto>()
                .FirstOrDefaultAsync(cancellationToken);

            if (result == null)
            {
                throw new Exception("Tree not created");
            }

            return result;
        }

        public async Task Handle(UpdateTreeCommand request, CancellationToken cancellationToken)
        {
            var tree = await storage.Trees.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (tree == null)
            {
                throw new Exception("Tree not found");
            }

            var mappedEntity = request.Adapt(tree);

            await storage.UpdateAsync(mappedEntity);
        }

        public async Task Handle(DeleteTreeCommand request, CancellationToken cancellationToken)
        {
            var tree = await storage.Trees.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (tree == null)
            {
                throw new Exception("Tree not found");
            }

            await storage.DeleteAsync<TreeEm>(request.Id);
        }
    }

}
