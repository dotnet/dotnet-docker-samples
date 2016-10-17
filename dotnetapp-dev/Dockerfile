FROM microsoft/dotnet:1.0.0-preview2-sdk
WORKDIR /app

# copy project.json and restore as distinct layers
COPY project.json .
RUN dotnet restore

# copy and build everything else
COPY . .
RUN dotnet build -c Release
ENTRYPOINT ["dotnet", "bin/Release/netcoreapp1.0/dotnetapp.dll"]
