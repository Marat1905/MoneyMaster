using AccountService.Domain.Entities;
using AccountService.Infrastructure.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;

namespace AccountService.WebAPI.Data
{
    public class DbInitializer
    {
        private readonly AccountServiceContext _db;

        public DbInitializer(AccountServiceContext db)
        {
            _db = db;
        }

        public async Task InitializeAsync()
        {
            //Если он не существует БД, никаких действий не выполняется. Если она существует, база данных удаляется.
            await _db.Database.EnsureDeletedAsync().ConfigureAwait(false);
            //Прекращаем отслеживание всех отслеживаемых в настоящее время сущностей.
            //_db.ChangeTracker.Clear();
            //await _db.Database.EnsureCreatedAsync().ConfigureAwait(false);
            //Мигрируем БД
            await _db.Database.MigrateAsync().ConfigureAwait(false);
            await InitialDB();
        }

        private async Task InitialDB()
        {
            List<AccountType> accountTypes = new List<AccountType>()
            {
            new AccountType() { Name = "Банковская карта" },
            new AccountType() { Name = "Счет в банке" },
            new AccountType() { Name = "Наличные" },
            };

            await _db.Set<AccountType>().AddRangeAsync(accountTypes);

            var user1 = Guid.NewGuid();
            var user2 = Guid.NewGuid();
            var user3 = Guid.NewGuid();


            List<Account> accounts = new List<Account>()
            {
               
                new Account() { Name = "Тинькофф", UserId = user1 , AccountType = accountTypes.FirstOrDefault(x=>x.Name == "Банковская карта")  },
                new Account() { Name = "Наличные", UserId = user1 , AccountType = accountTypes.FirstOrDefault(x=>x.Name == "Наличные")  },

                 new Account() { Name = "Сбер", UserId = user2 , AccountType = accountTypes.FirstOrDefault(x=>x.Name == "Банковская карта")  },
                 new Account() { Name = "Сбережения", UserId = user2 , AccountType = accountTypes.FirstOrDefault(x=>x.Name == "Наличные")  },

                 new Account() { Name = "Совкомбанк", UserId = user3 , AccountType = accountTypes.FirstOrDefault(x=>x.Name == "Банковская карта")  },
                 new Account() { Name = "Сбережения", UserId = user3 , AccountType = accountTypes.FirstOrDefault(x=>x.Name == "Счет в банке")  },

            };
            await _db.Set<Account>().AddRangeAsync(accounts);

            await _db.SaveChangesAsync();
        }
    }
}
