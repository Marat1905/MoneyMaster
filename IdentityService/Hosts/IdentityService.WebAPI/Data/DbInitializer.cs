using IdentityService.Domain.Entities;
using IdentityService.Infrastructure.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;

namespace IdentityService.WebAPI.Data
{
    public class DbInitializer
    {
        private readonly IdentityContext _db;

        public DbInitializer(IdentityContext db)
        {
            _db = db;
        }

        public async Task InitializeAsync()
        {
            //Если он не существует БД, никаких действий не выполняется. Если она существует, база данных удаляется.
            await _db.Database.EnsureDeletedAsync().ConfigureAwait(false);
            //Прекращаем отслеживание всех отслеживаемых в настоящее время сущностей.
            //_db.ChangeTracker.Clear();
            //Мигрируем БД
            await _db.Database.MigrateAsync().ConfigureAwait(false);
            await InitialDB();
        }

        private async Task InitialDB()
        {
           


            User user1 = new User() { UserName = "Петр", Email = "Peter@Gmail.com", PasswordHash = "GGGG", CreateAt = DateTime.Now };
            User user2 = new User() { UserName = "Иван", Email = "Ivan@Gmail.com", PasswordHash = "Ivan", CreateAt = DateTime.Now };
            User user3 = new User() { UserName = "Вася", Email = "Basia@Gmail.com", PasswordHash = "Basia", CreateAt = DateTime.Now };
            UserSetting userSetting1 = new UserSetting() { Language = "ru" };
            UserSetting userSetting2 = new UserSetting() { Language = "eng" };
            UserSetting userSetting3 = new UserSetting() { Language = "ru" };
            user1.UserSetting = userSetting1;
            user2.UserSetting = userSetting2;
            user3.UserSetting = userSetting3;

            await _db.Set<User>().AddAsync(user1);
            await _db.Set<User>().AddAsync(user2);
            await _db.Set<User>().AddAsync(user3);

            _db.SaveChanges();
        }
    }
}
