using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Cross.DependencyInjections;
using Cross.IService;
using Cross.Service;
using Cross.Share;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Cross.IT.WebApi.Service
{
    public class Program
    {
        static ProxyGenerator ProxyGenerator = new ProxyGenerator();
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
            .UseServiceProviderFactory(new AutofacServiceProviderFactory(builder =>
                {
                    builder.AddInterceptor();
                }));
    }
}
