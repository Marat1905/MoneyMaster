using IdentityService.Domain.Entities;
using IdentityService.Infrastructure.EntityFramework.Context;
using IdentityService.Services.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace IdentityService.Infrastructure.Repositories.Implementations.Repositories
{
    /// <summary><inheritdoc cref="IUserRepository"/></summary>
    public class UserRepository : Base.Repository<User, Guid>, IUserRepository
    {
        /// <summary><inheritdoc cref="IUserRepository"/></summary>
        /// <param name="context">Контекст БД</param>
        public UserRepository(IdentityContext context) : base(context) { }

        public async Task<bool> Exist(User item, CancellationToken Cancel = default) =>
                await Context.Set<User>().AnyAsync(x => x.UserName == item.UserName, Cancel) || await Context.Set<User>().AnyAsync(x => x.Email == item.Email, Cancel);


    }
}
