# .Net Core Journey

**.Net Core Version 2.1**

This repository is created based on **[ASP.NET core tutorial for beginners](https://www.youtube.com/playlist?list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU)** 
by **[kudvenkat](https://www.youtube.com/channel/UCCTVrRB5KpIiK6V2GGVsR1Q)**

## Notes
#### Ep 6 - [.Net Core in process hosting](https://www.youtube.com/watch?v=ydR2jd3ZaEA&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=6)

Some of the tasks that `CreateDefaultBuilder()` performs
1. Setting up the web server
2. Loading the host and application configuration from various configuration sources and
3. Configuring logging

An .Net Core application can be hosted
- InProcess or
- OutOfProcess 

To configure hosting you can modify `<AspNetCoreHostingModel>InProcess</AspNetCoreHostingModel>` under `.csproj` 
and if this statement does not exist, the default will be `<AspNetCoreHostingModel>OutOfProcess</AspNetCoreHostingModel>`

`CreateDefaultBuilder()` method calls `UseIIS()` method behind the scenes 
and host the app inside of the IIS worker process `iisexpress.exe`(*IISExpress*) or `w3wp.exe` (*IIS*). 

<p align="center">
  <img src="https://i.ibb.co/7KY5BZ5/asp-net-core-in-process-hosting.png">
</p>

To get the process name iisexpress/w3wp executing the app
We can display `System.Diagnostics.Process.GetCurrentProcess().ProcessName`

InProcess hosting delivers significantly higher request throughput than OutOfProcess hosting.

#### Ep 7 - [.Net Core out of process hosting](https://www.youtube.com/watch?v=QsXsOX6qq2c&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=7)

Out of process using 2 Web Servers - Internal and External Web Server
- The Internal Web Server is Kestrel
- The External Web Server can be IIS, Nginx or Apache
- Depending on how you are running the asp.net core application, the external web server may or may not be used

What is Kestrel
- Cross-Platform Web Server embedded in ASP.NET Core
- Kestrel can be used, by itself as an edge server(*Internet-facing web server that can directly process the incoming HTTP requests form the client*)
- The process used to host the app is `dotnet.exe`
which means when we run a .Net Core Application using the .Net Core CLI(*Command-Line Interface*), 
the application uses Kestrel as the web server(*It is OutOfProcess and ignore the related configuration*)

<p align="center">
  <img src="https://i.ibb.co/LzvXGDy/what-is-kestrel-web-server.png">
  <img src="https://i.ibb.co/rsXWc1f/asp-net-core-reverse-proxy-server.png">
</p>

In Process | Out of Process
:---: | :---:
Process name is w3wp.exe or iisexpress.exe | Process name is dotnet.exe
Only one web server | Two web servers
Better for performance | Penalty of proxying requests between internal and external web server

#### Ep 8 - [.Net Core launchsettings json file](https://www.youtube.com/watch?v=u2S4TkkACVc&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=8)

**launchsettings.json file**
- You will find this file in the **"Properties"** folder in the project root folder.
- The settings in this file are used when we run this ASP.NET core project either from Visual Studio or by using .NET Core CLI.
- This file is **only used on local development machine**. We do not need it for publishing our asp.net core application.
- If there are certain settings that you want your asp.net core application to use when you publish and deploy your app, 
store them in **appsettings.json** file. We usually store our application configuration settings in this file. 
- We can also have **environment specific appsettings.json files**. For example, appsettings.Staging.json for the staging environment. 
In ASP.NET Core, in addition to appsettings.json file, we also have other configuration sources like 
Environment variables, User Secrets, Command Line Arguments and even our own custom configuration source.

It looks like this
```JSON
{
  "iisSettings": {
    "windowsAuthentication": false, 
    "anonymousAuthentication": true, 
    "iisExpress": {
      "applicationUrl": "http://localhost:50015",
      "sslPort": 0
    }
  },
  "profiles": {
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },
    "DotNetCoreTutorialJourney": {
      "commandName": "Project",
      "launchBrowser": true,
      "applicationUrl": "http://localhost:5000",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    }
  }
}
```
Notice, we have 2 profiles - **IIS Express** and **EmployeeManagement** 

When we run the project from Visual Studio by pressing **CTRL + F5** or just **F5**, by default, the profile with **"commandName": "IISExpress"** is used. 
On the other hand, if we run the project using **.NET Core CLI** *(dotnet run)*, the profile with the **"commandName": "Project"** is used. 

However, we can change which profile to use by clicking on the dropdownlist in Visual Studio 

<p align="center">
  <img src="https://i.ibb.co/VWQFxLc/asp-net-core-launch-profile.png">
</p>

The value of the **commandName** property can be any one of the following.  
1. Project
2. IISExpress
3. IIS

This value *along with* the value of **AspNetCoreHostingModel** element in the project file, 
specifies the internal and external web server (reverse proxy server) to launch. 

commandName | AspNetCoreHostingModel | Internal Web Server | External Web Server
:---: | :---: | :---: | :---:
Project | Hosting Setting Ignored | Only one web server is used - Kestrel
IISExpress | InProcess | Only one webser is used - IIS Express
IISExpress | OutOfProcess | Kestrel | IIS Express
IIS | InProcess | Only one web server is used - IIS
IIS | OutOfProcess | Kestrel | IIS

Notice, the Environment Variable **"ASPNETCORE_ENVIRONMENT"** is set to "Development". 
We can change this value to **Staging** or **Production** depending on whether we are running this project in Staging or Production environment.  

We can also add new environment Variables. These environment variables are available throughout our asp.net core application 
and we can include code that conditionally executes depending on the value of these environment variables. 

For example, consider the following code in the `Configure()` method in `Startup.cs` file 

```C#
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
  if (env.IsDevelopment())
  {
    app.UseDeveloperExceptionPage();
  }
  
  //Rest of the code
}
```         
In this case, **DeveloperExceptionPage** is only displayed if the environment is **Development**.

#### Ep 8 - [.Net Core launchsettings json file](https://www.youtube.com/watch?v=m_BevGi7zBw&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=9)

In previous versions of ASP.NET, we store application configuration settings, like database connection strings for example, in **web.config file**. 
In ASP.NET Core application configuration settings can come from the following **different configurations sources**. 
1. Files (appsettings.json, appsettings.{Environment}.json, where {Environment} is the app's current hosting environment)
2. User secrets
3. Environment variables
4. Command-line arguments

We can create appsettings.json and appsettings.{Environment}.json in root folder, they will be nested automatically.

To access configuration information in the `Startup` class, inject the `IConfiguration` service provided by the Framework. 
`Startup` class is in `Startup.cs` file. 

```C#
public class Startup
{
    private IConfiguration _configuration;

    // Notice we are using Dependency Injection here
    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
    }

    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.Run(async (context) =>
        {
            await context.Response.WriteAsync(_configuration["MyKey"]);
        });
    }
}
```

**ASP.NET Core IConfiguration service**
- `IConfiguration` service is setup to read configuration information from all the various configuration sources in asp.net core
- If you have a configuration setting with **the same key in multiple configuration sources**, 
the later configuration sources override the earlier configuration sources 
- `CreateDefaultBuilder()` method of the `WebHost` class which is automatically invoked when the application starts, 
reads the configuration sources in a specific order.
- To see the order in which the configuration sources are read, we can check out `ConfigureAppConfiguration()` method 
on the [link](https://github.com/aspnet/MetaPackages/blob/release/2.2/src/Microsoft.AspNetCore/WebHost.cs)

The following is the default order in which the various configuration sources are read 
1. appsettings.json, 
2. appsettings.{Environment}.json
3. User secrets
4. Environment variables
5. Command-line arguments

You can change this order if you want to or 
even add your own custom configuration sources in addition to all the existing configuration sources.