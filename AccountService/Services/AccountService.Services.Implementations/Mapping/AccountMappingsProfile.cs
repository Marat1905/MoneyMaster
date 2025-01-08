using AccountService.Services.Contracts.Account;
using AutoMapper;
using AccountService.Domain.Entities;

namespace AccountService.Services.Implementations.Mapping
{
    /// <summary>Профиль автомаппера для сущности счета.</summary>
    public class AccountMappingsProfile : Profile
    {
        /// <summary><inheritdoc cref="AccountMappingsProfile"/> </summary>
        public AccountMappingsProfile()
        {
            CreateMap<Account, AccountDto>();
        }
    }
}
