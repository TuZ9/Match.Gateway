using Microsoft.Extensions.DependencyInjection;

namespace Suitability.Gateway.Infrastructure.Extensions
{
    public static class HttpClient
    {
        public static IServiceCollection AddHttpClients(this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();

            return services;
        }
    }
}
