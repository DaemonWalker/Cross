using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.DependencyInjections
{
    public static class Bundle
    {
        public static IServiceCollection AddDependcies(this IServiceCollection serviceDescriptors,IConfiguration configuration)
        {
            serviceDescriptors.AddDbContexts(configuration);
            serviceDescriptors.AddRepositories();
            serviceDescriptors.AddServices();

            return serviceDescriptors;
        }
    }
}
