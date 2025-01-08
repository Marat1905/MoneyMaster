using AccountService.Services.Contracts.AccountType;
using AutoMapper;
using AccountService.Domain.Entities;

namespace AccountService.Services.Implementations.Mapping
{
    /// <summary>Профиль автомаппера для сущности типа счета.</summary>
    public class AccountTypeMappingsProfile : Profile
    {
        /// <summary><inheritdoc cref="AccountTypeMappingsProfile"/> </summary>
        public AccountTypeMappingsProfile()
        {
            CreateMap<AccountType, AccountTypeDto>();
        }
    }
}
