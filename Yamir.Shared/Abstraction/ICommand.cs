using MediatR;

namespace Yamir.Shared.Abstraction
{
    public interface ICommand : IRequest
    {
    }

    public interface ICommand<out T> : IRequest<T>
    {
    }
}
