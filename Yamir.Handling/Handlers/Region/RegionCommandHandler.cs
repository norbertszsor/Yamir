using Yamir.Handling.Abstraction;
using Yamir.Transfer.Region.Command;
using Yamir.Transfer.Region.Data;

namespace Yamir.Handling.Handlers.Region
{
    public class RegionCommandHandler : ICommandHandler<CreateRegionCommand, RegionDto>,
        ICommandHandler<UpdateRegionCommand>,
        ICommandHandler<DeleteRegionCommand>
    {
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
