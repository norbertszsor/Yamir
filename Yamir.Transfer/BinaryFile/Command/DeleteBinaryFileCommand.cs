﻿using Yamir.Shared.Abstraction;

namespace Yamir.Transfer.BinaryFile.Command
{
    public class DeleteBinaryFileCommand : ICommand
    {
        public Guid Id { get; set; }
    }
}
