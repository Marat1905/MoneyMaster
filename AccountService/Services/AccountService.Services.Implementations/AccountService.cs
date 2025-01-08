using AccountService.Domain.Entities;
using AccountService.Services.Abstractions;
using AccountService.Services.Contracts.Account;
using AccountService.Services.Repositories.Abstractions;
using AutoMapper;

namespace AccountService.Services.Implementations
{
    /// <summary>Сервис работы с счетом</summary>
    public class AccountService : IAccountService
    {
        private readonly IMapper _mapper;
        private readonly IAccountRepository _accountRepository;

        /// <summary><inheritdoc cref="AccountService"/> </summary>
        /// <param name="mapper">Маппер</param>
        /// <param name="accountRepository">Репозиторий</param>
        public AccountService(IMapper mapper, IAccountRepository accountRepository)
        {
            _mapper = mapper;
            _accountRepository = accountRepository;
        }

        public async Task<ICollection<AccountDto>> GetAllAsync()
        {
            ICollection<Account> entities = _accountRepository.GetAll().ToList();
            return _mapper.Map<ICollection<Account>, ICollection<AccountDto>>(entities);
        }

        public async Task<AccountDto> GetByIdAsync(Guid id)
        {
            var account = await _accountRepository.GetAsync(id, CancellationToken.None);
            return _mapper.Map<Account, AccountDto>(account);
        }
    }
}
