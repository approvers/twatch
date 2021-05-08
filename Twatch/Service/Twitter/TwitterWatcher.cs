using System.Collections.Generic;
using System.Linq;
using CoreTweet;
using CoreTweet.Streaming;
using Twatch.Model;

namespace Twatch.Service.Twitter
{
    public class TwitterWatcher : IWatcher
    {
        private readonly Tokens _tokens;
        private readonly string _keyword;

        public TwitterWatcher(Tokens tokens, string keyword)
        {
            _tokens = tokens;
            _keyword = keyword;
        }
        
        public IEnumerable<IMessage> Watch()
        {
            return _tokens
                .Streaming
                .Filter(track: _keyword)
                .OfType<StatusMessage>()
                .Select(message => new TwitterMessage(message.Status))
            ;
        }
    }
}
