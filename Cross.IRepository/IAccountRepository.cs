using Cross.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.IRepository
{
    public interface IAccountRepository : IBaseRepository<AccountDto>
    {
        AccountDto GetByAccountAndPassword(string account, string password);
        AccountDto GetByID(int ID);

    }
}
