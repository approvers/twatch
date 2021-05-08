using Microsoft.Extensions.Hosting;

namespace Twatch
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices(services => new Startup().ConfigureServices(services))
        ;
    }
}
