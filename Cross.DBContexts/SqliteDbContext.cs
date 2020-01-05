using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.DBContexts
{
    public class SqliteDbContext : BaseDbContext
    { 
        public SqliteDbContext(IConfiguration configuration) : base(configuration)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(this._configuration.GetConnectionString("sqlite"));
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
