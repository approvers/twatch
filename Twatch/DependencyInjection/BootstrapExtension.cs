using Microsoft.Extensions.DependencyInjection;

namespace Twatch.DependencyInjection
{
    public static class BootstrapExtension
    {
        public static IServiceCollection AddBootstrap(this IServiceCollection services)
        {
            return services.AddHostedService<Bootstrap>();
        }
    }
}
