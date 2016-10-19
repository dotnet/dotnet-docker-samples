dotnetapp-selfcontained Sample
==============================

The dotnetapp-selfcontained sample demonstrates basic "hello world" usage of .NET Core. It shows you how you can build and deploy it as self-contained .NET Core app relying on the operating system image.

Script
------

Follow these steps to try out this sample. The instructions are operating system agnostic unless called out. They assume that you already have the [.NET Core SDK](https://dot.net/core) and [Git](https://git-scm.com/downloads) and [Docker](https://www.docker.com/products/docker) clients installed.

The instructions assume you already know how to target Linux or Windows containers. Do try both, however, you need your environment correctly configured. You can only try Windows containers on the latest Windows 10 or Windows Server 2016.

**Preparing your Environment**

1. Git clone this repository or otherwise copy this sample to your machine: `git clone https://github.com/dotnet/dotnet-docker-samples/`
2. Navigate to this sample on your machine at the command prompt or terminal.

**Build and Test the application locally**

1. Restore dependencies: `dotnet restore`
2. Run the application: `dotnet run`
   - Alternatively, you can test run your application with the following two commands:
   - `dotnet build`
   - `dotnet bin/Debug/netcoreapp1.0/dotnetapp.dll`

**Publish the application**

1. Publish the application to ensure that all dependencies are included in the bin/../publish directory. This is necessary for the application to be "self contained".
   - If publishing for Debian, use the following command: `dotnet publish -c Release -r debian.8-x64`
   - If publishing for Windows, use the following command: `dotnet publish -c Release -r win10-x64`
   - Note, you can skip the `-r` argument if your current and target operating system are the same (or same enough).
2 . Optionally, you can run/test the application from the publish directory using the following command: `dotnet bin\Release\netcoreapp1.0\win10-x64\publish\dotnetapp.dll`. 
   - This will only work if your current and target operating are the same (or same enough).

Note: Self-contained apps are operating system- and chip-specific after they are published. You can see that the Dockerfiles are configured to select specific assets produced by the publish verb. The -r argument instructs the publish command to select the correct native assets to include. See [.NET Core Runtime IDentifier (RID) catalog](https://docs.microsoft.com/dotnet/articles/core/rid-catalog) for more information.

**Build and run Docker image**

1. Build the Docker image
   - Commandline to create Docker image for Linux: `docker build -t dotnetbot .`
   - Commandline to create Docker image for Nano: `docker build -t dotnetbot -f Dockerfile.nano .`
2. Run the image: `docker run dotnetbot Hello .NET Core from Docker`
