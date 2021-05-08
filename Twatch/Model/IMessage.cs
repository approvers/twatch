using System;

namespace Twatch.Model
{
    public interface IMessage
    {
        public IAuthor Author { get; }
        public string Text { get; }
        public string Url { get; }
        public DateTimeOffset CreatedAt { get; }
        public ISource Source { get; }
    }
}
