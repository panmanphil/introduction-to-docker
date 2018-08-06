# Useful windows images

# Always get these base images first
microsoft/windowsservercore

microsoft/nanoserver

# installing windows 2016 1803 with docker
 https://docs.docker.com/install/windows/docker-ee/

# volume issues for Windows containers

  must be blank folder or not exist
  
  can't do what is normal with linux of replacing an existing folder until union file system is working in Windows
  
  can't map a host network folder either, must be hard drive
  
  cant' replace a single file with -v either like you can do with Linux
  
  Some shells like gitbash mess with windows paths so -v c:\xxxx may get mangled and are not recognized by docker

# Resources:
https://www.jamessturtevant.com/posts/Windows-Containers-Cheat-Sheet/


https://github.com/dotnet/dotnet-docker/

https://docs.microsoft.com/en-us/virtualization/windowscontainers/deploy-containers/version-compatibility
https://github.com/dotnet/dotnet-docker (.net core 2.1+)

https://github.com/dotnet/dotnet-docker/blob/master/samples/aspnetapp/aspnet-docker-dev-in-container.md 

https://github.com/aspnet/aspnet-docker/blob/master/README.aspnetcore-build.md (netcore 2.0 and earlier)

https://docs.docker.com/install/windows/docker-ee/#install-docker-ee (for windows 2016 8103 headless system)

https://github.com/dotnet/dotnet-docker/blob/master/samples/aspnetapp/aspnet-docker-dev-in-container.md (dotnet built in container, auto rebuild on change with dotnet watch)

https://hub.docker.com/u/stefanscherer/

Stephan Scherer (Microsoft MVP) has ported a number of common linux tools to windows containers

also his blog
https://stefanscherer.github.io/

# Node.js issues in a windows container
https://github.com/nodejs/node/issues/8897#issuecomment-298662512 (Node issue with Error: ENOENT: no such file or directory, lstat 'C:\ContainerMappedDirectories'
at Object.realpathSync (fs.js:1430:7))
https://github.com/StefanScherer/dockerfiles-windows/issues/349 (getaddressinfo failure with workaround)


