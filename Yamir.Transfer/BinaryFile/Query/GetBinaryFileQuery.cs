using Yamir.Shared.Abstraction;
using Yamir.Transfer.BinaryFile.Data;

namespace Yamir.Transfer.BinaryFile.Query
{
    public class GetBinaryFileQuery : IQuery<BinaryFileDto>
    {
        public Guid Id { get; set; }
    }
}
