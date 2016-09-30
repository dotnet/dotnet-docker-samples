FROM microsoft/dotnet
COPY bin/Release/netcoreapp1.0/ubuntu.14.04-x64/publish app
WORKDIR app
ENTRYPOINT ["dotnetbot-selfcontained.exe"]       
