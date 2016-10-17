dotnetapp-prod Sample
=====================

The dotnetapp-prod sample demonstrates basic "hello world" usage of .NET Core. It shows you how you can build and deploy it relying only on the .NET Core Runtime (as opposed to the .NET Core SDK).

Script
------

Follow these steps to try out this sample. The instructions are operating system agnostic unless called out. They assume that you already have the [.NET Core SDK](https://dot.net/core) and [Git](https://git-scm.com/downloads) and [Docker](https://www.docker.com/products/docker) clients installed.

The instructions assume you already know how to target Linux or Windows containers. Do try both, however, you need your environment correctly configured. You can only try Windows containers on the latest Windows 10 or Windows Server 2016.

**Preparing your Environment**

1. Git clone this repository or otherwise copy this sample to your machine: `git clone https://github.com/dotnet/docker-samples/`
2. Navigate to this sample on your machine at the command prompt or terminal.

**Build and Run the application locally**

1. Restore dependencies: `dotnet restore`
2. Run the application: `dotnet run`
   - Alternatively, you can test run your application with the following two commands:
   - `dotnet build`
   - `dotnet bin/Debug/netcoreapp1.0/dotnetapp.dll`

**Publish the application**

1. Publish the application to ensure that all dependencies are included in the bin/../publish directory. Use the following command: `dotnet publish -c Release`.
2 . Optionally, you can run/test the application from the publish directory using the following command: `dotnet bin\Release\netcoreapp1.0\publish\dotnetapp.dll`. 

**Build and run Docker image**

1. Build the Docker image
   - Commandline to create Docker image for Linux: `docker build -t dotnetapp .`
   - Commandline to create Docker image for Nano: `docker build -t dotnetapp -f Dockerfile.nano .`
2. Run the image: `docker run dotnetapp Hello .NET Core from Docker`
