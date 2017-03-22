dotnetapp-selfcontained Sample
==============================

The dotnetapp-selfcontained sample demonstrates how you can build and run the dotnetapp sample as a [self-contained .NET Core application](https://docs.microsoft.com/en-us/dotnet/articles/core/deploying/) that relies only on an operating system image (plus dependencies). It's a good option for creating a Docker image for production.

The instructions assume that you already have [.NET Core 1.0](https://www.microsoft.com/net/download/core#/sdk) and [Git](https://git-scm.com/downloads) and [Docker](https://www.docker.com/products/docker) clients installed. They also assume you already know how to target Linux or Windows containers. Do try both image types. You need the latest Windows 10 or Windows Server 2016 to use [Windows containers](http://aka.ms/windowscontainers).

Instructions
------------

First, prepare your environment by cloning the repository and navigating to the sample:

```console
git clone https://github.com/dotnet/dotnet-docker-samples/
cd dotnet-docker-samples/dotnetapp-selfcontained
```

Follow these steps to run the sample locally:

```console
dotnet restore
dotnet run Hello .NET Core from Docker
```

Follow these steps to build and run the sample locally as a self-contained app on Linux:

```console
dotnet restore
dotnet publish -c Release -o out
./out/dotnetapp
```

Follow these steps to build and run the sample locally as a self-contained app on macOS Sierra:

```console
dotnet restore
dotnet publish -c Release -o out -r osx.10.11-x64
./out/dotnetapp
```

Note: The macOS Sierra instructions should be the same as the Linux instructions. Sierra is not yet fully supported, so requires workarounds until .NET Core is updated.

Follow these steps to build and run the sample locally as a self-contained app on Windows:

```console
dotnet restore
dotnet publish -c Release -o out
out\dotnetapp.exe
```

Follow these steps to run this sample in a Linux container:

```console
dotnet restore
dotnet publish -c Release -o out -r debian.8-x64
docker build -t dotnetapp .
docker run dotnetapp Hello .NET Core from Docker
```

Follow these steps to run this sample in a  Windows container:

```console
dotnet restore
dotnet publish -c Release -o out -r win7-x64
docker build -t dotnetapp -f Dockerfile.nano .
docker run dotnetapp Hello .NET Core from Docker
```

Notes
-----

Self-contained applications are very similar to framework-dependent applications from a source code perspective. They only differ in terms of their reference to the .NET Core metapackage. Framework-dependent applications include a `"type": "platform"' property and standalone apps do not. The commands used to publish both apps are the same.

Self-contained apps are operating system- and chip-specific after they are published. The -r argument instructs the publish command to select the correct native assets to include. See [.NET Core Runtime IDentifier (RID) catalog](https://docs.microsoft.com/dotnet/articles/core/rid-catalog) for more information. 

The `runtimes` node in project.json lists the suppored RIDs for a given app. A large set is listed in this sample to enable it to be uses on multiple operating systems. 
