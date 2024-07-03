using Yamir.Handling.Abstraction;
using Yamir.Shared.Abstraction;
using Yamir.Transfer.Tree.Data;
using Yamir.Transfer.Tree.Query;

namespace Yamir.Handling.Handlers.Tree
{
    public class TreeQueryHandler : IQueryHandler<GetTreeQuery, TreeDto>,
        ISearchQueryHandler<GetTreeListQuery, TreeDto>
    {
        public Task<TreeDto> Handle(GetTreeQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IPagedList<TreeDto>> Handle(GetTreeListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
