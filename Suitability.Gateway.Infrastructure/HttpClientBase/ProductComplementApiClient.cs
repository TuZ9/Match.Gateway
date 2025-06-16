using Microsoft.Extensions.Logging;
using Suitability.Gateway.Domain.Dto;
using Suitability.Gateway.Domain.Interfaces.ApiClientService;

namespace Suitability.Gateway.Infrastructure.HttpClientBase
{
    public class ProductComplementApiClient : ServiceClientBase<ProductComplementDto, ProductComplementApiClient>, IProductComplementApiClient
    {
        public ProductComplementApiClient(IHttpClientFactory clientFactory, ILogger<ProductComplementApiClient> logger, string clientName) : base(clientFactory, logger, clientName)
        {

        }
    }
}
