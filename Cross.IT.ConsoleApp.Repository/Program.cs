using Autofac;
using Autofac.Extensions.DependencyInjection;
using Cross.DependencyInjections;
using Cross.IRepository;
using Cross.Tests.Share;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;

namespace Cross.IT.ConsoleApp.Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            Mock<IConfiguration> configation = new Mock<IConfiguration>();
            configation.Setup(p => p.GetSection(It.IsAny<string>())[It.IsAny<string>()]).Returns("Data Source=Cross.db");

            var services = new CrossServiceCollection();
            services.AddRepository();
            services.AddSingleton<IConfiguration>(configation.Object);

            ContainerBuilder builder = new ContainerBuilder();
            var factory = new AutofacServiceProviderFactory();
            var serviceProvider = factory.CreateServiceProvider(factory.CreateBuilder(services));

            var userRepo = serviceProvider.GetService(typeof(IUserRepository)) as IUserRepository;
            //userRepo.Insert(new Dtos.UserDto() { Account = "215136855", Name = "半神精灵", RegisteDate = DateTime.Now, Password = "jc931016" });
            Console.WriteLine(userRepo.Get(account: "215136855", password: "jc931016")?.ID);
        }
    }
}
