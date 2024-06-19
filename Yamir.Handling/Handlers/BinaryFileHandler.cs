using Yamir.Handling.Abstraction;
using Yamir.Shared.Abstraction;
using Yamir.Transfer.BinaryFile.Command;
using Yamir.Transfer.BinaryFile.Data;
using Yamir.Transfer.BinaryFile.Query;

namespace Yamir.Handling.Handlers
{
    public class BinaryFileHandler : IQueryHandler<GetBinaryFileQuery, BinaryFileDto>,
        ISearchQueryHandler<GetBinaryFileListQuery, BinaryFileDto>,
        ICommandHandler<CreateBinaryFileCommand, BinaryFileDto>,
        ICommandHandler<UpdateBinaryFileCommand>,
        ICommandHandler<DeleteBinaryFileCommand>
    {
        public Task<BinaryFileDto> Handle(GetBinaryFileQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IPagedList<BinaryFileDto>> Handle(GetBinaryFileListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<BinaryFileDto> Handle(CreateBinaryFileCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Handle(UpdateBinaryFileCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Handle(DeleteBinaryFileCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
