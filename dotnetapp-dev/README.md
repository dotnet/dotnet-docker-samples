dotnetapp-dev Sample
====================

The dotnetapp-dev sample demonstrates how you can build and run the dotnetapp sample using the [.NET Core SDK Docker image](https://hub.docker.com/r/microsoft/dotnet/). It's a great option for iterative development if you want to use a container as your development environment. It's also great way to get started with .NET Core, because of the convenience and simplicity. You don't even need .NET Core installed on your local machine to use it.  

The instructions assume that you already have [.NET Core 1.1](https://www.microsoft.com/net/download/core#/sdk), [Git](https://git-scm.com/downloads), and [Docker](https://www.docker.com/products/docker) installed. They also assume you already know how to target Linux or Windows containers. Please do try both image types. You need the latest Windows 10 or Windows Server 2016 to use [Windows containers](http://aka.ms/windowscontainers).

Instructions
------------

First, prepare your environment by cloning the repository and navigating to the sample:

```console
git clone https://github.com/dotnet/dotnet-docker-samples/
cd dotnet-docker-samples/dotnetapp-dev
```

Follow these steps to run this sample locally:

```console
dotnet restore
dotnet run Hello .NET Core
```

Follow these steps to run this sample in a Linux container:

```console
docker build -t dotnetapp .
docker run dotnetapp Hello .NET Core from Docker
```

Follow these steps to run this sample in a  Windows container:

```console
docker build -t dotnetapp -f Dockerfile.nano .
docker run dotnetapp Hello .NET Core from Docker
```
