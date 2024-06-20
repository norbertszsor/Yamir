using MediatR;
using Microsoft.AspNetCore.Mvc;
using Yamir.Transfer.Region.Command;
using Yamir.Transfer.Region.Query;

namespace Yamir.Api.Endpoints
{
    public static class RegionEndpoint
    {
        private const string GetRegion = "api/region/get";
        private const string GetRegionList = "api/region/list";
        private const string CreateRegion = "api/region/create";
        private const string UpdateRegion = "api/region/update}";
        private const string DeleteRegion = "api/region/delete";

        public static void MapRegionEndpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet(GetRegion, async (IMediator mediator, [AsParameters] GetRegionQuery query) =>
            {
                var result = await mediator.Send(query);

                return Results.Ok(result);
            });

            app.MapGet(GetRegionList, async (IMediator mediator, [AsParameters] GetRegionListQuery query) =>
            {
                var result = await mediator.Send(query);

                return Results.Ok(result);
            });

            app.MapPost(CreateRegion, async (IMediator mediator, [FromBody] CreateRegionCommand command) =>
            {
                var result = await mediator.Send(command);

                return Results.Ok(result);
            });

            app.MapPut(UpdateRegion, async (IMediator mediator, [FromBody] UpdateRegionCommand command) =>
            {
                await mediator.Send(command);

                return Results.Ok();
            });

            app.MapDelete(DeleteRegion, async (IMediator mediator, [FromBody] DeleteRegionCommand command) =>
            {
                await mediator.Send(command);

                return Results.Ok();
            });
        }
    }
}
