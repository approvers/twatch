using CoreTweet;
using Twatch.Model;

namespace Twatch.Service.Twitter
{
    public class TwitterAuthor : IAuthor
    {
        private readonly User _user;

        public string Name => _user.Name;
        public string ScreenName => _user.ScreenName;
        public string Url => _user.Url;
        public string ProfileImageUrl => _user.ProfileImageUrl;

        public TwitterAuthor(User user)
        {
            _user = user;
        }
    }
}
