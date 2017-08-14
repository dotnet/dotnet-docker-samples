# .NET Core Development Sample

This .NET Core Docker sample demonstrates how to use Docker in your .NET Core development process. The sample works with both Linux and Windows containers.

The [sample Dockerfile](Dockerfile) creates a .NET Core application image based off of the [.NET Core SDK Docker base image](https://hub.docker.com/r/microsoft/dotnet/). It builds and runs the application with the same image, which is a useful strategy for interative development but not optimal for production. Take a look at the [.NET Core Production Sample](../dotnetapp-prod/README.md) or [ASP.NET Core Production Sample](../aspnetapp/README.md) for production-oriented samples.

This sample requires [Docker 17.06](https://docs.docker.com/release-notes/docker-ce) or later of the [Docker client](https://www.docker.com/products/docker). You need the latest Windows 10 or Windows Server 2016 to use [Windows containers](http://aka.ms/windowscontainers). The instructions assume you have the [Git](https://git-scm.com/downloads) client installed.

## Getting the sample

The easiest way to get the sample is by cloning the samples repository with git, using the following instructions. You can also just download the repository (it is small) as a zip from the [.NET Core Docker samples](https://github.com/dotnet/dotnet-docker-samples/) respository.

```console
git clone https://github.com/dotnet/dotnet-docker-samples/
```

## Build and run the sample with Docker

You can build and run the sample in Docker using the following commands. The instructions assume that you are in the root of the repository.

```console
cd dotnetapp-dev
docker build -t dotnetapp-dev .
docker run --rm dotnetapp-dev Hello .NET Core from Docker
```

Note: The instructions above work for both Linux and Windows containers. The .NET Core docker images use [multi-arch tags](https://github.com/dotnet/announcements/issues/14), which abstract away different operating system choices for most use-cases.

## Build and run the sample locally

You can build and run the sample locally with the [.NET Core 2.0 SDK](https://www.microsoft.com/net/download/core) using the following instructions. The instructions assume that you are in the root of the repository.

```console
cd dotnetapp-dev
dotnet run Hello .NET Core
```

You can produce an application that is ready to deploy to production locally using the following command.

```console
dotnet publish -c release -o published
```

You can run the application on **Windows** using the following command.

```console
dotnet published\dotnetapp.dll
```

You can run the application on **Linux or macOS** using the following command.

```console
dotnet published/dotnetapp.dll
```

Note: The `-c release` argument builds the application in release mode (the default is debug mode). See the [dotnet run reference](https://docs.microsoft.com/dotnet/core/tools/dotnet-run) for more information on commandline parameters.

## Docker Images used in this sample

The following Docker images are used in this sample

* [microsoft/dotnet:2.0-sdk](https://hub.docker.com/r/microsoft/dotnet)

## Related Resources

* [.NET Core Docker samples](../README.md)
* [.NET Framework Docker samples](https://github.com/Microsoft/dotnet-framework-docker-samples)
