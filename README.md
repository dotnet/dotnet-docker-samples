.NET Core Docker Samples
========================

This repo contains samples that demonstrate various .NET Core Docker configurations, which you can use as the basis of your own Docker images. These samples depend on the [.NET Core Docker images](https://hub.docker.com/r/microsoft/dotnet/) on Docker Hub, provided by the .NET Team at Microsoft.

Docker uses [docker/whalesay](https://hub.docker.com/r/docker/whalesay/) as a getting started sample. The .NET Core Team at Microsoft uses [dotnetbot](https://github.com/dotnet-bot), which is the mascot for .NET open source projects. Got something to say? Both whalesay and dotnetbot are great listeners. The [dotnetapp-dev](dotnetapp-dev), [dotnetapp-prod](dotnetapp-prod), [dotnetapp-selfcontained](dotnetapp-selfcontained), and [dotnetapp-current](dotnetapp-current) samples all simply print a "Welcome!" message to the console. The [aspnetapp](aspnetapp) sample starts a basic ASP.NET Core website running in a container that you can browse to locally.

You can pick the sample that best fits the scenario you are interested in. The instructions for each sample describe how to target [Windows](http://aka.ms/windowscontainers) or Linux Docker images, from Windows, Linux or macOS.

You need to have the [.NET Core SDK RC4](https://github.com/dotnet/core/blob/master/release-notes/rc4-download.md) and [Git](https://git-scm.com/downloads) and [Docker client](https://www.docker.com/products/docker) clients installed to use these samples.

### Getting Started

You can run a [sample application](https://hub.docker.com/r/microsoft/dotnet-samples/) (Linux image) that runs from a pre-built image that has been published to Docker Hub. The source of this sample application is the [dotnetapp-prod](dotnetapp-prod) sample.

```console
docker run microsoft/dotnet-samples
```

It is recomended to run the sample twice. The second run will not include downloading the image, so is more representative of typical Docker use.

Samples
-------

The following samples show different ways to use .NET Core images.

### Development

- [dotnetapp-dev](dotnetapp-dev) - This sample is good for development and building since it relies on the .NET Core SDK image. It performs `dotnet` commands on your behalf, reducing the time it takes to create Docker images (assuming you make changes and then test them in a container, iteratively).

### Production

- [dotnetapp-prod](dotnetapp-prod) - This sample is good for production since it relies on the .NET Core Runtime image, not the larger .NET Core SDK image. Most apps only need the runtime, reducing the size of your application image.
- [dotnetapp-selfcontained](dotnetapp-selfcontained) - This sample is also good for production scenarios since it relies on an operating system image (without .NET Core). [Self-contained .NET Core apps](https://docs.microsoft.com/dotnet/articles/core/deploying/) include .NET Core as part of the app and not as a centrally installed component in a base image.
- [dotnetapp-current](dotnetapp-current) - This sample demonstrates how to configure an application to use the .NET Core 1.1 image. Both the .csproj and the Dockerfile have been updated to depend on .NET Core 1.1. This sample is the same as [dotnetapp-prod](dotnetapp-prod) with the exception of relying on a later .NET Core version.
- [aspnetapp](aspnetapp) - This samples demonstrates a Dockerized ASP.NET Core Web App.

Notes
-----

The dotnetbot-prod sample is best for production scenarios where there are multiple .NET Core containers being hosted in an environment, to enable sharing of base images, including the .NET Core Runtime. If there is just one or a few .NET Core containers, then the dotnetbot-selfcontained sample could be a better choice.

The current tools for creating [self-contained .NET Core apps](https://docs.microsoft.com/dotnet/articles/core/deploying/) is not yet optimal. These tools will be improved so that self-contained apps are *much* smaller and also easier to produce.

There is a pattern of names ("-prod", "-selfcontained") established by the samples. They are not suggested as general purpose names, but are used here almost like tags to differentiate multiple usese of the single dotnetapp sample. There is also a pattern of Dockerfile naming (Dockerfile, Dockerfile.nano). This pattern of naming is only needed in cases where an app is deployed to multiple operating system. If your app has only one configuration, you should just use the default "Dockerfile" naming, which is simpler and skips the need for the Docker `-f` argument.

Related Repositories
--------------------

See the following related Docker Hub repos:

- [microsoft/dotnet](https://hub.docker.com/r/microsoft/dotnet/) for .NET Core images.
- [microsoft/dotnet-samples](https://hub.docker.com/r/microsoft/dotnet-samples/) for .NET Core sample images.
- [microsoft/aspnetcore](https://hub.docker.com/r/microsoft/aspnetcore/) for ASP.NET Core images.
- [microsoft/aspnet](https://hub.docker.com/r/microsoft/aspnet/) for ASP.NET Web Forms and MVC images.
- [microsoft/dotnet-framework](https://hub.docker.com/r/microsoft/dotnet-framework/) for .NET Framework images (for web applications, see microsoft/aspnet).

See the following related  GitHub repos:

- [microsoft/dotnet-framework-docker-samples](https://github.com/microsoft/dotnet-framework-docker-samples/) for .NET Framework samples.
