using Cross.IRepository;
using Cross.IService;
using System;

namespace Cross.Service
{
    public class AccountService : IAccountService
    {
        private readonly IUserRepository _userRepository;
        public AccountService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }
    }
}
