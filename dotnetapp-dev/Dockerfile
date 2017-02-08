FROM microsoft/dotnet:1.1-sdk-msbuild
WORKDIR /app

# copy csproj and restore as distinct layers
COPY dotnetapp.csproj .
RUN dotnet restore

# copy and build everything else
COPY . .
RUN dotnet publish -c Release -o out
ENTRYPOINT ["dotnet", "out/dotnetapp.dll"]
