using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using NJsonSchema.CodeGeneration.TypeScript;
using NSwag;
using NSwag.CodeGeneration.OperationNameGenerators;
using NSwag.CodeGeneration.TypeScript;
using Swashbuckle.AspNetCore.Swagger;
using System.Text;

namespace Yamir.Api.Endpoints
{
    public static class YamirClientEndpoint
    {
        private const string BaseRoute = "api/yamirclient";

        public static void MapYamirClientProviderEndpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet($"{BaseRoute}/get", (IConfiguration configuration, ISwaggerProvider swaggerProvider) =>
            {
                const string contentType = "application/octet-stream";

                var apiUrl = configuration["ApiUrl"];

                if (string.IsNullOrEmpty(apiUrl))
                {
                    return Task.FromResult(Results.BadRequest("API URL is required."));
                }

                var swaggerDocument = GetSwaggerDocument(swaggerProvider);

                var nSwagTsClientString = GenerateNSwagTypeScriptClient(swaggerDocument, apiUrl);

                return Task.FromResult(Results.File(Encoding.UTF8.GetBytes(nSwagTsClientString), contentType,
                    "YamirClient.ts"));
            }).WithTags(BaseRoute);
        }

        private static OpenApiDocument GetSwaggerDocument(ISwaggerProvider swaggerProvider)
        {
            var microsoftOpenApiDocument = swaggerProvider.GetSwagger("v1");

            var json = microsoftOpenApiDocument.SerializeAsJson(OpenApiSpecVersion.OpenApi2_0);

            return OpenApiDocument.FromJsonAsync(json).Result; ;
        }

        private static string GenerateNSwagTypeScriptClient(OpenApiDocument nSwaggerDocument, string apiUrl)
        {
            var settings = new TypeScriptClientGeneratorSettings
            {
                OperationNameGenerator = new SingleClientFromPathSegmentsOperationNameGenerator(),
                ClassName = "{controller}YamirClient",
                Template = TypeScriptTemplate.Fetch,
                PromiseType = PromiseType.Promise,
                HttpClass = HttpClass.HttpClient,
                GenerateClientClasses = true,
                GenerateClientInterfaces = true,
                GenerateOptionalParameters = false,
                WrapDtoExceptions = false,
                ExceptionClass = "YamirApiException",
                ResponseClass = "SwaggerResponse",
                GenerateResponseClasses = true,
                GenerateDtoTypes = true,
                ImportRequiredTypes = true,
                BaseUrlTokenName = apiUrl,
                TypeScriptGeneratorSettings =
                {
                    EnumStyle  = TypeScriptEnumStyle.Enum,
                    DateTimeType = TypeScriptDateTimeType.Date,
                    ExportTypes = true,
                    MarkOptionalProperties = true,
                    GenerateDefaultValues = true,
                    TypeScriptVersion = 4.3M,
                    TypeStyle = TypeScriptTypeStyle.Interface,
                    ModuleName = "YamirClientModule",
                    GenerateConstructorInterface = true
                }
            };

            var generator = new TypeScriptClientGenerator(nSwaggerDocument, settings);

            var tsClientString = generator.GenerateFile();

            return tsClientString;
        }
    }
}
