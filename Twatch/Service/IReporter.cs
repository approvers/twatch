using System.Threading.Tasks;
using Twatch.Model;

namespace Twatch.Service
{
    public interface IReporter
    {
        public Task Report(IMessage message);
    }
}
