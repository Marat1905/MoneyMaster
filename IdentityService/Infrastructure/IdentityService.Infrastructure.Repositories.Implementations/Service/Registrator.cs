using IdentityService.Infrastructure.Repositories.Implementations.Repositories;
using IdentityService.Services.Repositories.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityService.Infrastructure.Repositories.Implementations.Service
{
    public static class Registrator
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services) =>
            services
            .AddTransient<IUserRepository, UserRepository>()
            .AddTransient<IUserSettingRepository, UserSettingRepository>()
            ;
    }
}
