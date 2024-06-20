using Microsoft.AspNetCore.Http;
using Yamir.Shared.Abstraction;

namespace Yamir.Transfer.BinaryFile.Command
{
    public class UpdateBinaryFileCommand : ICommand
    {
        public Guid Id { get; set; }

        public required IFormFile File { get; set; }
    }
}
