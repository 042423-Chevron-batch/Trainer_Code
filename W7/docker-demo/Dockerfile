#stage 1
#make the .net 7.0 the foudational image for this build.
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
#create a new directory called app adn cd into it.
WORKDIR /app
#tell the devs that the app will be found on this port.
EXPOSE 5158
# sets the port as an ENVIRONMENT var that will be used by the app by default.
ENV ASPNETCORE_URLS=http://+:5158

# stage 2
# bring in the sdk and give it an alias (build)
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
# change the wriking directory
WORKDIR /src
#copy the .csproj from outside the container to inside and src directory inside the container.
COPY ["docker-demo.csproj", "./"]
# restore the app dependencies based on the .csproj 
RUN dotnet restore "docker-demo.csproj"
# now copy everything else into the src folder.
COPY . .
# set workdir to where we are??
WORKDIR "/src/."
#build the app
RUN dotnet build "docker-demo.csproj" -c Release -o /app/build

#stage 3
#pull in the build stage and build onto it.
FROM build AS publish
#publish and save the .exe to a publish directory inside app and next to src..
RUN dotnet publish "docker-demo.csproj" -c Release -o /app/publish /p:UseAppHost=false

#stage 4
#use the base stage and give it an alias
FROM base AS final
#change wrok dir to app
WORKDIR /app
#copy everything from the publish folder to the app folder
COPY --from=publish /app/publish .
#start the app.
ENTRYPOINT ["dotnet", "docker-demo.dll"]
