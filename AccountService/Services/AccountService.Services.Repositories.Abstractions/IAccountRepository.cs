using AccountService.Domain.Entities;
using MoneyMaster.Common.Interfaces.Repositories;

namespace AccountService.Services.Repositories.Abstractions
{
    /// <summary>
    /// Репозиторий работы с счетом.
    /// </summary>
    public interface IAccountRepository : IRepository<Account, Guid>
    {
    }
}
