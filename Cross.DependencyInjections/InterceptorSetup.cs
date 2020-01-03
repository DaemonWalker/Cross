using Autofac;
using Autofac.Extras.DynamicProxy;
using Cross.IService;
using Cross.Service;
using Cross.Share;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.DependencyInjections
{
    public static class InterceptorSetup
    {
        public static ContainerBuilder AddInterceptor(this ContainerBuilder builder)
        {
            builder.Register(p => new ServiceInterceptor());
            builder.RegisterType<AccountService>().As<IAccountService>().EnableInterfaceInterceptors();
            return builder;
        }
    }
}
