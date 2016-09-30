dotnetbot-prod Sample
=====================

The dotnetbot-prod sample demonstrates basic "hello world" usage of .NET Core. It shows you how you can deploy a .NET Core app relying only on the .NET Core Runtime (as opposed to the .NET Core SDK).

Script
------

Follow these steps to try out this sample. The instructions are intended to be Operating System agnostic, unless called out. They assume that you already have the [.NET Core SDK](https://dot.net/core) and Git and [Docker](https://www.docker.com/products/docker) clients installed.

**Preparing your Environment**

1. Git clone this repository or otherwise copy this sample to your machine: `git clone https://github.com/dotnet/docker-samples/`
2. Navigate to this sample on your machine at the command prompt or terminal.

**Build and Run the application locally**

3. Restore dependencies: `dotnet restore`
4. You can optionally run the application to see what it does: 'dotnet run'.
5. Build the application: `dotnet build -c Release`
6. Publish the application to ensure that all dependencies are included in the bin directory: `dotnet publish`
   - Publishing is not needed in this example since the app has no dependencies beyond the .NET Runtime, but most applications won't be this simple.
7. Optionally, you can run the application from the publish directory (which is what you will use for the Docker image): `dotnet bin/Release/Debug/netcoreapp1.0/publish/dotnetbot-prod.dll`.

**Dockerize the application**

8. Build the Docker image
   - Commandline for Mac and Linux: `docker build -t dotnetbot-prod .`
   - Commandline for Windows to build a Nano image: `docker build -t dotnetbot-prod -f Dockerfile.nano .`
   - Commandline for Windows to build a Windows Server image: `docker build -t dotnetbot-prod -f Dockerfile.servercore .`

**Run the container**

9. Run the application in the container: `docker run dotnetbot-prod Hello .NET Core from Docker`
