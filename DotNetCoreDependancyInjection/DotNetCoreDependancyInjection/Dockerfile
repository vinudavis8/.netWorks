FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["DotNetCoreDependancyInjection/DotNetCoreDependancyInjection.csproj", "DotNetCoreDependancyInjection/"]
RUN dotnet restore "DotNetCoreDependancyInjection/DotNetCoreDependancyInjection.csproj"
COPY . .
WORKDIR "/src/DotNetCoreDependancyInjection"
RUN dotnet build "DotNetCoreDependancyInjection.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "DotNetCoreDependancyInjection.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DotNetCoreDependancyInjection.dll"]