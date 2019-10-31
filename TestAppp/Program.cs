using System;
using System.Net;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace KestrelWebServer
{
    /// <summary>
    /// Executing the "dotnet run" command in the application folder will run this app.
    /// </summary>
    public class Program
    {
        // The default listening address is http://localhost:5000 if none is specified.

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();


    }
}