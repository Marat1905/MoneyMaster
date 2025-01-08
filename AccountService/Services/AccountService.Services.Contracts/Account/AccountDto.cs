// Ignore Spelling: Dto

using AccountService.Services.Contracts.AccountType;

namespace AccountService.Services.Contracts.Account
{
    /// <summary>DTO аккаунта </summary>
    /// <typeparam name="TKey">Тип первичного ключа</typeparam>
    public class AccountDto<TKey>
    {
        /// <summary>Первичный ключ </summary>
        public TKey? Id { get; set; }

        /// <summary>Имя</summary>
        public required string Name { get; set; }

        /// <summary>Баланс</summary>
        public decimal Balance { get; set; }

        /// <summary>Расходы</summary>
        public string? Currency { get; set; }

        /// <summary>Иконка</summary>
        public string? Icon { get; set; }

        /// <summary>Идентификатор пользователя</summary>
        public TKey? UserId { get; set; }

        /// <summary>Идентификатор типа учетной записи</summary>
        public TKey? AccountTypeId { get; set; }

        /// <summary>Тип учетной записи</summary>
        public AccountTypeDto? AccountType { get; set; }

        /// <summary>Время</summary>
        public DateTime CreateAt { get; set; }
    }

    /// <summary>DTO аккаунта </summary>
    public class AccountDto : AccountDto<Guid>;
}
