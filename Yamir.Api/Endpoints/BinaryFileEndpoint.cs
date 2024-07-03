using Yamir.Transfer.BinaryFile.Command;
using Yamir.Transfer.BinaryFile.Query;

namespace Yamir.Api.Endpoints
{
    public static class BinaryFileEndpoint
    {
        private const string BaseRoute = "api/binaryfile";

        public static void MapBinaryFileEndpoint(this IEndpointRouteBuilder app)
        {
            app.MapCrudEndpoints<GetBinaryFileQuery, GetBinaryFileListQuery, CreateBinaryFileCommand,
                UpdateBinaryFileCommand, DeleteBinaryFileCommand>(BaseRoute);
        }
    }
}
