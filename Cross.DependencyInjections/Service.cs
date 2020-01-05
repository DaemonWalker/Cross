using Cross.IService;
using Cross.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.DependencyInjections
{
    public static class Service
    {
        public static IServiceCollection AddServices(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddSingleton<IAccountService, AccountService>();
            return serviceDescriptors;
        }
    }
}
