using Microsoft.AspNetCore.Http;
using Yamir.Shared.Abstraction;
using Yamir.Transfer.BinaryFile.Data;

namespace Yamir.Transfer.BinaryFile.Command
{
    public record CreateBinaryFileCommand(IFormFile File) : ICommand<BinaryFileDto>
    {
        public required IFormFile File { get; set; }
    }
}
