using IdentityService.Domain.Entities;
using IdentityService.Infrastructure.EntityFramework.Context;
using IdentityService.Services.Repositories.Abstractions;

namespace IdentityService.Infrastructure.Repositories.Implementations.Repositories
{
    /// <summary><inheritdoc cref="IUserSettingRepository"/></summary>
    public class UserSettingRepository : Base.Repository<UserSetting, Guid>, IUserSettingRepository
    {
        /// <summary><inheritdoc cref="IUserSettingRepository"/></summary>
        /// <param name="context">Контекст БД</param>
        public UserSettingRepository(IdentityContext context) : base(context) { }
    }
}
