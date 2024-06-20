using MediatR;
using Microsoft.AspNetCore.Mvc;
using Yamir.Transfer.BinaryFile.Command;
using Yamir.Transfer.BinaryFile.Query;

namespace Yamir.Api.Endpoints
{
    public static class BinaryFileEndpoint
    {
        public const string GetBinaryFile = "api/binary-file/get";
        public const string GetBinaryFileList = "api/binary-file/list";
        public const string CreateBinaryFile = "api/binary-file/create";
        public const string UpdateBinaryFile = "api/binary-file/update";
        public const string DeleteBinaryFile = "api/binary-file/delete";

        public static void MapBinaryFileEndpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet(GetBinaryFile, async (IMediator mediator, [AsParameters] GetBinaryFileQuery query) =>
            {
                var result = await mediator.Send(query);

                return Results.Ok(result);
            });

            app.MapGet(GetBinaryFileList, async (IMediator mediator, [AsParameters] GetBinaryFileListQuery query) =>
            {
                var result = await mediator.Send(query);

                return Results.Ok(result);
            });

            app.MapPost(CreateBinaryFile, async (IMediator mediator, [FromBody] CreateBinaryFileCommand command) =>
            {
                var result = await mediator.Send(command);

                return Results.Ok(result);
            });

            app.MapPut(UpdateBinaryFile, async (IMediator mediator, [FromBody] UpdateBinaryFileCommand command) =>
            {
                await mediator.Send(command);

                return Results.Ok();
            });

            app.MapDelete(DeleteBinaryFile, async (IMediator mediator, [FromBody] DeleteBinaryFileCommand command) =>
            {
                await mediator.Send(command);

                return Results.Ok();
            });
        }
    }
}
