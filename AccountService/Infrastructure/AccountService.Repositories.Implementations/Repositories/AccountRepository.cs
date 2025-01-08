using AccountService.Infrastructure.EntityFramework.Context;
using AccountService.Repositories.Implementations.Repositories.Base;
using AccountService.Services.Repositories.Abstractions;
using AccountService.Domain.Entities;

namespace AccountService.Repositories.Implementations.Repositories
{
    /// <summary><inheritdoc cref="IAccountRepository"/></summary>
    public class AccountRepository : Repository<Account, Guid>, IAccountRepository
    {
        /// <summary><inheritdoc cref="IAccountRepository"/></summary>
        /// <param name="context">Контекст БД</param>
        public AccountRepository(AccountServiceContext context) : base(context)
        {
        }
    }
}
