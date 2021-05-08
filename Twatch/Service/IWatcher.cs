using System.Collections.Generic;
using Twatch.Model;

namespace Twatch.Service
{
    public interface IWatcher
    {
        public IEnumerable<IMessage> Watch();
    }
}
