# .NET Core Docker Samples

This repo contains samples that demonstrate various .NET Core Docker configurations, which you can use as the basis of your own Docker images. They are also generally useful .NET Core samples and provide instructions for use with and without Docker.

These samples depend on the [.NET Core Docker images](https://hub.docker.com/r/microsoft/dotnet/) on Docker Hub, provided by the .NET Team at Microsoft.

Docker uses [docker/whalesay](https://hub.docker.com/r/docker/whalesay/) as a getting started sample. The .NET Core Team at Microsoft uses [dotnetbot](https://github.com/dotnet-bot), which is the mascot for .NET open source projects. Got something to say? Both whalesay and dotnetbot are great listeners. The [dotnetapp-dev](dotnetapp-dev), [dotnetapp-prod](dotnetapp-prod), and [dotnetapp-selfcontained](dotnetapp-selfcontained) samples all simply print a "Welcome!" message to the console. The [aspnetapp](aspnetapp) sample starts a basic ASP.NET Core website running in a container that you can browse to locally.

You can pick the sample that best fits the scenario you are interested in. The instructions for each sample describe how to target [Windows](http://aka.ms/windowscontainers) or Linux Docker images, from Windows, Linux or macOS.

The samples use .NET Core 2.0. They use Docker [multi-stage build](https://github.com/dotnet/announcements/issues/18) and [multi-arch tags](https://github.com/dotnet/announcements/issues/14) where appropriate.

You need to have the [.NET Core SDK](https://www.microsoft.com/net/download/core#/sdk) and [Git](https://git-scm.com/downloads) and [Docker client 17.06 or newer](https://www.docker.com/products/docker) clients installed to use these samples.

## Getting Started

You can run a [sample application](https://hub.docker.com/r/microsoft/dotnet-samples/) that runs from a pre-built image that has been published to Docker Hub. The source of this sample application is the [dotnetapp-prod](dotnetapp-prod) sample.

To run the **Linux** image:

```console
docker run microsoft/dotnet-samples
```

To run the **Windows** image:

```console
docker run microsoft/dotnet-samples:dotnetapp-nanoserver
```

It is recomended to run the sample twice. The second run will not include downloading the image, so is more representative of typical Docker use.

## Samples

The following samples show different ways to use .NET Core images.

### Development

* [.NET Core Development Sample](dotnetapp-dev) - This sample is good for development and building since it relies on the .NET Core SDK image. It performs `dotnet` commands on your behalf, reducing the time it takes to create Docker images (assuming you make changes and then test them in a container, iteratively).

### Production

* [.NET Core Docker Production Sample](dotnetapp-prod) - This sample is good for production since it relies on the .NET Core Runtime image, not the larger .NET Core SDK image. Most apps only need the runtime, reducing the size of your application image.
* [.NET Core self-contained application Docker Production Sample](dotnetapp-selfcontained) - This sample is also good for production scenarios since it relies on an operating system image (without .NET Core). [Self-contained .NET Core apps](https://docs.microsoft.com/dotnet/articles/core/deploying/) include .NET Core as part of the app and not as a centrally installed component in a base image.
* [ASP.NET Core Docker Production Sample](aspnetapp) - This samples demonstrates a Dockerized ASP.NET Core Web App.

### ARM32 / Raspberry Pi

* [.NET Core Docker Production Sample](dotnetapp-prod) - This sample includes instructions for running a runtime image with Linux on a Raspberry Pi.
* [.NET Core self-contained application Docker Production Sample](dotnetapp-selfcontained) - This sample includes instructions for running a self-contained image with Linux on a Raspberry Pi.
* Related: See [.NET Core on Raspberry Pi](https://github.com/dotnet/core/blob/master/samples/RaspberryPiInstructions.md)

## Related Repositories

See the following related Docker Hub repos:

* [microsoft/dotnet](https://hub.docker.com/r/microsoft/dotnet/) for .NET Core images.
* [microsoft/dotnet-samples](https://hub.docker.com/r/microsoft/dotnet-samples/) for .NET Core sample images.
* [microsoft/aspnetcore](https://hub.docker.com/r/microsoft/aspnetcore/) for ASP.NET Core images.
* [microsoft/aspnet](https://hub.docker.com/r/microsoft/aspnet/) for ASP.NET Web Forms and MVC images.
* [microsoft/dotnet-framework](https://hub.docker.com/r/microsoft/dotnet-framework/) for .NET Framework images (for web applications, see microsoft/aspnet).

See the following related GitHub repos:

* [dotnet/announcements](https://github.com/dotnet/announcements/issues?q=is%3Aissue+is%3Aopen+label%3ADocker) for Docker-related announcements.
* [microsoft/dotnet-framework-docker-samples](https://github.com/microsoft/dotnet-framework-docker-samples/) for .NET Framework samples.
