using Microsoft.Extensions.Options;

namespace AsyncWebScraper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("hellouw");

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureServices((HostContext, services) =>
            {
                services.AddDbContext<NewsDbContext>(options => options.UseNpgsql(HostContext.Configuration.GetConnectionString("DefaultConnection")));
                
                //other services->
            });
        {

        }
    }
}
