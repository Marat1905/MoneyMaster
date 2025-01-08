// Ignore Spelling: Registrator

using AccountService.Services.Implementations.Extensions;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace AccountService.Services.Implementations.Service
{
    public static class MapperRegistrator
    {
        public static IServiceCollection AddMapper(this IServiceCollection services) =>
            services
            .AddSingleton<IMapper>(new Mapper(MapperConfig.GetMapperConfiguration()));
    }
}
