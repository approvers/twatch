using System;
using CoreTweet;
using Twatch.Model;

namespace Twatch.Service.Twitter
{
    public class TwitterMessage : IMessage
    {
        private static TwitterSource _source = new TwitterSource();
        
        private readonly Status _status;
        private readonly TwitterAuthor _author;

        public IAuthor Author => _author;
        public string Text => _status.Text;
        public string Url => $"https://twitter.com/i/web/status/{_status.Id}";
        public DateTimeOffset CreatedAt => _status.CreatedAt;
        public ISource Source => _source;

        public TwitterMessage(Status status)
        {
            _status = status;
            _author = new TwitterAuthor(status.User);
        }
    }
}
