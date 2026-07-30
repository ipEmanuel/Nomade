# Imagen base para correr la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 8080

# Imagen SDK para compilar el código
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["Nomade.csproj", "./"]
RUN dotnet restore "Nomade.csproj"
COPY . .
RUN dotnet build "Nomade.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Nomade.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Crear la imagen final de producción
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Nomade.dll"]