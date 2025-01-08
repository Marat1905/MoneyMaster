using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using AccountService.Domain.Entities;

namespace AccountService.Infrastructure.EntityFramework.Configurations
{
    /// <summary>Конфигурация для таблицы Аккаунта</summary>
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts").HasKey(x => x.Id);
        }
    }
}
