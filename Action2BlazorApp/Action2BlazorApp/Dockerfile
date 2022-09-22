#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Action2BlazorApp/Action2BlazorApp.csproj", "Action2BlazorApp/"]
RUN dotnet restore "Action2BlazorApp/Action2BlazorApp.csproj"
COPY . .
WORKDIR "/src/Action2BlazorApp"
RUN dotnet build "Action2BlazorApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Action2BlazorApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Action2BlazorApp.dll"]