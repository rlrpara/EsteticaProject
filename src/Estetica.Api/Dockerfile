FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 80
EXPOSE 81


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Estetica.Api/Estetica.Api.csproj", "src/Estetica.Api/"]
COPY ["src/Estetica.CrossCutting.Ioc/Estetica.CrossCutting.Ioc.csproj", "src/Estetica.CrossCutting.Ioc/"]
COPY ["src/Estetica.Domain/Estetica.Domain.csproj", "src/Estetica.Domain/"]
COPY ["src/Estetica.CrossCutting.Util/Estetica.CrossCutting.Util.csproj", "src/Estetica.CrossCutting.Util/"]
COPY ["src/Estetica.Infra.Data/Estetica.Infra.Data.csproj", "src/Estetica.Infra.Data/"]
COPY ["src/Estetica.Service/Estetica.Service.csproj", "src/Estetica.Service/"]
COPY ["src/Estetica.Infra.Auth/Estetica.Infra.Auth.csproj", "src/Estetica.Infra.Auth/"]
COPY ["src/Estetica.Infra.Database/Estetica.Infra.Database.csproj", "src/Estetica.Infra.Database/"]
RUN dotnet restore "./src/Estetica.Api/Estetica.Api.csproj"
COPY . .
WORKDIR "/src/src/Estetica.Api"
RUN dotnet build "./Estetica.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Estetica.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Estetica.Api.dll"]