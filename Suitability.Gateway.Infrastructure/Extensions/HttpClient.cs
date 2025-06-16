using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Suitability.Gateway.Domain.Interfaces.ApiClientService;
using Suitability.Gateway.Infrastructure.HttpClientBase;
using Suitability.Gateway.Infrastructure.Static;

namespace Suitability.Gateway.Infrastructure.Extensions
{
    public static class HttpClient
    {
        public static IServiceCollection AddHttpClients(this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();

            var accountLogger = serviceProvider.GetService(typeof(ILogger<AccountApiClient>)) as ILogger<AccountApiClient>;
            var strainLogger = serviceProvider.GetService(typeof(ILogger<DocumentStatusApiClient>)) as ILogger<DocumentStatusApiClient>;

            services.AddHttpClient("Account", client => { client.BaseAddress = new Uri(RunTimeConfig.SuitabilityEndpoint); });
            services.AddHttpClient("DocumentStatus", client => { client.BaseAddress = new Uri(RunTimeConfig.SuitabilityEndpoint); });

            services.AddSingleton<IAccountApiClient, AccountApiClient>(x => new AccountApiClient(x.GetService<IHttpClientFactory>()!, accountLogger, "Account"));
            services.AddSingleton<IDocumentStatusApiClient, DocumentStatusApiClient>(x => new DocumentStatusApiClient(x.GetService<IHttpClientFactory>()!, strainLogger, "DocumentStatus"));

            //services.AddHttpClient<IAccountApiClient, AccountApiClient>(_ => _.BaseAddress = new Uri(RunTimeConfig.SuitabilityEndpoint));
            //services.AddHttpClient<IDocumentStatusApiClient, DocumentStatusApiClient>(_ => _.BaseAddress = new Uri(RunTimeConfig.SuitabilityEndpoint));

            return services;
        }
    }
}
