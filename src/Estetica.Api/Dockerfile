FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Estetica.Api/Estetica.Api.csproj", "src/Estetica.Api/"]
COPY ["src/Estetica.CrossCutting.Ioc/Estetica.CrossCutting.Ioc.csproj", "src/Estetica.CrossCutting.Ioc/"]
COPY ["src/Estetica.Domain/Estetica.Domain.csproj", "src/Estetica.Domain/"]
COPY ["src/Estetica.CrossCutting.Util/Estetica.CrossCutting.Util.csproj", "src/Estetica.CrossCutting.Util/"]
COPY ["src/Estetica.Infra.Data/Estetica.Infra.Data.csproj", "src/Estetica.Infra.Data/"]
COPY ["src/Estetica.Service/Estetica.Service.csproj", "src/Estetica.Service/"]
COPY ["src/Estetica.Infra.Auth/Estetica.Infra.Auth.csproj", "src/Estetica.Infra.Auth/"]
COPY ["src/Estetica.Infra.Database/Estetica.Infra.Database.csproj", "src/Estetica.Infra.Database/"]
RUN dotnet restore "src/Estetica.Api/Estetica.Api.csproj"
COPY . .
WORKDIR "/src/src/Estetica.Api"
RUN dotnet build "Estetica.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Estetica.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Estetica.Api.dll"]