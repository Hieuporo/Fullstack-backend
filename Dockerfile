# FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
# WORKDIR /base-netcore
# COPY . .
# RUN dotnet restore "./StoreProject.Application/StoreProject.Application.csproj" --disable-parallel
# RUN dotnet publish "./StoreProject.Application/StoreProject.Application.csproj" -c release -o /app --no-restore
# # Serve Stage
# FROM mcr.microsoft.com/dotnet/aspnet:7.0
# WORKDIR /app
# COPY --from=build /app ./
# EXPOSE 5000
# RUN ls /app
# ENTRYPOINT [ "dotnet", "StoreProject.Application.dll", "--urls", "http://0.0.0.0:5000" ]
