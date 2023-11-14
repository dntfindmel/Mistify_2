FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Music/Music.csproj", "Music/"]
RUN dotnet restore "Music/Music.csproj"
COPY . .
WORKDIR "/src/Music"
RUN dotnet build "Music.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Music.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Music.dll"]
