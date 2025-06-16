using Microsoft.Extensions.Logging;
using Suitability.Gateway.Domain.Interfaces.Services;

namespace Suitability.Gateway.Application.Services
{
    public class GatewayService : IGatewayService
    {
        private readonly ILogger<GatewayService> _logger;

        public GatewayService(ILogger<GatewayService> logger) 
        {
            _logger = logger;
        }

    }
}
