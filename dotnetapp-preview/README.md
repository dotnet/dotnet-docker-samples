dotnetapp-preview Sample
========================

The dotnetapp-preview sample demonstrates basic "hello world" usage of .NET Core. It shows you how you can build and deploy it relying on a preview version of the .NET Core SDK. It is the same as the [dotnetapp-dev](../dotnetapp-preview) sample, but has been updated to require a later version of the .NET Core SDK and depend on a Docker image from the [dotnet-nightly](https://hub.docker.com/r/microsoft/dotnet-nightly/) Docker Hub repo. This repo is where preview .NET Core versions are published.

You don't even need .NET Core installed on your local machine to use this sample. It's a great way to get started with .NET Core. It's also a good option for iterative development if you want to use a container as your development environment.

Script
------

Follow these steps to try out this sample. The instructions are operating system agnostic unless called out. They assume that you already have [Git](https://git-scm.com/downloads) and [Docker](https://www.docker.com/products/docker) clients installed.

The instructions assume you already know how to target Linux or Windows containers. Do try both, however, you need your environment correctly configured. You can only try Windows containers on the latest Windows 10 or Windows Server 2016.

**Preparing your Environment**

1. Git clone this repository or otherwise copy this sample to your machine: `git clone https://github.com/dotnet/dotnet-docker-samples/`
2. Navigate to this sample on your machine at the command prompt or terminal.

**Build and run Docker image**

1. Build the Docker image
   - Commandline for Mac and Linux: `docker build -t dotnetapp .`
   - Commandline for Windows to build a Nano image: `docker build -t dotnetapp -f Dockerfile.nano .`
2. Run the application in the container: `docker run dotnetapp Hello .NET Core from Docker`
