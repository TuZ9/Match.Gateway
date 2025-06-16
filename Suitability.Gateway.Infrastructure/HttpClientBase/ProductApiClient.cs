using Microsoft.Extensions.Logging;
using Suitability.Gateway.Domain.Dto;
using Suitability.Gateway.Domain.Interfaces.ApiClientService;

namespace Suitability.Gateway.Infrastructure.HttpClientBase
{
    public class ProductApiClient : ServiceClientBase<ProductDto, ProductApiClient>, IProductApiClient
    {
        public ProductApiClient(IHttpClientFactory clientFactory, ILogger<ProductApiClient> logger, string clientName) : base(clientFactory, logger, clientName)
        {

        }
    }
}
