# .Net Core Journey

**.Net Core Version 2.1**

This repository is created based on **[ASP.NET core tutorial for beginners](https://www.youtube.com/playlist?list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU)** 
by **[kudvenkat](https://www.youtube.com/channel/UCCTVrRB5KpIiK6V2GGVsR1Q)**

# Table of Contents
1. [Ep 6 - .Net Core in process hosting](#ep-6---net-core-in-process-hosting)
2. [Ep 7 - .Net Core out of process hosting](#ep-7---net-core-out-of-process-hosting)
3. [Ep 8 - .Net Core launchsettings json file](#ep-8---net-core-launchsettings-json-file)
4. [Ep 9 - .Net Core appsetting json file](#ep-9---net-core-appsetting-json-file)
5. [Ep 10 - Middleware in .NET Core](#ep-10---middleware-in-net-core)
6. [Ep 11 - Configure .NET Core request processing pipeline](#ep-11---configure-asp-net-core-request-processing-pipeline)
7. [Ep 12 - Static files in .NET Core](#ep-12---static-files-in-net-core)
8. [Ep 13 - .NET Core developer exception page](#ep-13---net-core-developer-exception-page)
9. [Ep 14 - .NET Core environment variables](#ep-14---net-core-environment-variables)
10. [Ep 15 - .NET Core MVC](#ep-15---net-core-mvc)

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

##### [Back to Table of Contents](#table-of-contents)

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

##### [Back to Table of Contents](#table-of-contents)

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

##### [Back to Table of Contents](#table-of-contents)

#### Ep 9 - [.Net Core appsetting json file](https://www.youtube.com/watch?v=m_BevGi7zBw&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=9)

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

The following is the **default order** in which the various configuration sources are read 
1. appsettings.json, 
2. appsettings.{Environment}.json
3. User secrets
4. Environment variables
5. Command-line arguments

You can change this order if you want to or 
even add your own custom configuration sources in addition to all the existing configuration sources.

##### [Back to Table of Contents](#table-of-contents)

#### Ep 10 - [Middleware in .NET Core](https://www.youtube.com/watch?v=ALu4jtvjSYw&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=10)

##### What is Middleware in ASP.NET Core
In ASP.NET Core, Middleware is a piece of software that can handle an HTTP request or response. 
A given middleware component in ASP.NET Core has a very specific purpose. 
For example we may have a middleware component that authenticates a user, another piece of middleware to handle errors, 
yet another middleware to serve static files such as JavaScript files, CSS files, Images etc.  

It is these middleware components that we use to setup a request processing pipeline in ASP.NET Core. 
It is this pipeline that determines how a request is processed. 
The request pipeline is configured as part of the application startup by the `Configure()` method in `Startup.cs` file.  
The following is the code in `Configure()` method. 

```C#
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }

    app.Run(async (context) =>
    {
        await context.Response.WriteAsync("Hello World!");
    });
}
```

As you can see, the code in the `Configure()` method that is generated by the empty project template sets up a 
**very simple request processing pipeline** with just two pieces of middleware.

`UseDeveloperExceptionPage()` is one middleware and the second middleware is setup using the `Run()` method. 
As it stands right now with this very simple request processing pipeline, 
all our application can do is write a message to the response object that will be displayed by the browser. 

The following diagram helps us understand middleware components and how they fit in a request processing pipeline 

<p align="center">
  <img src="https://i.ibb.co/HXds9N6/middleware-in-asp-net-core.png">
</p>

In ASP.NET Core, **a Middleware component has access to both - the incoming request and the outgoing response**. 
So a Middleware component may process an incoming request and pass that request to the next piece of middleware in the pipeline for further processing.
For example, if you have a **logging middleware**, it might simply log the time the request is made and pass the request to the next piece of middleware for further processing.

**A middleware component may handle the request and decide not to call the next middleware in the pipeline**.
This is called short-circuiting the request pipeline. Short-circuiting is often desirable because it avoids unnecessary work.
For example, if the request is for a static file like an image or css file, the StaticFiles middleware can handle and serve that request and short-circuit the rest of the pipeline.
This means in our case, the StaticFiles middleware will not call the MVC middleware if the request is for a static file.

**A middleware component may handle an incoming HTTP request by generating an HTTP response**.
For example, mvcmiddleware in the pipeline handles a request to the `URL` `/employees` and returns a list of employees. 

**Middleware components are executed in the order they are added to the pipeline**.
Care should be taken to add the middleware in the right order, otherwise the application may not function as expected. 

**The middleware components are available as NuGet packages**.
This means updates are now handled by NuGet, providing the ability to update each middleware separately. 

##### [Back to Table of Contents](#table-of-contents)

#### Ep 11 - [Configure .NET Core request processing pipeline](https://www.youtube.com/watch?v=nt6anXAwfYI&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=11)

As part of the application startup, `Configure()` method sets up the request processing pipeline. 

```C#
public class Startup
{
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
            await context.Response.WriteAsync("Hello World!");
        });
    }
}
```

**At the moment we have 2 middlewares in the pipeline**
- `UseDeveloperExceptionPage()` and
- another middleware that is registered using the `Run()` method. 

**UseDeveloperExceptionPage Middleware**: As the name implies, this middleware responds with the developer exception page, 
if there is an exception and if the environment is Development.

The second middleware that is registered using the `Run()` method, can only write a message to the Response object.
Which means the previous write will be covered by the last one.

**Code Explanation**
- We are using `Run()` method to add middleware to our application's request processing pipeline
- If you hover the mouse over the `Run()` method, from the intellisense you can see that this `Run()` method is implemented 
as an extension method of `IApplicationBuilder` interface. This is the reason we are able to invoke this `Run()` method on `IApplicationBuilder` object `app`.
- The parameter that we are passing to the `Run()` method is a `RequestDelegate` which we can see from the intellisense.
- `RequestDelegate` is a delegate that has `HttpContext` object as a parameter. 
- It is through this `HttpContext` object, the middleware gains access to both the incoming http request and outgoing http response.
- At the moment, we are passing request delegate inline as an anonymous method using a lambda.
- Instead of passing the request delegate inline as an anonymous method, we can define the request delegate in a separate reusable class.
- With this `Run()` extension method we can only add a **terminal middleware** to the request pipeline.
- A terminal middleware is a middleware that **does not call the next middleware** in the pipeline

**Consider the following code**
```C#
app.Run(async (context) =>
{
    await context.Response.WriteAsync("Hello from 1st Middleware");
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Hello from 2nd Middleware");
});
```

- We have 2 middlewares registered using the `Run()` method
- Upon running this project, we only see the response from the first middleware
- We do not see the response from the second middleware
- This is because, a middleware that is registered using the `Run()` method cannot call the next middleware in the pipeline
- So, the middleware that we register using `Run()` method is a terminal middleware

If you want your middleware to be able to call the next middleware in the pipeline, then register the middleware using `Use()` method as shown below. 
```C#
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hello from 1st Middleware");
    await next();
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Hello from 2nd Middleware");
});
```

Notice, `Use()` method has 2 parameters. The first parameter is the `HttpContext` context object 
and the second parameter is the `Func` type i.e it is a generic delegate that represents the next middleware in the pipeline.

```C#
public void Configure(IApplicationBuilder app, IHostingEnvironment env,
                ILogger<Startup> logger)
{
    app.Use(async (context, next) =>
    {
        logger.LogInformation("MW1: Incoming Request");
        await next();
        logger.LogInformation("MW1: Outgoing Response");
    });

    app.Use(async (context, next) =>
    {
        logger.LogInformation("MW2: Incoming Request");
        await next();
        logger.LogInformation("MW2: Outgoing Response");
    });

    app.Run(async (context) =>
    {
        await context.Response.WriteAsync("MW3: Request handled and response produced");
        logger.LogInformation("MW3: Request handled and response produced");
    });
}
```

- `ILogger<Startup>` is injected into the `Configure()` method
- `CreateDefaultBuilder()` that is called by the `Main()` method configures logging
- You will see that, the information is logged in the following order
  - MW1: Incoming Request
  - MW2: Incoming Request
  - MW3: Request handled and response produced
  - MW2: Outgoing Response
  - MW1: Outgoing Response

  Now relate the above output, with the following diagram from MSDN to understand what's happening.

<p align="center"> 
  <img src="https://i.ibb.co/61rPnLJ/request-delegate-pipeline.png">
</p>

##### [Back to Table of Contents](#table-of-contents)

#### Ep 12 - [Static files in .Net Core](https://www.youtube.com/watch?v=yt6bzZoovgM&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=12)

**Static Files**
- By default, an asp.net core application will not serve static files
- The default directory for static files is wwwroot and this directory must be in the root project folder

We can access files in wwwroot from the browser by using `http://{serverName}/{fileName}`

Also, if we created folder under wwwroot, we can use `http://{serverName}/{folderName}/{fileName}`

In our case we are running on our local machine, so the `{serverName}` should be `localhost:xxxxx`

However, when we use the `URL` above, the file does not show up. 
This is because, at the moment our application request processing pipeline does not have the required middleware that can serve static files. 
The middleware that we need is `UseStaticFiles()` middleware.  

Modify the code in `Configure()` method to add `UseStaticFiles()` middleware to our application's request processing pipeline as shown below. 

```C#
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    } 

    // Add Static Files Middleware
    app.UseStaticFiles(); 

    app.Run(async (context) =>
    {
        await context.Response.WriteAsync("Hello World!");
    });
}
```

To serve a default document like `default.html` or `index.html` when users visit `http://{serverName}/,
We can use `UseDefaultFiles()` middleware in our application's request processing pipeline. 

```C#
// Add Default Files Middleware
app.UseDefaultFiles();
// Add Static Files Middleware
app.UseStaticFiles(); 
```

`UseDefaultFiles()` **must be called before** `UseStaticFiles()` to serve the default file. 
`UseDefaultFiles()` is a `URL` rewriter that **doesn't** actually serve the file. 
It simply rewrites the `URL` to the default document which will then be served by the Static Files Middleware

If you want to use another document like `home.html` for example as your default document, you can do so using the following code. 

```C#
// Specify foo.html as the default document
DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
defaultFilesOptions.DefaultFileNames.Clear();
defaultFilesOptions.DefaultFileNames.Add("home.html");
// Add Default Files Middleware
app.UseDefaultFiles(defaultFilesOptions);
// Add Static Files Middleware
app.UseStaticFiles(); 
```

**UseFileServer Middleware **
`UseFileServer()` combines the functionality of `UseStaticFiles()`, `UseDefaultFiles()` and `UseDirectoryBrowser()` middleware. 
`DirectoryBrowser()` middleware, enables directory browsing and allows users to see files within a specified directory. 
We could replace `UseStaticFiles()` and `UseDefaultFiles()` middlewares with `UseFileServer()` Middleware. 

```C#
// Use UseFileServer instead of UseDefaultFiles & UseStaticFiles
FileServerOptions fileServerOptions = new FileServerOptions();
fileServerOptions.DefaultFilesOptions.DefaultFileNames.Clear();
fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("home.html");
app.UseFileServer(fileServerOptions);
```

The important point to note here is the pattern that we use to add middleware to our application's request processing pipeline. 
In most cases we add middleware using the extension methods that start with the word `Use`.

If you want to customise these middleware components, we use the respective OPTIONS object.

Middleware | Options Object
:---: | :---:
UseDeveloperExceptionPage | DeveloperExceptionPageOptions
UseDefaultFiles | DefaultFilesOptions
UseStaticFiles | StaticFileOptions
UseFileServer | FileServerOptions

##### [Back to Table of Contents](#table-of-contents)

#### Ep 13 - [.Net Core developer exception page](https://www.youtube.com/watch?v=UGG2-oV9iQ8&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=13)

Consider the following code in `Configure()` method in `Startup` class 
```C#
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }

    app.UseFileServer();

    app.Run(async (context) =>
    {
        throw new Exception("Some error processing the request");
        await context.Response.WriteAsync("Hello World!");
    });
}
```

If we run the code we do not see the exception. Because `UseFileServer()` middleware combines the function of 
`UseDefaultFiles()` and `UseStaticFiles()`. Which means the `http://localhost:xxxxx` is handled by `UseFileSever()`
and the pipeline **reverses** from here.

However, if we issue a request to `http://localhost:xxxx/abcdef.html`, we see the exception as expected.
Because the `UseFileServer()` will not find the file with name `abcdef.html`. It gives control to the next middleware in the pipeline, 
which in our case is the `Run()` method, which throws an exception.

Also, we can customise `UseDeveloperExceptionPage()` using the respective OPTIONS object, which in this case is `DeveloperExceptionPageOptions`.

Notice that `UseDeveloperExceptionPage()` middleware must be plugged into the request processing pipeline as early as possible, 
so it can handle the exception and display the Developer Exception Page if the subsequent middleware components in the pipeline raises an exception.
Because the pipeline might be reversed before the `UseDeveloperExceptionPage()`.

##### [Back to Table of Contents](#table-of-contents)

#### Ep 14 - [.Net Core environment variables](https://www.youtube.com/watch?v=x8jNX1nb_og&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=14)

In most software development organisations we typically have the following development environments. 
- Development
- Staging
- Production

If `ASPNETCORE_ENVIRONMENT` is not set, it defaults to `Production`.

Also, we can have customised environment like `Staging_1`, then we can use the code below.

```C#
if (env.IsEnvironment("Staging_1"))
    app.UseDeveloperExceptionPage();
```

**Why do we need different Development Environments like Development, Staging, Production etc. **

**Development Environment**: We software developers typically use this environment for our day to day development work. 
We want non-minified JavaScript and CSS files to be loaded on a development environment for ease of debugging. 
Similarly we want developer exception page if there is an unhandled exception so we can understand the root cause of the exception and fix it if required. 

**Staging Environment**: Many organisations, try to keep their staging environment as identical as possible to the actual production environment. 
The primary reason for this environment is to identify any deployment related issues. Also, if you are developing a B2B (Business to Business) application, 
you may be interfacing with other service provider systems. Many organisations, usually setup their staging environment to interface with the service providers as well, 
for complete end to end testing. We usually do not troubleshoot and debug on a staging environment, so for better performance we want minified JavaScript and CSS files to be loaded. 
If there is an unhandled exception, display user friendly error page instead of the developer exception page. A user friendly error page will not contain any technical details. 

**Production Environment**: The actual live environment, that we use for day to day business. Production environment should be configured for maximum security and performance. 
So load minified JavaScript and CSS files to improve the performance. For better security, display a User Friendly Error Page instead of the Developer Exception Page.

**Configuring `ASPNETCORE_ENVIRONMENT` variable**
On our local development machine we usually set this environment variable in `launchsettings.json` file.
However, this file will not be loaded when we publish the project.

We can also set it on a Operating system, like `Windows`, `macOS` or `Linux`.
For more information, we can check [Use multiple environments in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/environments?view=aspnetcore-2.1)

##### [Back to Table of Contents](#table-of-contents)

#### Ep 15 - [.Net Core MVC](https://www.youtube.com/watch?v=f72ookCWhsQ&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=15)






















































