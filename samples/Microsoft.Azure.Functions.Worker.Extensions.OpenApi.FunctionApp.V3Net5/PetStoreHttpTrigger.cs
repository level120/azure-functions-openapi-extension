using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

using Microsoft.Azure.Functions.Worker.Extensions.OpenApi.FunctionApp.V3Net5.SecurityFlows;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.FunctionApp.Models.PetStore;
using Microsoft.OpenApi.Models;

namespace Microsoft.Azure.Functions.Worker.Extensions.OpenApi.FunctionApp.V3Net5
{
    public class PetStoreHttpTrigger
    {
        [Function(nameof(PetStoreHttpTrigger.AddPet))]
        [OpenApiOperation(operationId: "addWeatherForecast", tags: new[] { "weatherforecast" }, Summary = "Add test", Description = "Add test description", Visibility = OpenApiVisibilityType.Important)]
        [OpenApiRequestBody(contentType: "application/json", bodyType: typeof(WeatherForecast), Required = true, Description = "Add test description of request body")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "application/json", bodyType: typeof(WeatherForecast), Summary = "Add test of response body", Description = "Add test description of response body")]
        public static async Task<HttpResponseData> AddPet(
            [HttpTrigger(AuthorizationLevel.Function, "GET", Route = "weatherforecast")] HttpRequestData req,
            FunctionContext executionContext)
        {
            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "application/json; charset=utf-8");

            //await response.WriteAsJsonAsync(req.Body).ConfigureAwait(false);

            return await Task.FromResult(response).ConfigureAwait(false);
        }
    }
}
