using Yamir.Handling.Abstraction;
using Yamir.Transfer.BinaryFile.Command;
using Yamir.Transfer.BinaryFile.Data;

namespace Yamir.Handling.Handlers.BinaryFile
{
    public class BinaryFileCommandHandler : ICommandHandler<CreateBinaryFileCommand, BinaryFileDto>,
        ICommandHandler<UpdateBinaryFileCommand>,
        ICommandHandler<DeleteBinaryFileCommand>
    {
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
