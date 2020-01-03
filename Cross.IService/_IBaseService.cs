using Autofac.Extras.DynamicProxy;
using Cross.Share;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.IService
{
    [Intercept(typeof(ServiceInterceptor))]
    public interface IBaseService
    {
    }
}
