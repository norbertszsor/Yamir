using MediatR;


namespace Yamir.Shared.Abstraction
{
    public interface IQuery : IRequest
    {
    }

    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }

    public abstract class PagedQuery<TResponse> : IQuery<IPagedList<TResponse>>
    {
        public int? PageIndex { get; }

        public int? PageSize { get; }
    }

    public abstract class SortQuery<TResponse> : SearchQuery<TResponse>
    {
        public string? Sort { get; }

        public string? Order { get; }
    }

    public abstract class SearchQuery<TResponse> : PagedQuery<TResponse>
    {
        public string? Search { get; }

        public string[]? Fields { get; }
    }
}