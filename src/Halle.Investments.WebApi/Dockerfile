#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Halle.Investments.WebApi/Halle.Investments.WebApi.csproj", "src/Halle.Investments.WebApi/"]
COPY ["src/Halle.Investments.Application/Halle.Investments.Application.csproj", "src/Halle.Investments.Application/"]
COPY ["src/Halle.Investments.Domain/Halle.Investments.Domain.csproj", "src/Halle.Investments.Domain/"]
COPY ["src/Halle.Investments.Persistence/Halle.Investments.Infraestructure.csproj", "src/Halle.Investments.Persistence/"]
RUN dotnet restore "./src/Halle.Investments.WebApi/./Halle.Investments.WebApi.csproj"
COPY . .
WORKDIR "/src/src/Halle.Investments.WebApi"
RUN dotnet build "./Halle.Investments.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Halle.Investments.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Halle.Investments.WebApi.dll"]