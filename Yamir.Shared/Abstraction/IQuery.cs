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
        public int? PageIndex { get; set; }

        public int? PageSize { get; set; }
    }

    public abstract class SortQuery<TResponse> : PagedQuery<TResponse>
    {
        public string? Sort { get; set; }

        public string? Order { get; set; }
    }

    public abstract class SearchQuery<TResponse> : SortQuery<TResponse>
    {
        public string? Search { get; set; }

        public string[]? Fields { get; set; }
    }
}