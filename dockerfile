FROM mcr.microsoft.com/dotnet/core/sdk

WORKDIR /app

COPY . /app

CMD [ "dotnet", "run", "-p", "DevopsCI.Client/DevopsCI.Client.csproj" ]

