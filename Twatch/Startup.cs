using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Twatch.DependencyInjection;

namespace Twatch
{
    public class Startup
    {
        private IConfiguration Configuration { get; }
        
        public Startup()
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Environment.CurrentDirectory)
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.local.json", true)
                .AddEnvironmentVariables()
                .Build()
            ;
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddTwitter(
                    Configuration["Twitter:ConsumerKey"],
                    Configuration["Twitter:ConsumerSecret"],
                    Configuration["Twitter:AccessToken"],
                    Configuration["Twitter:AccessTokenSecret"],
                    Configuration["Twitter:Keyword"]
                )
                .AddDiscord(
                    Configuration["Discord:WebhookUrl"]
                )
                .AddBootstrap()
            ;
        }
    }
}
