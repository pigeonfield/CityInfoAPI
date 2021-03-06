﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Web;

namespace CityInfoAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var appBasePath = System.IO.Directory.GetCurrentDirectory();
            NLog.GlobalDiagnosticsContext.Set("appbasepath", appBasePath);
            var logger = LogManager.LoadConfiguration("nlog.config").GetCurrentClassLogger();

            
            try
            {
                logger.Debug("init main");
                CreateWebHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                
                logger.Error(ex, "Stopped program because of exception");
                throw;
            }
            finally
            {
                
                NLog.LogManager.Shutdown();
            }

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            
           .ConfigureLogging(logging =>
            {
                logging.ClearProviders();
                logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
            })
            .UseNLog()
            .UseStartup<Startup>();
           
    }
}
