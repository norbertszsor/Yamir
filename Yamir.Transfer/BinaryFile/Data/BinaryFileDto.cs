using Yamir.Data.Enums;

namespace Yamir.Transfer.BinaryFile.Data
{
    public class BinaryFileDto
    {
        public required string FileName { get; set; }

        public required string ContentType { get; set; }

        public required string Extension { get; set; }

        public required byte[] Content { get; set; }

        public FileType Type { get; set; }
    }
}
