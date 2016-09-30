dotnetbot-selfcontained Sample
==============================

The dotnetbot-prod sample demonstrates basic "hello world" usage of .NET Core. It shows you how you can create and deploy a self-contained .NET Core app relying only on the operating system image. The Linux image has several .NET Core dependencies installed (for example, OpenSSL).

Script
------

Follow these steps to try out this sample. The instructions are intended to be Operating System agnostic, unless called out. They assume that you already have the [.NET Core SDK](https://dot.net/core) and Git and [Docker](https://www.docker.com/products/docker) clients installed.

**Preparing your Environment**

1. Git clone this repository or otherwise copy this sample to your machine: `git clone https://github.com/dotnet/docker-samples/`
2. Navigate to this sample on your machine at the command prompt or terminal.

**Build and Run the application locally**

3. Restore dependencies: `dotnet restore`
4. Run application: `dotnet run`
5. Alternatively, you can build and directly run your application with the following two commands:
   - `dotnet build`
   - `dotnet bin/Debug/netcoreapp1.0/dotnetbot-selfcontained.dll`
6. Publish the application to ensure that all dependencies are included in the bin directory: `dotnet publish`
7. Optionally, you can run the application from the publish directory (which is what you will use for the Docker image): `dotnet bin/Debug/netcoreapp1.0/publish/dotnetbot-selfcontained.dll`

**Dockerize the application**

8. Build the Docker image
   - Commandline for Mac and Linux: `docker build -t dotnetbot-selfcontained .`
   - Commandline for Windows to build a Nano image: `docker build -t dotnetbot-selfcontained -f Dockerfile.nano .`
   - Commandline for Windows to build a Windows Server image: `docker build -t dotnetbot-selfcontained -f Dockerfile.servercore .`

**Run the container**

9. Run the application in the container: `docker run dotnetbot-selfcontained Hello .NET Core from Docker`
