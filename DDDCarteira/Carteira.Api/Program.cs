using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carteira.Api
{
    public class Program
    {
        public static object WebHost { get; private set; }

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();
        }
    }
}