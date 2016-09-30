.NET Core Docker Samples
========================

This repo contains samples that demonstrate various .NET Core docker configurations. You can use these samples as a basis for creating docker images for your .NET Core apps. It is also the source for the Docker Hub [microsoft/dotnet-core-samples] repo.

You need to have the [.NET Core SDK](https://dot.net/core) and [Docker client](https://www.docker.com/products/docker) installed to use these samples. 

These samples rely on (AKA 'FROM') the [.NET Core Docker images](https://hub.docker.com/r/microsoft/dotnet/) on Dockerhub, provided by the .NET Team at Microsoft. There are multiple images to choose from. They differ on a few different axes that are important to understand. The samples, in large part, exercise these different axes:

- .NET Core distribution - .NET Core SDK, .NET Core Runtime, .NET Core dependencies only
- Operating System - Windows and Linux
- Docker pattern - Regular vs. [ONBUILD](https://docs.docker.com/engine/reference/builder/#onbuild)

Docker uses [docker/whalesay](https://hub.docker.com/r/docker/whalesay/) for its samples. The .NET Core Team at Microsoft uses [dotnetbot](https://github.com/dotnet-bot). dotnetbot is the mascot for .NET open source projects. Got something to say? Both whalesay and dotnetbot are great listeners. 

.NET Core Samples
-----------------

You can pick the sample that best fits the scenario you are interested in. You will notice that each sample supports multiple operating systems via multiple Dockerfiles. The instructions for each sample describe how to target Windows or Linux.

**Getting Started**

- [dotnetapp](dotnetapp) - This sample is the best one to start with. You don't need much knowledge of .NET Core or Docker.

Note: The dotnetapp sample uses the Docker [ONBUILD](https://docs.docker.com/engine/reference/builder/#onbuild) pattern, which makes it easy to create a Docker image by prescribing file names and locations. You are not encouraged to use this example for more than developing familiarity with Docker and .NET Core, not for development or production.

**Development**

- [dotnetbot] - This sample is good for development since it performs `dotnet` commands on your behalf, reducing the time it takes to create Docker images (assuming you make changes and then test them in a container, iteratively). It is very similar to the dotnetapp sample above, but doesn't prescribe filesname (you can change them for your app).

**Production**

- [dotnetbot-prod](dotnetbot-prod)(dotnetbot-prod) - This sample is good for production since it does not include the .NET CLI tools but only the .NET Core Runtime. Most apps only need the runtime, reducing the size of your .NET Core base image.
- [dotnetbot-selfcontained](dotnetbot-selfcontained)- This sample is also good for production scenarios. It's  for deploying [self-contained .NET Core apps](https://docs.microsoft.com/dotnet/articles/core/deploying/), which include .NET Core as part of the app and not as a centrally installed component in a base image.

Note: The dotnetbot-prod sample is best for scenarios where there are multiple .NET Core containers being hosted in an environment, to enable sharing of base images, including the .NET Core Runtime. If there is just one or a few .NET Core containers, then the dotnetbot-selfcontained sample could be a better choice.

Note: The current tools for creasing [self-contained .NET Core apps](https://docs.microsoft.com/dotnet/articles/core/deploying/) is not yet optimal. These tools will be improved so that self-contained apps are much smaller.