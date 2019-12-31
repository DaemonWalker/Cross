using Cross.Dtos;
using Cross.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cross.Repository
{
    public class UserRepository : RepositoryBase, IUserRepository
    {
        public UserRepository(DBContext dbContext) : base(dbContext)
        {
        }

        public UserDto Get(int ID)
        {
            return _dbContext.User.Where(p => p.ID == ID).FirstOrDefault();
        }

        public UserDto Get(string account, string password)
        {
            return _dbContext.User.Where(p => p.Account == account && p.Password == password).FirstOrDefault();
        }

        public int Insert(UserDto user)
        {
            _dbContext.User.Add(user);
            return _dbContext.SaveChanges();
        }

        public int Update(UserDto user)
        {
            _dbContext.User.Update(user);
            return _dbContext.SaveChanges();
        }
    }
}
