﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace eSyaEnterprise_UI
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            //var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            //logger.Debug("init main function");

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                //.ConfigureLogging(logging =>
                //{
                //    logging.ClearProviders();
                //    logging.SetMinimumLevel(LogLevel.Information);
                //})
                .UseNLog();
    }
}
