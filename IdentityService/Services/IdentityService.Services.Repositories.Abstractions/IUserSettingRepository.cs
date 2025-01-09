using IdentityService.Domain.Entities;
using MoneyMaster.Common.Interfaces.Repositories;

namespace IdentityService.Services.Repositories.Abstractions
{
    /// <summary>
    /// Репозиторий работы с настройками пользователя
    /// </summary>
    public interface IUserSettingRepository : IRepository<UserSetting, Guid>
    {
    }
}
