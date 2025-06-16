using Microsoft.Extensions.Logging;
using Suitability.Gateway.Domain.Interfaces.ApiClientService;
using Suitability.Gateway.Domain.Interfaces.Services;

namespace Suitability.Gateway.Application.Services
{
    public class GatewayService : IGatewayService
    {
        private readonly ILogger<GatewayService> _logger;
        private readonly IAccountApiClient _accountClient;
        private readonly IDocumentStatusApiClient _documentStatusClient;
        public GatewayService(ILogger<GatewayService> logger, IAccountApiClient accountClient, IDocumentStatusApiClient documentStatusClient) 
        {
            _logger = logger;
            _accountClient = accountClient;
            _documentStatusClient = documentStatusClient;
        }

        public async Task ConsumeGames()
        {

        }

    }
}
