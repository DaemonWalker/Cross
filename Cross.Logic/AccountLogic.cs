using AutoMapper;
using Cross.Dtos;
using Cross.ILogic;
using Cross.IRepository;
using Cross.IService;
using Cross.Models;
using System;
using System.Linq;

namespace Cross.Logic
{
    public class AccountLogic : IAccountLogic
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;
        public AccountLogic(IAccountRepository accountRepository, IMapper mapper)
        {
            this._mapper = mapper;
            this._accountRepository = accountRepository;
        }

        public AccountModel GetUserInfo(int ID)
        {
            var dto = _accountRepository.GetByID(ID);
            return _mapper.Map<AccountModel>(dto);
        }

        public LoginModel Login(string account, string password)
        {
            var dto = _accountRepository.GetByAccountAndPassword(account, password);
            return _mapper.Map<LoginModel>(dto);
        }

        public AccountModel Regist(AccountModel account)
        {
            var dto = _mapper.Map<AccountDto>(account);
            dto = _accountRepository.Insert(dto);
            return _mapper.Map<AccountModel>(dto);
        }

        public AccountModel UpdateInfo(AccountModel account)
        {
            var dto = _mapper.Map<AccountDto>(account);
            dto = _accountRepository.Update(dto);
            return _mapper.Map<AccountModel>(dto);
        }
    }
}
