using Discord.Webhook;
using Microsoft.Extensions.DependencyInjection;
using Twatch.Service;
using Twatch.Service.Discord;

namespace Twatch.DependencyInjection
{
    public static class DiscordExtension
    {
        public static IServiceCollection AddDiscord(
            this IServiceCollection services,
            string webhookUrl
        )
        {
            return services.AddScoped<IReporter, DiscordReporter>(_ => new DiscordReporter(new DiscordWebhookClient(webhookUrl)));
        }
    }
}
