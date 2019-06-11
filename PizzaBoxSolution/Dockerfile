FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS PizzaDomain

WORKDIR /app

COPY PizzaBoxDomain/ ../PizzaBoxDomain

RUN dotnet restore ../PizzaBoxDomain/PizzaBoxDomain.csproj --no-dependencies

RUN dotnet build ../PizzaBoxDomain/PizzaBoxDomain.csproj --no-restore -c Release 

FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS PizzaBoxData

WORKDIR /app

COPY PizzaBoxData/ ../PizzaBoxData

COPY --from=PizzaDomain ./PizzaBoxDomain/ ../PizzaBoxDomain

RUN dotnet restore ../PizzaBoxData/*.csproj

RUN dotnet build ../PizzaBoxData/*.csproj --no-restore -c Release

FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS PizzaBoxClient

WORKDIR /app

COPY PizzaBoxClient/ ../PizzaBoxClient

COPY --from=PizzaDomain ./PizzaBoxDomain/ ../PizzaBoxDomain

COPY --from=PizzaBoxData ./PizzaBoxData/ ../PizzaBoxData

RUN dotnet restore ../PizzaBoxClient/*.csproj

RUN dotnet build ../PizzaBoxClient/*.csproj --no-restore -c Release

RUN dotnet publish ../PizzaBoxClient/*.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS deploy

WORKDIR /app

EXPOSE 80
EXPOSE 443 

COPY --from=PizzaBoxClient PizzaBoxClient/out ./

CMD [ "dotnet", "PizzaBoxClient.dll" ]