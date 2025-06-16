using Microsoft.Extensions.DependencyInjection;
using Suitability.Gateway.Domain.Interfaces.Services;
using Suitability.Gateway.Application.Services;

namespace Suitability.Gateway.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                .RegisterServices();
        }

        private static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            return services
                .AddScoped<IGatewayService, GatewayService>();
        }
    }
}
