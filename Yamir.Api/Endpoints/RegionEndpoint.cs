using Yamir.Transfer.Region.Command;
using Yamir.Transfer.Region.Query;

namespace Yamir.Api.Endpoints
{
    public static class RegionEndpoint
    {
        private const string BaseRoute = "api/region";

        public static void MapRegionEndpoint(this IEndpointRouteBuilder app)
        {
            app.MapCrudEndpoints<GetRegionQuery, GetRegionListQuery, CreateRegionCommand, UpdateRegionCommand,
                DeleteRegionCommand>(BaseRoute);
        }
    }
}
