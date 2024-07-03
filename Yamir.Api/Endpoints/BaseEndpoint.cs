using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Yamir.Api.Endpoints
{
    public static class BaseEndpoint
    {
        public static void MapCrudEndpoints<TGetQuery, TListQuery, TCreateCommand, TUpdateCommand,
            TDeleteCommand>(this IEndpointRouteBuilder app, string baseRoute)
        {
            app.MapGet($"{baseRoute}/get", async ([AsParameters] TGetQuery query, IMediator mediator) =>
            {
                if (query == null)
                {
                    return Results.BadRequest();
                }

                var result = await mediator.Send(query);
                return Results.Ok(result);
            }).WithTags(baseRoute);

            app.MapGet($"{baseRoute}/list", async ([AsParameters] TListQuery query, IMediator mediator) =>
            {
                if (query == null)
                {
                    return Results.BadRequest();
                }

                var result = await mediator.Send(query);
                return Results.Ok(result);
            }).WithTags(baseRoute);

            app.MapPost($"{baseRoute}/create", async ([FromBody] TCreateCommand command, IMediator mediator) =>
            {
                if (command == null)
                {
                    return Results.BadRequest();
                }

                var result = await mediator.Send(command);
                return Results.Ok(result);
            }).WithTags(baseRoute);

            app.MapPut($"{baseRoute}/update", async ([FromBody] TUpdateCommand command, IMediator mediator) =>
            {
                if (command == null)
                {
                    return Results.BadRequest();
                }

                await mediator.Send(command);
                return Results.Ok();
            }).WithTags(baseRoute);

            app.MapDelete($"{baseRoute}/delete", async ([FromBody] TDeleteCommand command, IMediator mediator) =>
            {
                if (command == null)
                {
                    return Results.BadRequest();
                }

                await mediator.Send(command);
                return Results.Ok();
            }).WithTags(baseRoute);
        }
    }
}
