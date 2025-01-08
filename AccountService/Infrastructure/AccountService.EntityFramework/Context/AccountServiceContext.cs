using AccountService.Infrastructure.EntityFramework.Configurations;
using Microsoft.EntityFrameworkCore;

namespace AccountService.Infrastructure.EntityFramework.Context
{
    /// <summary>Контекст базы данных </summary>
    public class AccountServiceContext : DbContext
    {
        public AccountServiceContext(DbContextOptions<AccountServiceContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            // Database.EnsureCreatedAsync();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AccountConfiguration());
            builder.ApplyConfiguration(new AccountTypeConfiguration());
        }
    }
}
