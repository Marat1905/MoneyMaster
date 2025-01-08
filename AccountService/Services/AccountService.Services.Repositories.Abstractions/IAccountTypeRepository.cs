using AccountService.Domain.Entities;
using MoneyMaster.Common.Interfaces.Repositories;

namespace AccountService.Services.Repositories.Abstractions
{
    /// <summary>
    /// Репозиторий работы с типом счета.
    /// </summary>
    public interface IAccountTypeRepository : IRepository<AccountType, Guid>
    {
    }
}
