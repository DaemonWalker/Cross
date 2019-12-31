using Cross.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.IRepository
{
    public interface IUserRepository
    {
        UserDto Get(int ID);
        UserDto Get(string account, string password);
        int Update(UserDto user);
        int Insert(UserDto user);
    }
}
