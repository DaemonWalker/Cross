using Cross.Models;
using System;

namespace Cross.ILogic
{
    public interface IAccountLogic : IBaseService
    {
        LoginModel Login(string account, string password);
        AccountModel GetUserInfo(int ID);
        AccountModel Regist(AccountModel account);
        AccountModel UpdateInfo(AccountModel account);
    }
}
