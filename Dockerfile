FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["NetCoreDemo.csproj", ""]
RUN dotnet restore "./NetCoreDemo.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "NetCoreDemo.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "NetCoreDemo.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "NetCoreDemo.dll"]