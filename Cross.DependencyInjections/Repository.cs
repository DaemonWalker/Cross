using Cross.DBContexts;
using Cross.IRepository;
using Cross.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.ComponentModel.Design;

namespace Cross.DependencyInjections
{
    public static class Repository
    {
        public static IServiceCollection AddRepositories(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddSingleton<IAccountRepository, AccountRepository>();
            //serviceDescriptors.AddSingleton<IUserRepository, UserRepository>();
            //serviceDescriptors.AddSingleton<IItemRepository, ItemRepository>();
            //serviceDescriptors.AddSingleton<ICommentRepository, CommentRepository>();
            //serviceDescriptors.AddSingleton<ITagRepository, TagRepository>();

            return serviceDescriptors;
        }
    }
}
