FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["misitfy_2.0/misitfy_2.0.csproj", "misitfy_2.0/"]
RUN dotnet restore "misitfy_2.0/misitfy_2.0.csproj"
COPY . .
WORKDIR "/src/misitfy_2.0"
RUN dotnet build "misitfy_2.0.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "misitfy_2.0.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "misitfy_2.0.dll"]
