using AutoMapper;
using IdentityService.Domain.Entities;
using IdentityService.Services.Abstractions;
using IdentityService.Services.Contracts.UserSetting;
using IdentityService.Services.Repositories.Abstractions;

namespace IdentityService.Services.Implementations
{
    /// <summary>Сервис работы с настройками пользователя</summary>
    public class UserSettingService : IUserSettingService
    {
        private readonly IMapper _mapper;
        private readonly IUserSettingRepository _userSettingRepository;

        /// <summary><inheritdoc cref="UserSettingService"/> </summary>
        /// <param name="mapper">Маппер</param>
        /// <param name="userSettingRepository">репозиторий</param>
        public UserSettingService(IMapper mapper, IUserSettingRepository userSettingRepository)
        {
            _mapper = mapper;
            _userSettingRepository = userSettingRepository;
        }

        public async Task<ICollection<UserSettingDto>> GetAllAsync()
        {
            ICollection<UserSetting> entities = _userSettingRepository.GetAll().ToList();
            return _mapper.Map<ICollection<UserSetting>, ICollection<UserSettingDto>>(entities);
        }

        public async Task<UserSettingDto> GetByIdAsync(Guid id)
        {
            var userSetting = await _userSettingRepository.GetAsync(id, CancellationToken.None);
            return _mapper.Map<UserSetting, UserSettingDto>(userSetting);
        }
    }
}
