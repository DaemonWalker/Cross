using Cross.ILogic;
using Cross.IService;
using Cross.Logic;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.DependencyInjections
{
    public static class Logic
    {
        public static IServiceCollection AddServices(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddSingleton<IAccountLogic, AccountLogic>();
            return serviceDescriptors;
        }
    }
}
