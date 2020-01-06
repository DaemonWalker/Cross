using Cross.DBContexts;
using Cross.Dtos;
using Cross.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cross.Repository
{
    public class AccountRepository : BaseRepository<AccountDto>, IAccountRepository
    {
        public AccountRepository(BaseDbContext dbContext) : base(dbContext)
        {
        }

        protected override DbSet<AccountDto> GetDbSet()
        {
            return _dbContext.Account;
        }

        public AccountDto GetByAccountAndPassword(string account, string password)
        {
            return Query(dbSet => dbSet.Where(p => p.Account == account && p.Password == password)).FirstOrDefault();
        }

        public AccountDto GetByID(int ID)
        {
            return Query(dbSet => dbSet.Where(p => p.ID == ID)).FirstOrDefault();
        }

    }
}
