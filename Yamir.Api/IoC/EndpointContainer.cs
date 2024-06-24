using Yamir.Api.Endpoints;

namespace Yamir.Api.IoC
{
    public static class EndpointContainer
    {
        public static void UseEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapBinaryFileEndpoint();
            app.MapRegionEndpoint();
            app.MapTreeEndpoint();
        }
    }
}
