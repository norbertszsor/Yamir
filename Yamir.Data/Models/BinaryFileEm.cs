﻿using Yamir.Data.Abstraction;
using Yamir.Data.Enums;

namespace Yamir.Data.Models
{
    public class BinaryFileEm : AuditableEntity
    {
        public required string FileName { get; set; }

        public required string ContentType { get; set; }

        public required string Extension { get; set; }

        public required byte[] Content { get; set; }

        public FileType Type { get; set; }
    }
}
