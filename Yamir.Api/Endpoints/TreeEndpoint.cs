using MediatR;
using Microsoft.AspNetCore.Mvc;
using Yamir.Transfer.Tree.Command;
using Yamir.Transfer.Tree.Query;

namespace Yamir.Api.Endpoints
{
    public static class TreeEndpoint
    {
        private const string GetTreeRoute = "/api/tree/get";
        private const string GetTreeListRoute = "/api/tree/list";
        private const string CreateTreeRoute = "/api/tree/create";
        private const string UpdateTreeRoute = "/api/tree/update";
        private const string DeleteTreeRoute = "/api/tree/delete";

        public static void MapTreeEndpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet(GetTreeRoute, async (IMediator mediator, [AsParameters] GetTreeQuery query) =>
            {
                var result = await mediator.Send(query);

                return Results.Ok(result);
            });

            app.MapGet(GetTreeListRoute, async (IMediator mediator, [AsParameters] GetTreeListQuery query) =>
            {
                var result = await mediator.Send(query);

                return Results.Ok(result);
            });

            app.MapPost(CreateTreeRoute, async (IMediator mediator, [FromBody] CreateTreeCommand command) =>
            {
                var result = await mediator.Send(command);

                return Results.Ok(result);
            });

            app.MapPut(UpdateTreeRoute, async (IMediator mediator, [FromBody] UpdateTreeCommand command) =>
            {
                await mediator.Send(command);

                return Results.Ok();
            });

            app.MapDelete(DeleteTreeRoute, async (IMediator mediator, [FromBody] DeleteTreeCommand command) =>
            {
                await mediator.Send(command);

                return Results.Ok();
            });
        }
    }
}
