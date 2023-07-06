
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Registration.Repositories.Interface;
using Registration.Repositories.Repositories;



namespace Registration.Services
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IChildRepository, ChildRepository>();
            services.AddAutoMapper(typeof(MappingProfile));
            return services;
        }
    }
}
