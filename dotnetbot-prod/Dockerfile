FROM microsoft/dotnet
COPY bin/Debug/netcoreapp1.0/publish app
WORKDIR app
ENTRYPOINT ["dotnet", "dotnetbot-prod.dll"]
