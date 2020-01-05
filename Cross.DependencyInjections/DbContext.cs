using Cross.DBContexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.DependencyInjections
{
    public static class DbContext
    {
        public static IServiceCollection AddDbContexts(this IServiceCollection serviceDescriptors, IConfiguration configuration)
        {
            serviceDescriptors.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString("sqlite"));
            });
            serviceDescriptors.AddSingleton<BaseDbContext, SqliteDbContext>();
            return serviceDescriptors;
        }
    }
}
