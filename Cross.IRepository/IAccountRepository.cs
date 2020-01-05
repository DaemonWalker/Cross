using Cross.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.IRepository
{
    public interface IAccountRepository
    {
        AccountDto GetByAccountAndPassword(string account, string password);
        AccountDto Add(AccountDto account);
        AccountDto Modify(AccountDto account);
        AccountDto GetByID(int ID);

    }
}
