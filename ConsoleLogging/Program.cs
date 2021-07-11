using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;

namespace ConsoleLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var collections = new ServiceCollection();
            ServiceProvider provider = ConfigureServices(collections);

            ILogger log = provider.GetService<ILogger<Program>>();
            log.LogInformation("Hello guys!");
           
        }

        private static ServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(configure => { configure.AddConsole(); });
            return services.BuildServiceProvider();
        }
    }
}
