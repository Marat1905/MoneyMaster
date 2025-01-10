# См. статью по ссылке https://aka.ms/customizecontainer, чтобы узнать как настроить контейнер отладки и как Visual Studio использует этот Dockerfile для создания образов для ускорения отладки.

# Этот этап используется при запуске из VS в быстром режиме (по умолчанию для конфигурации отладки)
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


# Этот этап используется для сборки проекта службы
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["AccountService/Hosts/AccountService.WebAPI/AccountService.WebAPI.csproj", "AccountService/Hosts/AccountService.WebAPI/"]
COPY ["MoneyMaster.Common/MoneyMaster.Common/MoneyMaster.Common.csproj", "MoneyMaster.Common/MoneyMaster.Common/"]
COPY ["AccountService/Infrastructure/AccountService.EntityFramework/AccountService.EntityFramework.csproj", "AccountService/Infrastructure/AccountService.EntityFramework/"]
COPY ["AccountService/Domain/AccountService.Domain.Entities/AccountService.Domain.Entities.csproj", "AccountService/Domain/AccountService.Domain.Entities/"]
COPY ["MoneyMaster.Common/MoneyMaster.Common.Enities/MoneyMaster.Common.Entities.csproj", "MoneyMaster.Common/MoneyMaster.Common.Enities/"]
COPY ["MoneyMaster.Common/MoneyMaster.Common.Interfaces/MoneyMaster.Common.Interfaces.csproj", "MoneyMaster.Common/MoneyMaster.Common.Interfaces/"]
COPY ["AccountService/Infrastructure/AccountService.Repositories.Implementations/AccountService.Repositories.Implementations.csproj", "AccountService/Infrastructure/AccountService.Repositories.Implementations/"]
COPY ["AccountService/Services/AccountService.Services.Repositories.Abstractions/AccountService.Services.Repositories.Abstractions.csproj", "AccountService/Services/AccountService.Services.Repositories.Abstractions/"]
COPY ["AccountService/Services/AccountService.Services.Abstractions/AccountService.Services.Abstractions.csproj", "AccountService/Services/AccountService.Services.Abstractions/"]
COPY ["AccountService/Services/AccountService.Services.Contracts/AccountService.Services.Contracts.csproj", "AccountService/Services/AccountService.Services.Contracts/"]
COPY ["AccountService/Services/AccountService.Services.Implementations/AccountService.Services.Implementations.csproj", "AccountService/Services/AccountService.Services.Implementations/"]
RUN dotnet restore "./AccountService/Hosts/AccountService.WebAPI/AccountService.WebAPI.csproj"
COPY . .
WORKDIR "/src/AccountService/Hosts/AccountService.WebAPI"
RUN dotnet build "./AccountService.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Этот этап используется для публикации проекта службы, который будет скопирован на последний этап
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./AccountService.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Этот этап используется в рабочей среде или при запуске из VS в обычном режиме (по умолчанию, когда конфигурация отладки не используется)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AccountService.WebAPI.dll"]