using Microsoft.Extensions.DependencyInjection;
using Registration.Repositories.Interface;
using Registration.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Repositories
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IChildRepository, ChildRepository>();

            return services;
        }
    }
}
