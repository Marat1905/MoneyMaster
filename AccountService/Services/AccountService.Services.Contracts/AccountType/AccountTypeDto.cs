// Ignore Spelling: Dto

using AccountService.Services.Contracts.Account;

namespace AccountService.Services.Contracts.AccountType
{
    /// <summary>DTO Типа учетной записи </summary>
    /// <typeparam name="TKey">Тип первичного ключа</typeparam>
    public class AccountTypeDto<TKey>
    {
        /// <summary>Первичный ключ </summary>
        public TKey? Id { get; set; }

        /// <summary>Имя</summary>
        public required string Name { get; set; }

        /// <summary>Иконка</summary>
        public string? Icon { get; set; }

        /// <summary>Коллекция аккаунтов</summary>
        public ICollection<AccountDto>? Accounts { get; set; }

        /// <summary>Время</summary>
        public DateTime CreateAt { get; set; }
    }

    /// <summary>DTO Типа учетной записи </summary>
    public class AccountTypeDto : AccountTypeDto<Guid>;
}
