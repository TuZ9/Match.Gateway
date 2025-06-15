
using Microsoft.Extensions.Logging;
using Suitability.Gateway.Domain.Entities;
using Suitability.Gateway.Domain.Interfaces.ApiClientService;

namespace Suitability.Gateway.Infrastructure.HttpClientBase
{
    public class AccountApiClient : ServiceClientBase<Account, AccountApiClient>, IAccountApiClient
    {
        public AccountApiClient(IHttpClientFactory clientFactory, ILogger<AccountApiClient> logger, string clientName) : base(clientFactory, logger, clientName)
        {

        }
    }
}
