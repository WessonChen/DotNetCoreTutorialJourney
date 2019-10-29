using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace DotNetCoreTutorialJourney
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        //CreateDefaultBuilder creates the 'WebHost' with certain pre-configure defaults.
        //UseStartup extension starts up the 'Startup' class by default.
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}