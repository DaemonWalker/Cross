using Cross.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cross.Repository
{
    public class DBContext : DbContext
    {
        private readonly IConfiguration _configuration;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(this._configuration.GetConnectionString("sqlite"));
            //base.OnConfiguring(optionsBuilder);
        }
        public DBContext(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public DbSet<T> GetDbSet<T>() where T : class
        {
            var prop = this.GetType().GetProperties().Where(p => p.Name.Contains("DbSet") && p.Name.Contains(typeof(T).Name)).First();
            return prop.GetValue(this) as DbSet<T>;
        }
        public DbSet<UserDto> User { get; set; }
        public DbSet<TagDto> Tag { get; set; }
        public DbSet<CommentDto> Comment { get; set; }
        public DbSet<ItemDto> Item { get; set; }
        public List<CommentDto> Where { get; internal set; }
    }
}
