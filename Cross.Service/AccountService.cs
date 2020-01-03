using Cross.Dtos;
using Cross.IRepository;
using Cross.IService;
using System;
using System.Linq;

namespace Cross.Service
{
    public class AccountService : IAccountService
    {
        private readonly IBaseRepository<UserDto> _user;
        public AccountService(IBaseRepository<UserDto> user)
        {
            this._user = user;
        }

        public object Login(string account, string password)
        {
            var user = _user.Query(dbSet => dbSet.Where(p => p.Account == account && p.Password == password)).FirstOrDefault();
            return user != null;
        }
    }
}
