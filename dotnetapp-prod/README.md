# .NET Core Docker Production Sample

This .NET Core Docker sample demonstrates a best practice pattern for building Docker images for .NET Core apps for production. The sample works with both Linux and Windows containers.

The [sample Dockerfile](Dockerfile) creates an .NET Core application Docker image based off of the [.NET Core Runtime Docker base image](https://hub.docker.com/r/microsoft/dotnet/).

It uses the [Docker multi-stage build feature](https://github.com/dotnet/announcements/issues/18) to build the sample in a container based on the larger [.NET Core SDK Docker base image](https://hub.docker.com/r/microsoft/dotnet/) and then copies the final build result into a Docker image based on the smaller [.NET Core Docker Runtime base image](https://hub.docker.com/r/microsoft/dotnet/). The SDK image contains tools that are required to build applications while the runtime image does not.

This sample requires [Docker 17.06](https://docs.docker.com/release-notes/docker-ce) or later of the [Docker client](https://www.docker.com/products/docker). You need the latest Windows 10 or Windows Server 2016 to use [Windows containers](http://aka.ms/windowscontainers). The instructions assume you have the [Git](https://git-scm.com/downloads) client installed.

## Getting the sample

The easiest way to get the sample is by cloning the samples repository with git, using the following instructions. You can also just download the repository (it is small) as a zip from the [.NET Core Docker samples](https://github.com/dotnet/dotnet-docker-samples/) respository.

```console
git clone https://github.com/dotnet/dotnet-docker-samples/
```

## Build and run the sample with Docker

You can build and run the sample in Docker using the following commands. The instructions assume that you are in the root of the repository.

```console
cd dotnetapp-prod
docker build -t dotnetapp-prod .
docker run --rm dotnetapp-prod Hello .NET Core from Docker
```

Note: The instructions above work for both Linux and Windows containers. The .NET Core docker images use [multi-arch tags](https://github.com/dotnet/announcements/issues/14), which abstract away different operating system choices for most use-cases.

## Build on Windows or macOS and run the sample with Docker on Linux + ARM32 (Raspberry Pi)

The goal of this section is to create and run a Docker .NET Core runtime-based image on a Raspberry Pi running Linux. The .NET Core SDK does not run on the Linux + ARM32 configuration. As a result, the instructions used for X64 don't work. There are multiple ways to get around this limitation, primarily:

* Build app on X64 and copy via scp (or pscp) to ARM32 device and then build and run a Docker runtime image on the ARM32 device, or
* Build final ARM32 image on Windows, push image to a Docker registry and then pull and run from the ARM32 device.

The second option is only supported on Windows. Linux and macOS user must use the first option. For simplicity, the Windows option is provided below.

The instructions assume that you are in the root of the repository.

Type the following commands in Docker "Linux mode" on Windows. The instructions assume that you have a personal Docker user account called `mydockername`. You will need to change that to your actual docker account name, such as [richlander](https://hub.docker.com/u/richlander/) in the case of the author of this sample. You will also need to create a Docker repo called `dotnetapp-prod-arm32`. You can create new repos in the Docker web UI.

You need to be signed into the Docker client to `docker push` to Docker Hub.

```console
cd dotnetapp-prod
docker build -t mydockername/dotnetapp-prod-arm32 -f Dockerfile.arm32 .
docker push mydockername/dotnetapp-prod-arm32
```

Switch to your Raspberry Pi, with Linux and Docker installed. Type the following command.

```console
docker run --rm mydockername/dotnetapp-prod-arm32 Hello .NET Core from Docker
```

## Build and run the sample locally

You can build and run the sample locally with the [.NET Core 2.0 SDK](https://www.microsoft.com/net/download/core) using the following instructions. The instructions assume that you are in the root of the repository.

```console
cd dotnetapp-prod
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
* [microsoft/dotnet:2.0-runtime](https://hub.docker.com/r/microsoft/dotnet)

## Related Resources

* [ASP.NET Core Production Docker sample](../aspnetapp/README.md)
* [.NET Core Docker samples](../README.md)
* [.NET Framework Docker samples](https://github.com/Microsoft/dotnet-framework-docker-samples)
