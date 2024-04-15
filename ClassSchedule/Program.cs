using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ClassSchedule
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public interface IRepository<T>
        {
            // Define repository methods here
        }

        public class Repository<T> : IRepository<T>
        {
            // Implement repository methods here
        }






    }
}
