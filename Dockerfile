#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["/training-broker.integration.api/training-broker.integration.api.csproj", "/src/training-broker.integration.api/"]
COPY ["/training-broker.integration.handler/training-broker.integration.handler.csproj", "/src/training-broker.integration.handler/"]
COPY ["/training-broker.integration.infrastructure/training-broker.integration.infrastructure.csproj", "/src/training-broker.integration.infrastructure/"]
RUN dotnet restore "/src/training-broker.integration.api/training-broker.integration.api.csproj"
COPY . .
WORKDIR "/src/training-broker.integration.api"
RUN dotnet build "training-broker.integration.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "training-broker.integration.api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
ENV TZ="America/Bogota"
ENV ASPNETCORE_ENVIRONMENT="Development"
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "training-broker.integration.api.dll"]