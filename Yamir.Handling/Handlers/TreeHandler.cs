using Yamir.Handling.Abstraction;
using Yamir.Shared.Abstraction;
using Yamir.Transfer.Tree.Command;
using Yamir.Transfer.Tree.Data;
using Yamir.Transfer.Tree.Query;

namespace Yamir.Handling.Handlers
{
    public class TreeHandler : IQueryHandler<GetTreeQuery, TreeDto>,
        ISearchQueryHandler<GetTreeListQuery, TreeDto>,
        ICommandHandler<CreateTreeCommand, TreeDto>,
        ICommandHandler<UpdateTreeCommand>,
        ICommandHandler<DeleteTreeCommand>
    {
        public Task<TreeDto> Handle(GetTreeQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IPagedList<TreeDto>> Handle(GetTreeListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<TreeDto> Handle(CreateTreeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Handle(UpdateTreeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Handle(DeleteTreeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
