using IdentityService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityService.Infrastructure.EntityFramework.Configurations
{
    /// <summary>Конфигурация для таблицы пользователей</summary>
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users").HasKey(x => x.Id);

            //Связь с таблицей UserSetting один к одному
            builder.HasOne(x => x.UserSetting)
                   .WithOne(p => p.User)
                   .HasForeignKey<UserSetting>(p => p.UserId);
        }
    }
}
