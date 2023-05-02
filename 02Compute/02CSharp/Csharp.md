# C#

## What is C#?
It is a strongly typed, object oriented language by Microsoft. It is one of the .NET compliant languages, part of .NET Platform.
.NET Platform is a development platform, comprising of languages, standards, frameworks, runtime/sdk, integrated development environment (IDE), etc.

**Common Language Runtime (CLR)** is a runtime in .NET Platform  

**Strong Typing** is when you have to declare what Type of a variable is, for each variable

.NET SDK (Software Development Kit) is a CLI tool that has many different functionalities for creating .NET applications


## Commonly Used .NET SDK Commands
- `dotnet new console -n MyApp`
    - to create a new console application with the name "MyApp"
- `dotnet run`
    - to restore/build/run your program in debug configuration 
- `dotnet publish`
    - restores, and builds deployable artifacts for deploying to different machines
    - ex: `dotnet publish -c Release -o MyApp`


## Steps to deploy your .NET Application
1. Get artifacts for your application via `dotnet publish` command
2. move those artifacts to your VM via scp
3. Make sure your vm has dotnet sdk
4. run the .dll file via `dotnet path-to-dll`