using AccountService.Infrastructure.EntityFramework.Context;
using AccountService.Repositories.Implementations.Repositories.Base;
using AccountService.Services.Repositories.Abstractions;
using AccountService.Domain.Entities;

namespace AccountService.Repositories.Implementations.Repositories
{
    /// <summary><inheritdoc cref="IAccountTypeRepository"/></summary>
    public class AccountTypeRepository : Repository<AccountType, Guid>, IAccountTypeRepository
    {
        /// <summary><inheritdoc cref="IAccountTypeRepository"/></summary>
        /// <param name="context">Контекст БД</param>
        public AccountTypeRepository(AccountServiceContext context) : base(context) { }
    }
}
