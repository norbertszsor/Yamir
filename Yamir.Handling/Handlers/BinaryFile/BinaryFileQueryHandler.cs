using Yamir.Handling.Abstraction;
using Yamir.Shared.Abstraction;
using Yamir.Transfer.BinaryFile.Command;
using Yamir.Transfer.BinaryFile.Data;
using Yamir.Transfer.BinaryFile.Query;

namespace Yamir.Handling.Handlers.BinaryFile
{
    public class BinaryFileQueryHandler : IQueryHandler<GetBinaryFileQuery, BinaryFileDto>,
        ISearchQueryHandler<GetBinaryFileListQuery, BinaryFileDto>
    {
        public Task<BinaryFileDto> Handle(GetBinaryFileQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IPagedList<BinaryFileDto>> Handle(GetBinaryFileListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
