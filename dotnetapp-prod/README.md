dotnetapp-prod Sample
=====================

The dotnetapp-prod sample demonstrates how you can build and run the dotnetapp sample using the [.NET Core Runtime Docker image](https://hub.docker.com/r/microsoft/dotnet/). It's a great option for creating a Docker image for production.

The instructions assume that you already have [.NET Core 1.0 RC4](https://github.com/dotnet/core/blob/master/release-notes/rc4-download.md) and [Git](https://git-scm.com/downloads) and [Docker](https://www.docker.com/products/docker) clients installed. They also assume you already know how to target Linux or Windows containers. Do try both image types. You need the latest Windows 10 or Windows Server 2016 to use [Windows containers](http://aka.ms/windowscontainers).

Instructions
------------

First, prepare your environment by cloning the repository and navigating to the sample:

```console
git clone https://github.com/dotnet/dotnet-docker-samples/
cd dotnet-docker-samples/dotnetapp-prod
```

Follow these steps to run the sample locally:

```console
dotnet restore
dotnet run Hello .NET Core from Docker
```

Follow these steps to run this sample in a Linux container:

```console
dotnet restore
dotnet publish -c Release -o out
docker build -t dotnetapp .
docker run dotnetapp Hello .NET Core from Docker
```

Follow these steps to run this sample in a  Windows container:

```console
dotnet restore
dotnet publish -c Release -o out
docker build -t dotnetapp -f Dockerfile.nano .
docker run dotnetapp Hello .NET Core from Docker
```
