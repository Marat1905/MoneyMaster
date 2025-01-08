// Ignore Spelling: Registrator

using AccountService.Services.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace AccountService.Services.Implementations.Service
{
    public static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) =>
            services
            .AddTransient<IAccountService, AccountService>()
            .AddTransient<IAccountTypeService, AccountTypeService>()
            ;

    }
}
