using Autofac.Extras.DynamicProxy;
using Cross.Share;
using System;

namespace Cross.IService
{
    public interface IAccountService : IBaseService
    {
        object Login(string account, string password);
    }
}
