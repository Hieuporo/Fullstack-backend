#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["StoreProject.Api/StoreProject.Api.csproj", "StoreProject.Api/"]
COPY ["StoreProject.Application/StoreProject.Application.csproj", "StoreProject.Application/"]
COPY ["StoreProject.Domain/StoreProject.Domain.csproj", "StoreProject.Domain/"]
COPY ["StoreProject.Infrastructure/StoreProject.Infrastructure.csproj", "StoreProject.Infrastructure/"]
RUN dotnet restore "StoreProject.Api/StoreProject.Api.csproj"
COPY . .
WORKDIR "/src/StoreProject.Api"
RUN dotnet build "StoreProject.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StoreProject.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StoreProject.Api.dll"]