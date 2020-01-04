using Autofac.Extras.DynamicProxy;
using Cross.Models;
using Cross.Share;
using System;

namespace Cross.IService
{
    public interface IAccountService : IBaseService
    {
        LoginModel Login(string account, string password);
        AccountModel GetUserInfo(int ID);
    }
}
