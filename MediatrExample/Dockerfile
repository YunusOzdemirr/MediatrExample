FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MediatrExample/MediatrExample.csproj", "../MediatrExample/"]
RUN dotnet restore "MediatrExample/MediatrExample.csproj"
COPY . .
WORKDIR "/src/MediatrExample"
RUN dotnet build "MediatrExample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MediatrExample.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MediatrExample.dll"]
