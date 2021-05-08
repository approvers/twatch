using CoreTweet;
using Microsoft.Extensions.DependencyInjection;
using Twatch.Service;
using Twatch.Service.Twitter;

namespace Twatch.DependencyInjection
{
    public static class TwitterExtension
    {
        public static IServiceCollection AddTwitter(
            this IServiceCollection services,
            string consumerKey,
            string consumerSecret,
            string accessToken, 
            string accessTokenSecret,
            string keyword
        )
        {
            return services.AddScoped<IWatcher, TwitterWatcher>(_ => new TwitterWatcher(
                Tokens.Create(
                    consumerKey,
                    consumerSecret,
                    accessToken,
                    accessTokenSecret
                ),
                keyword
            ));
        }
    }
}
