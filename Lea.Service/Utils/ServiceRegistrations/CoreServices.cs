using System;
using Lea.Repository.Implementations;
using Lea.Repository.Interfaces;
using Lea.Service.Implementations;
using Lea.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Lea.Service.Utils.ServiceRegistrations;

public static class CoreServices
{
    public static IServiceCollection AddCoreServices( this IServiceCollection services){
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserService, UserService>();

        return services;
    }
}
