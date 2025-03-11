﻿using apiToDo.Repository;
using apiToDo.Repository.Interface;
using apiToDo.Services;
using apiToDo.Services.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace apiToDo.DI
{
    public static class RegistrationDependencyInjectionExtensions
    {
        public static void AddRegistrationDependencies(this IServiceCollection services)
        {
            RegisterRepositories(services);
            RegisterServices(services);
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IPeopleRepository, PeopleRepository>();
        }
        
        private static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IPeopleService, PeopleService>();
        }

    }
}