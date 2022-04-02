using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colomb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Configuration SeriLog 2/2
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(
                    path: "K:\\WEB DEV\\22. C#\\Colomb-logs\\log-.txt", // file created as - log-20210928.txt
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
                    rollingInterval: RollingInterval.Day, // => create log for each day 
                    restrictedToMinimumLevel: LogEventLevel.Information // limit error warnings
                ).CreateLogger();
            try
            {
                Log.Information("L'API a démarré.");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "L'API n'a pas réussi à démarrer.");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
        
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                // Configuration SeriLog 1/2
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
