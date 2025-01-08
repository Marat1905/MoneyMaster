using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using AccountService.Domain.Entities;

namespace AccountService.Infrastructure.EntityFramework.Configurations
{
    /// <summary>Конфигурация для таблицы типы учетной записи</summary>
    public class AccountTypeConfiguration : IEntityTypeConfiguration<AccountType>
    {
        public void Configure(EntityTypeBuilder<AccountType> builder)
        {
            builder.ToTable("AccountTypes").HasKey(x => x.Id);

            //Связь с таблицей Account один к многим
            builder.HasMany(x => x.Accounts)
                .WithOne(x => x.AccountType)
                .HasForeignKey(x => x.AccountTypeId);
        }
    }
}
