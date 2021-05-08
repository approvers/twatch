using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Twatch.Service;

namespace Twatch
{
    public class Bootstrap : BackgroundService
    {
        private readonly IWatcher _watcher;
        private readonly IReporter _reporter;

        public Bootstrap(IWatcher watcher, IReporter reporter)
        {
            _watcher = watcher;
            _reporter = reporter;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            return Task.Run(() =>
            {
                foreach (var message in _watcher.Watch())
                {
                    _reporter.Report(message).Wait(stoppingToken);
                }
            }, stoppingToken);
        }
    }
}
