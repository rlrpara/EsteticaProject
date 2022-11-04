FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/VendaFacil.Api/VendaFacil.Api.csproj", "src/VendaFacil.Api/"]
COPY ["src/VendaFacil.CrossCutting.Ioc/VendaFacil.CrossCutting.Ioc.csproj", "src/VendaFacil.CrossCutting.Ioc/"]
COPY ["src/VendaFacil.Service/VendaFacil.Service.csproj", "src/VendaFacil.Service/"]
COPY ["src/VendaFacil.CrossCutting.Util/VendaFacil.CrossCutting.Util.csproj", "src/VendaFacil.CrossCutting.Util/"]
COPY ["src/VendaFacil.Domain/VendaFacil.Domain.csproj", "src/VendaFacil.Domain/"]
COPY ["src/VendaFacil.Infra.Data/VendaFacil.Infra.Data.csproj", "src/VendaFacil.Infra.Data/"]
COPY ["src/VendaFacil.Infra.Database/VendaFacil.Infra.Database.csproj", "src/VendaFacil.Infra.Database/"]
RUN dotnet restore "src/VendaFacil.Api/VendaFacil.Api.csproj"
COPY . .
WORKDIR "/src/src/VendaFacil.Api"
RUN dotnet build "VendaFacil.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VendaFacil.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VendaFacil.Api.dll"]