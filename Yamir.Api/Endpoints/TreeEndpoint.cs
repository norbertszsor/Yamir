using Yamir.Transfer.Tree.Command;
using Yamir.Transfer.Tree.Query;

namespace Yamir.Api.Endpoints
{
    public static class TreeEndpoint
    {
        private const string BaseRoute = "api/tree";

        public static void MapTreeEndpoint(this IEndpointRouteBuilder app)
        {
            app.MapCrudEndpoints<GetTreeQuery, GetTreeListQuery, CreateTreeCommand, UpdateTreeCommand,
                DeleteTreeCommand>(BaseRoute);
        }
    }
}
