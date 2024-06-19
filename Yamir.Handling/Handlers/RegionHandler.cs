using Yamir.Handling.Abstraction;
using Yamir.Shared.Abstraction;
using Yamir.Transfer.Region.Command;
using Yamir.Transfer.Region.Data;
using Yamir.Transfer.Region.Query;

namespace Yamir.Handling.Handlers
{
    public class RegionHandler : IQueryHandler<GetRegionQuery, RegionDto>,
        ISearchQueryHandler<GetRegionListQuery, RegionDto>,
        ICommandHandler<CreateRegionCommand, RegionDto>,
        ICommandHandler<UpdateRegionCommand>,
        ICommandHandler<DeleteRegionCommand>
    {
        public Task<RegionDto> Handle(GetRegionQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IPagedList<RegionDto>> Handle(GetRegionListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<RegionDto> Handle(CreateRegionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Handle(UpdateRegionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Handle(DeleteRegionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
