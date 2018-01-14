# MySQL
- ENV MYSQL_DATABASE dotnet_mysql
- ENV MYSQL_ROOT_USER root
- ENV MYSQL_ROOT_PASSWORD 1234
- ENV MYSQL_USER ifew
- ENV MYSQL_PASSWORD 1234

``docker build -t dotnet_mysql_db -f Dockerfile_mysql .``

``docker run -it -p 3306:3306 -v /Users/ifew/www_test/test-dotnet/dotnet-mysql/dotnet_mysql/data_mysql:/var/lib/mysql --name dotnet_mysql_db dotnet_mysql_db``

# Web
``docker build -t dotnet_mysql_web .``

## Development
``docker run -p 5000:5000 -e ASPNETCORE_ENVIRONMENT=Development -name dotnet_mysql_webdev dotnet_mysql_web``

## UAT
``docker run -p 5100:5000 -e ASPNETCORE_ENVIRONMENT=Uat -name dotnet_mysql_webuat dotnet_mysql_web``