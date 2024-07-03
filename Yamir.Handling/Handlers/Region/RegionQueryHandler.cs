using Yamir.Handling.Abstraction;
using Yamir.Shared.Abstraction;
using Yamir.Transfer.Region.Data;
using Yamir.Transfer.Region.Query;

namespace Yamir.Handling.Handlers.Region
{
    public class RegionQueryHandler : IQueryHandler<GetRegionQuery, RegionDto>,
        ISearchQueryHandler<GetRegionListQuery, RegionDto>
    {
        public Task<RegionDto> Handle(GetRegionQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IPagedList<RegionDto>> Handle(GetRegionListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
