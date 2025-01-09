﻿using AutoMapper;
using IdentityService.Services.Implementations.Mapping;

namespace IdentityService.Services.Implementations.Extensions
{
    public static class MapperConfig
    {
        public static MapperConfiguration GetMapperConfiguration()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<UserMappingsProfile>();
                cfg.AddProfile<UserSettingMappingsProfile>();

            });
            //configuration.AssertConfigurationIsValid();
            return configuration;
        }
    }
}
