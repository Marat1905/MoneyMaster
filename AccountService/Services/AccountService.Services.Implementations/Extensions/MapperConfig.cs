using AccountService.Services.Implementations.Mapping;
using AutoMapper;

namespace AccountService.Services.Implementations.Extensions
{
    public static class MapperConfig
    {
        public static MapperConfiguration GetMapperConfiguration()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AccountMappingsProfile>();
                cfg.AddProfile<AccountTypeMappingsProfile>();

            });
            //configuration.AssertConfigurationIsValid();
            return configuration;
        }
    }
}
