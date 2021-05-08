using System.Threading.Tasks;
using Discord;
using Discord.Webhook;
using IMessage = Twatch.Model.IMessage;

namespace Twatch.Service.Discord
{
    public class DiscordReporter : IReporter
    {
        private readonly DiscordWebhookClient _client;
        
        public DiscordReporter(DiscordWebhookClient client)
        {
            _client = client;
        }
        
        public async Task Report(IMessage message)
        {
            var author = message.Author;
            var source = message.Source;

            await _client.SendMessageAsync(
                embeds: new[]
                {
                    new EmbedBuilder()
                        .WithAuthor(author.Name, author.ProfileImageUrl, author.Url)
                        .WithUrl(message.Url)
                        .WithDescription(message.Text)
                        .WithFooter(source.Name, source.ImageUrl)
                        .WithTimestamp(message.CreatedAt)
                        .Build()
                }
            );
        }
    }
}
