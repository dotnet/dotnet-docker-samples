FROM microsoft/dotnet:2.0-sdk AS build-env
WORKDIR /app

# copy csproj and restore as distinct layers
COPY nuget.config ./
COPY *.csproj ./
RUN dotnet restore

# copy everything else and build
COPY . ./
RUN dotnet publish -c Release -r linux-x64 -o out

# build runtime image
FROM microsoft/dotnet:2.0-runtime-deps
WORKDIR /app
COPY --from=build-env /app/out ./
ENTRYPOINT ["./dotnetapp"]
