using AccountService.Repositories.Implementations.Repositories;
using AccountService.Services.Repositories.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace AccountService.Repositories.Implementations.Service
{
    public static class Registrator
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services) =>
            services
            .AddTransient<IAccountRepository, AccountRepository>()
            .AddTransient<IAccountTypeRepository, AccountTypeRepository>()
            ;
    }
}
