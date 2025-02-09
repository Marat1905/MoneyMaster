﻿using AccountService.Services.Abstractions;
using AccountService.Services.Contracts.AccountType;
using AccountService.Services.Repositories.Abstractions;
using AutoMapper;
using AccountService.Domain.Entities;

namespace AccountService.Services.Implementations
{
    /// <summary>Сервис работы с типом счета</summary>
    public class AccountTypeService : IAccountTypeService
    {
        private readonly IMapper _mapper;
        private readonly IAccountTypeRepository _accountTypeRepository;

        /// <summary><inheritdoc cref="AccountTypeService"/> </summary>
        /// <param name="mapper">Маппер</param>
        /// <param name="accountTypeRepository">Репозиторий</param>
        public AccountTypeService(IMapper mapper, IAccountTypeRepository accountTypeRepository)
        {
            _mapper = mapper;
            _accountTypeRepository = accountTypeRepository;
        }

        public async Task<ICollection<AccountTypeDto>> GetAllAsync()
        {
            ICollection<AccountType> entities = _accountTypeRepository.GetAll().ToList();
            return _mapper.Map<ICollection<AccountType>, ICollection<AccountTypeDto>>(entities);
        }

        public async Task<AccountTypeDto> GetByIdAsync(Guid id)
        {
            var accountType = await _accountTypeRepository.GetAsync(id, CancellationToken.None);
            return _mapper.Map<AccountType, AccountTypeDto>(accountType);
        }
    }
}
