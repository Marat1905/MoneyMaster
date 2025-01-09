using AutoMapper;
using IdentityService.Domain.Entities;
using IdentityService.Services.Contracts.UserSetting;

namespace IdentityService.Services.Implementations.Mapping
{
    /// <summary>Профиль автомаппера для сущности настройки пользователя</summary>
    public class UserSettingMappingsProfile : Profile
    {
        /// <summary><inheritdoc cref="UserSettingMappingsProfile"/> </summary>
        public UserSettingMappingsProfile()
        {
            CreateMap<UserSetting, UserSettingDto>();
        }
    }
}
