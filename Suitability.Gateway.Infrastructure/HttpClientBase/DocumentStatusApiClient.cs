
using Microsoft.Extensions.Logging;
using Suitability.Gateway.Domain.Entities;
using Suitability.Gateway.Domain.Interfaces.ApiClientService;

namespace Suitability.Gateway.Infrastructure.HttpClientBase
{
    public class DocumentStatusApiClient : ServiceClientBase<DocumentStatus, DocumentStatusApiClient>, IDocumentStatusApiClient
    {
        public DocumentStatusApiClient(IHttpClientFactory clientFactory, ILogger<DocumentStatusApiClient> logger, string clientName) : base(clientFactory, logger, clientName)
        {

        }
    }
}
