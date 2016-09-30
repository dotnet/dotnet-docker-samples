dotnetbot Sample
================

The dotnetbot sample demonstrates basic "hello world" usage of .NET Core. It relies on the .NET Core SDK in the base Docker image to build and run the sample. You don't even need .NET Core installed on your local machine to use it. It's a great way to get started with .NET Core. It's also a good option for iterative development if you want to use a container as your development environment.

Script
------

Follow these steps to try out this sample. The instructions are intended to be Operating System agnostic, unless called out. They assume that you already have Git and [Docker](https://www.docker.com/products/docker) clients installed.

**Preparing your Environment**

1. Git clone this repository or otherwise copy this sample to your machine: `git clone https://github.com/dotnet/docker-samples/`
2. Navigate to this sample on your machine at the command prompt or terminal.

**Dockerize the application**

3. Build the Docker image
   - Commandline for Mac and Linux: `docker build -t dotnetbot .`
   - Commandline for Windows to build a Nano image: `docker build -t dotnetbot -f Dockerfile.nano .`
   - Commandline for Windows to build a Windows Server image: `docker build -t dotnetbot -f Dockerfile.servercore .`

**Run the container**

4. Run the application in the container: `docker run dotnetbot Hello .NET Core from Docker`
