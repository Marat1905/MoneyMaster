// Ignore Spelling: Registrator

using AccountService.Infrastructure.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AccountService.EntityFramework
{
    public static class Registrator
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration Configuration) => services
           .AddDbContext<AccountServiceContext>(opt =>
           {

               var type = Configuration["Type"];

               var t = Configuration.GetConnectionString(type!);

               switch (type)
               {
                   case null: throw new InvalidOperationException("Не определён тип БД");
                   default: throw new InvalidOperationException($"Тип подключения {type} не поддерживается");

                   case "MSSQL":
                       opt.UseSqlServer(Configuration.GetConnectionString(type),
                                                                providerOptions =>
                                                                {
                                                                    providerOptions.CommandTimeout(180);
                                                                }
                                        );
                       break;
                   case "SQLite":
                       opt.UseSqlite(Configuration.GetConnectionString(type), b => b.MigrationsAssembly("AccountService.EntityFramework"));
                       break;
               };
               opt.EnableSensitiveDataLogging(false);
           })
        ;
    }
}
