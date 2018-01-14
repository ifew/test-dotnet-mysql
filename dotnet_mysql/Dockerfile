FROM microsoft/dotnet:sdk AS api
WORKDIR /app

COPY ./ ./
RUN dotnet restore
RUN dotnet build
RUN dotnet publish -c Release
ENTRYPOINT ["dotnet", "/app/bin/Release/netcoreapp2.0/dotnet_mysql.dll"]