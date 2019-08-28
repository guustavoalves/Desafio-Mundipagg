FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /src
COPY ["Desafio.Mundipagg.WebAPI/Desafio.Mundipagg.WebAPI.csproj", "Desafio.Mundipagg.WebAPI/"]
COPY ["Desafio.Mundipagg.AppService/Desafio.Mundipagg.AppService.csproj", "Desafio.Mundipagg.AppService/"]
COPY ["Desafio.Mundipagg.Domain/Desafio.Mundipagg.Domain.csproj", "Desafio.Mundipagg.Domain/"]
COPY ["Desafio.Mundipagg.Infra/Desafio.Mundipagg.Infra.csproj", "Desafio.Mundipagg.Infra/"]
RUN dotnet restore "Desafio.Mundipagg.WebAPI/Desafio.Mundipagg.WebAPI.csproj"
COPY . .
WORKDIR "/src/Desafio.Mundipagg.WebAPI"
# RUN dotnet build "Desafio.Mundipagg.WebAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Desafio.Mundipagg.WebAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Desafio.Mundipagg.WebAPI.dll"]