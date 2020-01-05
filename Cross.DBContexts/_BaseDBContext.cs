using Cross.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cross.DBContexts
{
    public abstract class BaseDbContext : DbContext
    {
        protected readonly IConfiguration _configuration;

        public BaseDbContext(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public DbSet<T> GetDbSet<T>() where T : class
        {
            IQueryable dbSet = null;
            if (IsSameType<T, AccountDto>())
            {
                dbSet = Account;
            }
            else if (IsSameType<T, TagDto>())
            {
                dbSet = Tag;
            }
            else if (IsSameType<T, CommentDto>())
            {
                dbSet = Comment;
            }
            else if (IsSameType<T, ItemDto>())
            {
                dbSet = Item;
            }
            else
            {
                var prop = this.GetType().GetProperties().Where(p => p.Name.Contains("DbSet") && p.Name.Contains(typeof(T).Name)).First();
                dbSet = prop.GetValue(this) as IQueryable;
            }
            return dbSet as DbSet<T>;
        }
        public DbSet<AccountDto> Account { get; set; }
        public DbSet<TagDto> Tag { get; set; }
        public DbSet<CommentDto> Comment { get; set; }
        public DbSet<ItemDto> Item { get; set; }
        public List<CommentDto> Where { get; internal set; }

        private static bool IsSameType<T1, T2>() => typeof(T1) == typeof(T2);
    }
}
