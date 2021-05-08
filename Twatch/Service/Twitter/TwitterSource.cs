using Twatch.Model;

namespace Twatch.Service.Twitter
{
    public class TwitterSource : ISource
    {
        public string Name => "Twitter";
        public string ImageUrl => "https://abs.twimg.com/favicons/twitter.ico";
    }
}
