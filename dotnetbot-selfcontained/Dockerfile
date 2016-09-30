FROM microsoft/dotnet
COPY bin/Release/netcoreapp1.0/ubuntu-x64/publish app
WORKDIR app
ENTRYPOINT ["dotnetbot-selfcontained.exe"]       
