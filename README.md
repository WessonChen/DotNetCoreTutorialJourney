# .Net Core Journey

**.Net Core Version 2.1**

This repository is created based on **[ASP.NET core tutorial for beginners](https://www.youtube.com/playlist?list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU)** 
by **[kudvenkat](https://www.youtube.com/channel/UCCTVrRB5KpIiK6V2GGVsR1Q)**

## Table of Contents
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
11. [Ep 16 - Setup MVC in .Net Core](#ep-16---setup-mvc-in-net-core)
12. [Ep 18 - Model in .Net Core MVC](#ep-18---model-in-net-core-mvc)
13. [Ep 19 - .Net Core dependency injection](#ep-19---net-core-dependency-injection)
14. [Ep 20 - Controller in .Net Core MVC](#ep-20---controller-in-net-core-mvc)
15. [Ep 21 - View in .Net Core MVC](#ep-21---view-in-net-core-mvc)
16. [Ep 23 - ViewData in .Net Core MVC](#ep-23---viewdata-in-net-core-mvc)
17. [Ep 24 - ViewBag in .Net Core MVC](#ep-24---viewbag-in-net-core-mvc)
18. [Ep 25 - Strongly Typed View in .Net Core MVC](#ep-25---strongly-typed-view-in-net-core-mvc)
19. [Ep 26 - ViewModel in .Net Core MVC](#ep-26---viewModel-in-net-core-mvc)
20. [Ep 27 - List View in .Net Core MVC](#ep-27---list-view-in-net-core-mvc)
21. [Ep 28 - Layout View in .Net Core MVC](#ep-28---layout-view-in-net-core-mvc)
22. [Ep 29 - Sections in layout page in .Net Core MVC](#ep-29---sections-in-layout-page-in-net-core-mvc)
23. [Ep 30 - ViewStart page in .Net Core MVC](#ep-30---viewstart-page-in-net-core-mvc)
24. [Ep 31 - ViewImports page in .Net Core MVC](#ep-31---viewImports-page-in-net-core-mvc)
25. [Ep 32 - Routing in .Net Core MVC](#ep-32---routing-in-net-core-mvc)
26. [Ep 33 - Attribute Routing in .Net Core MVC](#ep-33---attribute-routing-in-net-core-mvc)
27. [Ep 35 - Tag Helpers in .Net Core MVC](#ep-35---tag-helpers-in-net-core-mvc)
28. [Ep 37 - Image Tag Helpers in .Net Core MVC](#ep-37---image-tag-helpers-in-net-core-mvc)
29. [Ep 38 - Environment Tag Helpers in .Net Core MVC](#ep-38---environment-tag-helpers-in-net-core-mvc)
30. [Ep 40 - Form Tag Helpers in .Net Core MVC](#ep-40---form-tag-helpers-in-net-core-mvc)
31. [Ep 41 - .Net Core MVC Model Binding](#ep-41---net-core-model-binding)
32. [Ep 42 - .Net Core MVC Model Validation](#ep-42---net-core-model-validation)
33. [Ep 43 - .Net Core Model Select List Validation](#ep-43---net-core-model-select-list-validation)
 
## Notes
### Ep 6 - [.Net Core in process hosting](https://www.youtube.com/watch?v=ydR2jd3ZaEA&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=6)

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

#### [Back to Table of Contents](#table-of-contents)

### Ep 7 - [.Net Core out of process hosting](https://www.youtube.com/watch?v=QsXsOX6qq2c&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=7)

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

#### [Back to Table of Contents](#table-of-contents)

### Ep 8 - [.Net Core launchsettings json file](https://www.youtube.com/watch?v=u2S4TkkACVc&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=8)

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

#### [Back to Table of Contents](#table-of-contents)

### Ep 9 - [.Net Core appsetting json file](https://www.youtube.com/watch?v=m_BevGi7zBw&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=9)

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

#### [Back to Table of Contents](#table-of-contents)

### Ep 10 - [Middleware in .NET Core](https://www.youtube.com/watch?v=ALu4jtvjSYw&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=10)

**What is Middleware in ASP.NET Core**
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

#### [Back to Table of Contents](#table-of-contents)

### Ep 11 - [Configure .NET Core request processing pipeline](https://www.youtube.com/watch?v=nt6anXAwfYI&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=11)

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

#### [Back to Table of Contents](#table-of-contents)

### Ep 12 - [Static files in .Net Core](https://www.youtube.com/watch?v=yt6bzZoovgM&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=12)

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

#### [Back to Table of Contents](#table-of-contents)

### Ep 13 - [.Net Core developer exception page](https://www.youtube.com/watch?v=UGG2-oV9iQ8&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=13)

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

#### [Back to Table of Contents](#table-of-contents)

### Ep 14 - [.Net Core environment variables](https://www.youtube.com/watch?v=x8jNX1nb_og&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=14)

In most software development organisations we typically have the following development environments. 
- Development
- Staging
- Production

If `ASPNETCORE_ENVIRONMENT` is not set, it defaults to `Production`.

Also, we can have customised environment like `Staging_1`, then we can use the code below.

```C#
if (env.IsEnvironment("Staging_1") || env.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
```

**Why do we need different Development Environments like Development, Staging, Production etc.**

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

#### [Back to Table of Contents](#table-of-contents)

### Ep 15 - [.Net Core MVC](https://www.youtube.com/watch?v=f72ookCWhsQ&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=15)

**What is MVC**

<p align="center"> 
  <img src="https://i.ibb.co/h2J3jQ1/what-is-mvc.png">
</p>

MVC consists of three fundamental parts - **Model**, **View** and **Controller**. 
It's an architectural design pattern for implementing User Interface Layer of an application. 
A typical real world application usually has the following layers. 
- User Interface Layer
- Business Logic Layer or Domain Layer
- Data Access layer

MVC design pattern is usually used for implementing the User Interface Layer of the application. 

**How MVC Works**

<p align="center"> 
  <img src="https://i.ibb.co/W5RwYth/how-mvc-works.png">
</p>

1. When this request arrives at our server, it is the Controller in the MVC design pattern that receives the request and handles it. 
2. The controller creates the model. The model has the classes that describe the data. 
3. In addition to the data itself, Model also contains the logic to retrieve data from the underlying data source such as a database. 
4. In addition to creating the Model, the controller also selects a View and passes the Model object to that View. 
5. The view is only responsible for presenting the model data. 
6. It is the view, that generates the required HTML to present the model data i.e the employee data provided to it by the Controller. 
7. This HTML is then sent over the network to the user who made the request.

**Model**

So model in this case consists of the `Employee` class and the `EmployeeRepository` class that manages the employee data as shown below. 

```C#
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
}

public interface IEmployeeRepository
{
    Employee GetEmployee(int id);
    void Save(Employee employee);
}

public class EmployeeRepository : IEmployeeRepository
{
    public Employee GetEmployee(int id)
    {
        // Logic to retrieve employee details
    }

    public void Save(Employee employee)
    {
        // Logic to save employee details
    }
}
```

We use the `Employee` class to hold the employee data and It is the `EmployeeRepository` class 
that retrieves and saves data in the underlying data source.

So to generalise this, **a Model in MVC contains a set of classes that represent data and the logic to manage that data**. 
The class that represent the data is the `Employee` class and 
the class that manages the data is the `EmployeeRepository` class.

And using the interface abstraction allows us to use dependency injection 
which in turn allows us to create systems that are loosely coupled and easily testable. 

**View**

A View in MVC should only contain the logic to display the Model data provided to it by the Controller. 
You can think of a view as an HTML Template.

The view in this case will be provided with the `Employee` object. 
The `Employee` object is the model that carries the employee data to the view. 
The only responsibility of the view is to present the employee data in an HTML table. 
Here is the code in the view. 

```HTML
@model EmployeeManagement.Employee

<html>
<head>
    <title>Employee Details</title>
</head>
<body>
    <table>
        <tr>
            <td>ID</td>
            <td>@Model.Id</td>
        </tr>
        <tr>
            <td>Name</td>
            <td>@Model.Name</td>
        </tr>
        <tr>
            <td>Department</td>
            <td>@Model.Department </td>
        </tr>
    </table>
</body>
</html>
```

In MVC, a View in only responsible for presenting the model data. There should be no complex logic in a view. 
To maintain a clear separation of concerns, the logic in a view must be very minimal and that too it must only be there for presenting data. 
If you get to a point where the presentation logic is getting too complicated, consider using a `ViewModel` or `ViewComponent`.

**Controller**
When a request from the browser arrives at our application, it is the controller in the MVC design pattern, 
that handles the incoming http request and responds to the user action.  

In this case the user has issued a request to the `URL(/employee/details/1)`, 
so this request is mapped to the `Details` action method in the `EmployeeController`, passing it the EMPLOYEE ID which in this case is 1. 
This mapping is done by the Routing rules defined in our application.

```C#
public class EmployeeController : Controller
{
    private IEmployeeRepository _employeeRepository;

    public EmployeeController(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public IActionResult Details(int id)
    {
        Employee model = _employeeRepository.GetEmployee(id);
        return View(model);
    }
}
```

As you can see, from the code in the `Details` action method, the controller builds the model, 
in this case the Model is the `Employee` object. To retrieve the Employee data from the underlying data source, 
the controller is making use of the `EmployeeRepository` class. 

Once the controller has constructed the `Employee` model object with the required data, 
it then passes that `Employee` model object to the view. 
The view then generates the required HTML to present the `Employee` data provided to it by the Controller. 
This HTML is then sent over the network to the user who made the request.

#### [Back to Table of Contents](#table-of-contents)

### Ep 16 - [Setup MVC in .Net Core](https://www.youtube.com/watch?v=KQH51Yip0K0&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=16)

**Step 1**: In `ConfigureServices()` method of the `Startup` class in `Startup.cs` file, include `services.AddMvc();`.

```C#
public void ConfigureServices(IServiceCollection services)
{
    services.AddMvc();
}
```

**The difference between `services.AddMvc()` and `services.AddMvcCore()` here is**:
- `AddMvcCore()` method only adds the core MVC services
- `AddMvc()` method adds all the required MVC services
- `AddMvc()` method calls `AddMvcCore()` method internally

[Here](https://github.com/aspnet/Mvc/blob/master/src/Microsoft.AspNetCore.Mvc/MvcServiceCollectionExtensions.cs)
is the source code of `AddMvc()` method

```C#
public static IMvcBuilder AddMvc(this IServiceCollection services)
{
    if (services == null)
    {
	throw new ArgumentNullException(nameof(services));
    }

    var builder = services.AddMvcCore();

    builder.AddApiExplorer();
    builder.AddAuthorization();

    AddDefaultFrameworkParts(builder.PartManager);

    builder.AddFormatterMappings();
    builder.AddViews();
    builder.AddRazorViewEngine();
    builder.AddRazorPages();
    builder.AddCacheTagHelper();
    builder.AddDataAnnotations(); // +1 order
    builder.AddJsonFormatters();
    builder.AddCors();

    return new MvcBuilder(builder.Services, builder.PartManager);
}
```

As we can see, the `AddMvc(this IServiceCollection services)` method called `services.AddMvcCore()` first,
then it also called other services, including `AddViews()` which allows the Controller returns an **HTML View**.

And [Here](https://github.com/aspnet/Mvc/blob/1521f9298bc44e70d0fc5f9bc0814e101bbcc479/src/Microsoft.AspNetCore.Mvc.Core/DependencyInjection/MvcCoreServiceCollectionExtensions.cs)
is the source code of `AddMvcCore()` method

```C#
public static IMvcCoreBuilder AddMvcCore(this IServiceCollection services)
{
    if (services == null)
    {
	throw new ArgumentNullException(nameof(services));
    }

    var partManager = GetApplicationPartManager(services);
    services.TryAddSingleton(partManager);

    ConfigureDefaultFeatureProviders(partManager);
    ConfigureDefaultServices(services);
    AddMvcCoreServices(services);

    var builder = new MvcCoreBuilder(services, partManager);

    return builder;
}
```

As we can see, the `AddMvcCore(this IServiceCollection services)` method called `AddMvcCoreServices(services)` only,
no other service has been called.

**Step 2**: In the `Configure()` method, add `UseMvcWithDefaultRoute()` midddleware to our application's request processing pipeline.

```C#
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }

    app.UseStaticFiles();
    app.UseMvcWithDefaultRoute();

    app.Run(async (context) =>
    {
        await context.Response.WriteAsync("Hello World!");
    });
}
```

The `UseMvcWithDefaultRoute()` means useing MVC with route which follows format like '{controller=Home}/{action=Index}/{id?}'

Notice, we placed `UseStaticFiles()` middleware before `UseMvcWithDefaultRoute()` middleware. 
This order is important, because if the request is for a static file like an image, css or JavaScript file, 
then `UseStaticFiles()` middleware will handle the request and short-circuit the rest of the pipeline. 

So if the request is for a static file, `UseMvcWithDefaultRoute()` middleware is not executed, there by avoiding the unnecessary processing.  

On the other hand, if the request is an MVC request, `UseStaticFiles()` middleware will pass that request to `UseMvcWithDefaultRoute()` middleware 
which will handle the request and produces the response. 

if we run the project now, the browser will display `"Hello World!"`. Because the `URL-http://localhost:xxxxx` will be routed to `http://localhost:xxxx/Home/Index` 
as we mentioned before, and it is not exist. And then the `app.UseMvcWithDefaultRoute()` will pass the request to the next middleware which is `app.Run`.
We can delete the `app.Run` now. Because a `404 error` makes more sense than `"Hello World!"`.

**Add HomeController**

Add Controllers folder, in the root project folder. In the "Controllers" add a new Controller. Make the code like this.

```C#
public class HomeController : Controller
{
    // GET: /<controller>/
    //public IActionResult Index()
    //{
    //    return View();
    //}

    public string Index()
    {
        return "Hello from Controller";
    }
}
```

We commented the default `IActionResult` because it returns the `View()`, and we do not have a `View()` yet. Let's return a string for now.

#### [Back to Table of Contents](#table-of-contents)

### Ep 18 - [Model in .Net Core MVC](https://www.youtube.com/watch?v=KXPbJ9I4ce0&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=18)

**Model in MVC** contains a set of classes that represent data and the logic to manage that data.

 First, we create a `Employee` class

 ```C#
 public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Department { get; set; }
}
```

Then we create a `interface` to interact with `Employee`

```C#
public interface IEmployeeRepository
{
    Employee GetEmployee(int Id);
}
```

Then we impletent the `interface` with mock data.

```C#
public class MockEmployeeRepository : IEmployeeRepository
{
    private List<Employee> _employeeList;

    public MockEmployeeRepository()
    {
        _employeeList = new List<Employee>()
        {
            new Employee() { Id = 1, Name = "Mary", Department = "HR", Email = "mary@pragimtech.com" },
            new Employee() { Id = 2, Name = "John", Department = "IT", Email = "john@pragimtech.com" },
            new Employee() { Id = 3, Name = "Sam", Department = "IT", Email = "sam@pragimtech.com" },
        };
    }

    public Employee GetEmployee(int Id)
    {
        return this._employeeList.FirstOrDefault(e => e.Id == Id);
    }
}
```

Throughout our application we will be programming against the interface `IEmployeeRepository` and not the concrete implementation `MockEmployeeRepository`. 
This interface abstraction allows us to use **dependency injection** which in turn makes our application flexible and easily unit testable.

#### [Back to Table of Contents](#table-of-contents)

### Ep 19 - [.Net Core dependency injection](https://www.youtube.com/watch?v=BPGtVpu81ek&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=19)

**`HomeController`**

```C#
public class HomeController : Controller
{
    private readonly IEmployeeRepository _employeeRepository;

    // Inject IEmployeeRepository using Constructor Injection
    public HomeController(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    // Retrieve employee name and return
    public string Index()
    {
        return _employeeRepository.GetEmployee(1).Name;
    }
}
```

- `HomeController` is dependant on `IEmployeeRepository` for retrieving `Employee` data.
- Instead of the `HomeController` creating a new instance of an implement ion of `IEmployeeRepository`, 
we are injecting `IEmployeeRepository` instance into the `HomeController` using the constructor. 
- This is called **constructor injection**, as we are using the constructor to inject the dependency.
- Notice, we are assigning the injected dependency to a read-only field. This is a good practice as 
it prevents accidentally assigning another value to it inside a method.
- At this point, if we run the project we get the following error
> InvalidOperationException: Unable to resolve service for type 'DotNetCoreTutorialJourney.Models.IEmployeeRepository' while attempting to activate 'DotNetCoreTutorialJourney.Controllers.HomeController'.
- This is because the ASP .NET dependency injection container does not know which object instance to provide 
if someone requests an object that implements `IEmployeeRepository`
- `IEmployeeRepository` may have several implementations. At the moment in our project we only have one implementation 
and that is `MockEmployeeRepository`
- As the name implies, `MockEmployeeRepository` works with the in-memory employee mock data.
- To fix the `InvalidOperationException` error, we need to register `MockEmployeeRepository` class with the dependency injection container in ASP.NET core.
- We do this in `ConfigureServices()` method in `Startup` class

**Registering Services with the ASP.NET Core Dependency Injection Container**: 

ASP.NET core provides the following 3 methods to register services with the dependency injection container. 
The method that we use determines **the lifetime of the registered service**.

1. `AddSingleton()` - As the name implies, `AddSingleton()` method creates a Singleton service. 
A Singleton service is created when it is first requested. This same instance is then used by all the subsequent requests. 
So in general, a Singleton service is created only one time per application and that single instance is used throughout the application life time.
2. `AddTransient()` - This method creates a Transient service. A new instance of a Transient service is created each time it is requested. 
3. `AddScoped()` - This method creates a Scoped service. A new instance of a Scoped service is created once per request within the scope. 
For example, in a web application it creates 1 instance per each http request but uses the same instance in the other calls within that same web request.

For now, we use `AddSingleton()`. So, with this code in-place, if someone asks for `IEmployeeRepository`, 
an instance of `MockEmployeeRepository` will be provided.

```C#
public void ConfigureServices(IServiceCollection services)
{
    services.AddMvc();
    services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
}
```

Alternatively, we can create a new instance inside the class like this.

```C#
public class HomeController : Controller
{
    private readonly IEmployeeRepository _employeeRepository;

    // Inject IEmployeeRepository using Constructor Injection
    public HomeController(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = new MockEmployeeRepository();
    }

    // Retrieve employee name and return
    public string Index()
    {
        return _employeeRepository.GetEmployee(1).Name;
    }
}
```

However, when this interface has been used in a lot of classes, if we change the implementation of it, for example,
from `MockEmployeeRepository` to `DatabaseEmployeeRepository`, we have to change every single class.
It is tight coupling and hard to test.

#### [Back to Table of Contents](#table-of-contents)

### Ep 20 - [Controller in .Net Core MVC](https://www.youtube.com/watch?v=-O0UYM0ZIIc&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=20)

<p align="center"> 
  <img src="https://i.ibb.co/W5RwYth/how-mvc-works.png">
</p>

- `Controller` in MVC is a class and it inherits from `Microsoft.AspNetCore.Mvc.Controller`
- The controller class name is suffixed with word `"Controller"`. For example `HomeController`, `EmployeeController`
- When a request from the browser arrives at our application, it is the controller in the MVC design pattern, 
that handles the incoming http request and responds to the user action
- Controller class contains a set of public methods. These public methods in the Controller class are called **action methods**
It is these controller action methods that handle and process the incoming http request
- As we mentioned before, the `UseMvcWithDefaultRoute()` maps `{controller=Home}/{action=Index}/{id?}`,
when we ENTER key `http://localhost:12345/home/details`, it calls `details` action in `homeController`
- When request arrives at a controller action method. As part of processing that request, the controller creates the **Model**
- To retrieve model data, the controller depends on a service
- For example, in our case to retrieve `Employee` data, `HomeController` depends on `IEmployeeReporsitory` service
- `IEmployeeReporsitory` service is injected into the `HomeController` using the constructor. This is called **Dependency Injection**
- Notice, we are assigning the injected dependency to a read-only field. 
This is a good practice as it prevents accidentally assigning another value to it inside a method.
- Once the controller has the required model data, it can simply return that model data if we are building a RESTful service or an API.

**Controller returns JSON data**

```C#
public class HomeController : Controller
{
    private readonly IEmployeeRepository _employeeRepository;

    public HomeController(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public JsonResult Details()
    {
        Employee model = _employeeRepository.GetEmployee(1);
        return Json(model);
    }
}
```

In this case, `Details()` method always returns JSON data. It **does not** respect content negotiation and **ignores** the Accept Header.

**Controller returns ObjectResult**

The following example respects content negotiation. It looks at the **Request Accept Header** and if it is set to `application/xml`, then XML data is returned. If the Accept header is set to `application/json`, then JSON data is returned

```C#
public ObjectResult Details()
{
    Employee model = _employeeRepository.GetEmployee(1);
    return new ObjectResult(model);
}
```

To be able to return data in XML format, we have to add Xml Serializer Formatter by calling `AddXmlSerializerFormatters()` method 
in `ConfigureServices()` method in `Startup.cs` file.

```C#
public void ConfigureServices(IServiceCollection services)
{
    services.AddMvc().AddXmlSerializerFormatters();
    services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
}
```

**Controller returns View**

```C#
public ViewResult Details()
{
    Employee model = _employeeRepository.GetEmployee(1);
    return View(model);
}
```

Because we do not have the View yet, it shows an error.
> InvalidOperationException: The view 'Details' was not found. The following locations were searched: /Views/Home/Details.cshtml ,/Views/Shared/Details.cshtml ,/Pages/Shared/Details.cshtml

#### [Back to Table of Contents](#table-of-contents)

### Ep 21 - [View in .Net Core MVC](https://www.youtube.com/watch?v=SWIcHLBnJUg&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=21)

**View in MVC**

- Contains the logic to display the Model data provided to it by the Controller.
- A view is an HTML template with embedded Razor markup.
- A view file has .cshtml extension if the programming language is C#.

**Where are View files stored**
- By default, MVC looks for view files in the **Views** folder
- View files that belong to a specific controller are stored in a sub-folder in the Views folder and that sub-folder has **the same name as the controller**
- The view file has **the same name as that of the controller action method** with a `.cshtml` extension

For example, the `public JsonResult Details()` method in `HomeController` class should has a View `root/Views/Home/Details.cshtml`.

In this case, if we call `localhost:xxxxx/home/details`, the MVC will check `root/Views/Home/` first, then `root/Views/Shared/`, 
then `root/Pages/Shared/` by default.

If we go to the source code of `View()` methods, we can find it has 4 overloads.
```C#
public virtual ViewResult View();
public virtual ViewResult View(object model);
public virtual ViewResult View(string viewName);
public virtual ViewResult View(string viewName, object model);
```

The last 2 overloads mean that we can customise the path of the view. For example
```C#
public ViewResult Details()
{
    return View("Test");
}
```
The method above will find `root/Views/Home/test`

Also, we can use absolute path or relative path. By using these, we need the extension of the file.

```C#
public ViewResult Details()
{
    return View("MyViews/test.cshtml");
}
```
The method above will find `root/MyViews/test.cshtml`

```C#
public ViewResult Details()
{
    return View("../Test/update.cshtml");
}
```
The method above will find `root/Views/Test/update.cshtml`

#### [Back to Table of Contents](#table-of-contents)

### Ep 23 - [ViewData in .Net Core MVC](https://www.youtube.com/watch?v=tz4q6q0_JwQ&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=23)

In ASP.NET Core MVC, there are 3 ways to pass data from a controller to a view
1. Using **ViewData**
2. Using **ViewBag**
3. Using a strongly typed model object. This is also called **Strongly typed view**

By using ViewData or ViewBag to pass data, we are creating a **Loosely typed view**

We can use keyword **ViewData** to set a pair of key/values in `Controller`. For example, in `HomeController`, we do

```C#
public ViewResult Details()
{
    Employee model = _employeeRepository.GetEmployee(1);

    // Pass PageTitle and Employee model to the View using ViewData
    ViewData["PageTitle"] = "Employee Details";
    ViewData["Employee"] = model;

    return View();
}
```

And then in views, we use `@` to call `Razor` function and `ViewData` keyword to get the value. For example, in `Details.cshtml`, we do

```HTML
<html>
<head>
    <title></title>
</head>
<body>
    <h3>@ViewData["PageTitle"]</h3>

    @{
        var employee = ViewData["Employee"] as EmployeeManagement.Models.Employee;
    }

    <div>
        Name : @employee.Name
    </div>
    <div>
        Email : @employee.Email
    </div>
    <div>
        Department : @employee.Department
    </div>
</body>
</html>
```

And we will have this.

<p align="center"> 
  <img src="https://i.ibb.co/bPWLx8X/View-Data-Results.png">
</p>

**ViewData**

- `ViewData` is a **dictionary** of weakly typed objects. 
- To store and retrieve data from the `ViewData` dictionary we use string keys.
- **String** data can be accessed from `ViewData` dictionary **without the need to cast** the data to string type.
- If we are accessing any other type of data, we need to explicitly cast it to the type we are expecting.
- In our example, we are casting the `Employee` object to `Employee` Type before accessing Name, 
Email and Department properties of the `Employee` object.
- `ViewData` is dynamically resolved at **runtime**, so it **does not provide compile-time type checking** 
and as a result we **do not get intellisense**.
- We will only come to know about these errors at run time. 
- For this reason we usually **do not use** `ViewData`.
- When we use `ViewData`, we end up creating a **loosely typed view**.

#### [Back to Table of Contents](#table-of-contents)

### Ep 24 - [ViewBag in .Net Core MVC](https://www.youtube.com/watch?v=FBvNz00o7jg&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=24)

In fact, `ViewBag` is a **wrapper around ViewData**. 
With ViewData we use string keys to store and retrieve data. With ViewBag we use dynamic properties instead of string keys.

Similar to ViewData, this is how we can use it.

````C#
public ViewResult Details()
{
    Employee model = _employeeRepository.GetEmployee(1);

    // To store the page title and empoyee model object in the 
    // ViewBag we are using dynamic properties PageTitle and Employee
    ViewBag.PageTitle = "Employee Details";
    ViewBag.Employee = model;

    return View();
}
````

````HTML
<html>
<head>
    <title></title>
</head>
<body>
    <h3>@ViewBag.PageTitle</h3>

    <div>
        Name : @ViewBag.Employee.Name
    </div>
    <div>
        Email : @ViewBag.Employee.Email
    </div>
    <div>
        Department : @ViewBag.Employee.Department
    </div>
</body>
</html>
````

**ViewData v/s ViewBag**

- `ViewBag` is a wrapper around `ViewData`
- Both of them create a **loosely typed view**
- With `ViewData` we use string keys to store and retrieve data from the `ViewData` dictionary
- With `ViewBag` we use dynamic properties to store and retrieve data
- Both `ViewData` keys and `ViewBag` dynamic properties are resolved dynamically **at runtime**
- Both `ViewData` and `ViewBag` **does not provide compile-time type checking** and as a result we **do not get intellisense**
- Since we do not have intellisense, the speed at which we write code is reduced and the chances of **mis-spelling** 
and making **typographical errors** are also high.
- We will only come to know about these errors at **run time**
- For this reason we usually **do not** use `ViewData` or `ViewBag`
- The preferred approach to pass data from a controller to a view is by using a strongly typed model object. 
- Using a strongly typed model object creates a **strongly typed view**

#### [Back to Table of Contents](#table-of-contents)

### Ep 25 - [Strongly Typed View in .Net Core MVC](https://www.youtube.com/watch?v=5auO0iXrOs4&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=25)

**Strongly Typed View**

The preferred approach to pass data from a controller to a view is by using a **strongly typed view**. 
To create a strongly typed view, in the controller action method, pass the model object to the `View()` helper method. 
Notice, in the example below, we are passing the `Employee` model object to the `View()` method.

```C#
public ViewResult Details()
{
    Employee model = _employeeRepository.GetEmployee(1);

    ViewBag.PageTitle = "Employee Details";

    return View(model);
}
```

To create a strongly typed view specify the model type in the view using `@model` directive. In the example below, 
we told the view that it will using the `DotNetCoreTutorialJourney.Models.Employee` object as the model by using `@model` directive. 
Please note that in the directive(`@model`), m is in **lowercase**.

To access the model object properties we use `@Model`. In `@Model`, M is in **uppercase**. In the example below, 
to access the `Employee` object properties like `Name`, `Email` and `Department` 
we are using `@Model.Name`, `@Model.Email` and `@Model.Department` respectively.

```HTML
@model EmployeeManagement.Models.Employee

<html>
<head>
    <title></title>
</head>
<body>
    <h3>@ViewBag.PageTitle</h3>

    <div>
        Name : @Model.Name
    </div>
    <div>
        Email : @Model.Email
    </div>
    <div>
        Department : @Model.Department
    </div>
</body>
</html>
```

**Strongly Typed View Benefits**

Unlike `ViewData` and `ViewBag`, a strongly typed view **provides** compile-time type checking and intellisense. 
With intellisense support we can be more productive and the chances of mis-spelling and making typographical errors are almost nill. 
If we do make any errors we will come to know about them at compile time rather than at runtime. 

So always use a strongly typed view to pass data from a controller to a view.

#### [Back to Table of Contents](#table-of-contents)

### Ep 26 - [ViewModel in .Net Core MVC](https://www.youtube.com/watch?v=Lu24lZsUreg&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=26)

**Why do we need a ViewModel**

In some cases, a model object may not contain all the data a view needs. This is when we create a `ViewModel` as a **Data Transfer Objects**. 
It contains all the data a view needs. For example

```C#
public ViewResult Details()
{
    Employee model = _employeeRepository.GetEmployee(1);

    ViewBag.PageTitle = "Employee Details";

    return View(model);
}
```

In this case, we can wrap `Employee` and `PageTitle` into a new `Model` as **Data Transfer Objects**

First, let's create `root/ViewModels/HomeDetailsViewModel.cs`. Then we can wrap data we need.

```C#
namespace DotNetCoreTutorialJourney.ViewModels
{
    public class HomeDetailsViewModel
    {
        public Employee Employee { get; set; }
        public string PageTitle { get; set; }
    }
}
```

Then, in controller, we do

```C#
public ViewResult Details()
{
    // Instantiate HomeDetailsViewModel and store Employee details and PageTitle
    HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
    {
        Employee = _employeeRepository.GetEmployee(1),
        PageTitle = "Employee Details"
    };

    // Pass the ViewModel object to the View() helper method
    return View(homeDetailsViewModel);
}
```

Last, in view, we can do

```HTML
@model DotNetCoreTutorialJourney.ViewModels.HomeDetailsViewModel

<html>
<head>
    <title></title>
</head>
<body>
    <h3>@Model.PageTitle</h3>

    <div>
        Name : @Model.Employee.Name
    </div>
    <div>
        Email : @Model.Employee.Email
    </div>
    <div>
        Department : @Model.Employee.Department
    </div>
</body>
</html>
```

#### [Back to Table of Contents](#table-of-contents)

### Ep 27 - [List view in .Net Core MVC](https://www.youtube.com/watch?v=nHAMDUtiV6w&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=27)

If we want to display a list of objects, we can use **`IEnumerable<T>`**

The difference between `IEnumerable<T>` and `List<T>`

1. `IEnumerable<T>` is read-only

<p align="center">
  <img src="https://i.ibb.co/x1sw8Mm/IEnumerable-vs-List.png">
</p>
<p align="center">
  <img src="https://i.ibb.co/K9Ms9ct/IEnumerable-vs-List-2.png">
</p>

2. `IEnumerable<T>` describes behavior, while `List<T>` is an implementation of that behavior. 
If we use `IEnumerable<T>`, we get the opportunity to replace it with any generic type that inherits from it. 
It can be a `List<T>`, `Stack<T>`, `Queue<T>`, `LinkedList<T>` or `HashSet<T>` depending upon the requirement. 

3. When you use `IEnumerable<T>`, you give the compiler a chance to defer work until later, possibly optimizing along the way. 
If you use `List()` you **force the compiler to reify the results right away**. For example

```C#
public IEnumerable<Animals> AllSpotted()
{
    return from a in Zoo.Animals
           where a.coat.HasSpots == true
           select a;
}

public IEnumerable<Animals> Feline(IEnumerable<Animals> sample)
{
    return from a in sample
           where a.race.Family == "Felidae"
           select a;
}

public IEnumerable<Animals> Canine(IEnumerable<Animals> sample)
{
    return from a in sample
           where a.race.Family == "Canidae"
           select a;
}
```

Now you have a method that selects an initial sample ("AllSpotted"), plus some filters. So now you can do this:

```C#
var Leopards = Feline(AllSpotted());
var Hyenas = Canine(AllSpotted());
```

If we use `List<T>` for `AllSpotted()`, in this statement `var Leopards = Feline(AllSpotted());`, 
first, the database will return a huge list which has "AllSpotted". However, it has far more data than is actually needed.
Because we will filter it. In this case, we are not only waste time on database to return more than we need, 
but also waste time on our side for filtering.

If we use `IEnumerable<T>`, the `LINQ` will only generate `SQL` to query the database once by conbining `AllSpotted()` and `Feline()`.
And then we can use `.ToList()` if we want a list.

First, let us modify `IEmployeeRepository` interface to include `GetAllEmployees()` method.
```C#
public interface IEmployeeRepository
{
    Employee GetEmployee(int Id);
    IEnumerable<Employee> GetAllEmployees();
}
```

Then we can notice that the `MockEmployeeRepository.cs` shows an error. Because since we changed the interface. 
The repository need to implemente the new method in the interface. By right clicking the error, we can auto-generate the implementation code.
Modify it to this.
```C#
 public IEnumerable<Employee> GetAllEmployee()
{
    return _employeeList;
}
```

In `HomeController.cs`, we change the `Index()` action to this
```C#
public ViewResult Index()
{
    return View(_employeeRepository.GetAllEmployee());
}
```

In the view `Index.cshtml`, set `IEnumerable<DotNetCoreTutorialJourney.Models.Employee>` as the model for the view using `@model` directive
```HTML
@model IEnumerable<DotNetCoreTutorialJourney.Models.Employee>

<html>
<head>
    <title></title>
</head>
<body>
    <table>
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Department</th>
            </tr>
        </thead>
        <tbody>
            @foreach (var emp in Model)
            {
                <tr>
                    <td>
                        @emp.Id
                    </td>
                    <td>
                        @emp.Name
                    </td>
                    <td>
                        @emp.Department
                    </td>
                </tr>
            }
        </tbody>
    </table>
</body>
</html>
```

#### [Back to Table of Contents](#table-of-contents)

### Ep 28 - [Layout view in .Net Core MVC](https://www.youtube.com/watch?v=Px8nwoO7FO8&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=28)

<p align="center">
  <img src="https://i.ibb.co/Npd7SWN/layout-view-in-asp-net-core-mvc.png">
</p>

This is a common layout of a website. Without layout view, we will have duplicated elements like Header and Footer in each single page.

**Layout View in .NET Core MVC**
- Just like a regular view a layout view is also a file on the file system with a .cshtml extension
- You can think of a layout view as a master page in asp.net web forms.
- Since a layout view is not specific to a controller, we usually place the layout view in a sub folder called "Shared" in the "Views" folder
- By default, in ASP.NET Core MVC, the layout file is named `_Layout.cshtml`.
- In ASP.NET Core MVC, the file names of other .cshtml files like `_ViewStart.cshtml` and `_ViewImports.cshtml` start with an underscore.
- The leading underscore in the file name indicates that these files are not intended to be served directly by the browser.
- It is also possible to have multiple layout files in a single application. 
Perhaps one layout file for all admin users and a different layout file for all non admin users.

Let us add `root/Views/Shared/_Layout.cshtml`, and add following code to the file.

```HTML
<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>@ViewBag.Title</title>
</head>
<body>
    @RenderBody()
</body>
</html>
```

`@RenderBody()` is the location where view specific content is injected. For example, if `index.cshtml` view is rendered using this layout view, 
`index.cshtml `view content is injected at the location where we have `@RenderBody()` method call.

Since we only need the body content form other views which imported shared layout, we can keep body only in those pages. And import `_layout.cshtml`.

This is our `details.cshtml` View

```HTML
@model DotNetCoreTutorialJourney.ViewModels.HomeDetailsViewModel

@{
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Employee Details";
}

<h3>@Model.PageTitle</h3>

<div>
    Name : @Model.Employee.Name
</div>
<div>
    Email : @Model.Employee.Email
</div>
<div>
    Department : @Model.Employee.Department
</div>
```

Also, you can have multiple layout views

#### [Back to Table of Contents](#table-of-contents)

### Ep 29 - [Sections in layout page in .Net Core MVC](https://www.youtube.com/watch?v=9OyrzRVZT8o&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=29)

A layout page in ASP.NET Core MVC can also include a section. A section can be optional or mandatory. 
It provides a way to organize where certain page elements like `JavaScript` and `CSS` should be placed.

For example, when we want to add a `JavaScript` globally, we can add file to shared layout.
```HTML
<body>
    @RenderBody();
    <script src="~/js/CustomScript.js"></script>
</body>
```

However, when we only want to do this for certain file, like `Details.cshtml`, we can do
```HTML
<body>
    @RenderBody()
    @RenderSection("Scripts", required: false)
</body>
```

Notice that in `@RenderSection("Scripts", required: false);` if `required` is `true`, or we do not have this parameter like `@RenderSection("Scripts");`, 
it means this section is mandatory, and all pages use this shared layout should have a section called "Scripts".

And in `Details.cshtml`, we do
```HTML
@model DotNetCoreTutorialJourney.ViewModels.HomeDetailsViewModel

@{
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Employee Details";
}

<h3>@Model.PageTitle</h3>

<div>
    Name : @Model.Employee.Name
</div>
<div>
    Email : @Model.Employee.Email
</div>
<div>
    Department : @Model.Employee.Department
</div>

@section Scripts {
    <script src="~/js/CustomScript.js"></script>
}
```

Notice that we should not add `JavaScript` or `CSS` to pages directly.

#### [Back to Table of Contents](#table-of-contents)

### Ep 30 - [ViewStart page in .Net Core MVC](https://www.youtube.com/watch?v=r7WgjrTSlO8&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=30)

For now, we set the Layout property in each and every view. This violates DRY (Don't Repeat Yourself) principle, 
and has disadvantages of **Redundant code** and **Maintenance overhead**.

To use a different layout file, all the individual views need to be updated. This is not only tedious and time-consuming process, but also error prone.

So, instead of setting the Layout property in each individual view, we can move that code into the `_ViewStart.cshtml` file.

Let us create `root/Views/_ViewStart.cshtml` and add the following code.

```HTML
@{
    Layout = "_Layout";
}
```

Now, we can delete layout property in each individual view.

**_ViewStart.cshtml file is hierarchical**

We usually place the ViewStart file in the Views folder. Since this file is hierarchical we can also place it in any sub-folder in the Views folder.

<p align="center">
  <img src="https://i.ibb.co/FhZyDs3/View-Start-cshtml-in-ASP-NET-Core-MVC.png">
</p>

In the folder hierarchy above, we have placed one ViewStart file in the Views folder and another ViewStart file in the Home sub-folder. 
The layout page specified in the ViewStart file in the Home sub-folder **overwrites** the layout page specified in the ViewStart file in the Views folder.

If you want to use a layout file that is different from what is specified in _ViewStart.cshtml, 
you can do so by setting the Layout property in an individual view, it **overwrites** all others. You can also set the Layout property to **null**, 
if you want your view to be rendered without a layout view.

Also, you can apply logic to layout view
```HTML
@{
    if (User.IsInRole("Admin"))
    {
        Layout = "_AdminLayout";
    }
    else
    {
        Layout = "_NonAdminLayout";
    }
}
```

#### [Back to Table of Contents](#table-of-contents)

### Ep 31 - [ViewImports page in .Net Core MVC](https://www.youtube.com/watch?v=5HskoMcun9A&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=31)

`_ViewImports.cshtml` file is usually placed in the Views folder. It is used to include the common **namespaces** 
so we do not have to include them in every view that needs those namespaces. 

For example, we have `@model IEnumerable<DotNetCoreTutorialJourney.Models.Employee>` in `Index.cshtml` and 
`@model DotNetCoreTutorialJourney.ViewModels.HomeDetailsViewModel` in `Details.cshtml`

Instead, we add the following code to `root/Views/_ViewImports.cshtml`
```HTML
@using DotNetCoreTutorialJourney.Models;
@using DotNetCoreTutorialJourney.ViewModels;
```

And then, we can use `@model IEnumerable<Employee>` in `Index.cshtml` and `@model HomeDetailsViewModel` in `Details.cshtml`

Notice, `@using` directive is used to include the common **namespaces**. In addition to `@using` directive, 
`_ViewImports` file also supports the following directives.

```HTML
@addTagHelper
@removeTagHelper
@tagHelperPrefix
@model
@inherits
@inject
```

Just like, `_ViewStart.cshtml`, `_ViewImports.cshtml` is also **hierarchical**. It has the same hierarchical feature the `_ViewStart.cshtml` has.

#### [Back to Table of Contents](#table-of-contents)

### Ep 32 - [Routing in .Net Core MVC](https://www.youtube.com/watch?v=ZoxrbrHjj2g&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=32)

There are 2 routing techniques in ASP.NET Core MVC. **Conventional Routing** and **Attribute Routing**.

As we methioned before, in `Startup.cs`, we are using `app.UseMvcWithDefaultRoute();`, which is **Conventional Routing**.

[Here](https://github.com/aspnet/Mvc/blob/release/2.1/src/Microsoft.AspNetCore.Mvc.Core/Builder/MvcApplicationBuilderExtensions.cs) is the source code

```C#
public static IApplicationBuilder UseMvcWithDefaultRoute(this IApplicationBuilder app)
{
    if (app == null)
    {
        throw new ArgumentNullException(nameof(app));
    }

    return app.UseMvc(routes =>
    {
        routes.MapRoute(
            name: "default",
            template: "{controller=Home}/{action=Index}/{id?}");
    });
}
```

Which means `app.UseMvcWithDefaultRoute();` is implemented by
```C#
app.UseMvc(routes =>
{
    routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
});
```
We can use this one if we want more control over routes.

In this case, `=Home` and `=Index` give the route default value, which means `{server}` is the same as `{server}/Home/Index`.
And `{id?}` means the parameter is optional.

#### [Back to Table of Contents](#table-of-contents)

### Ep 33 - [Attribute Routing in .Net Core MVC](https://www.youtube.com/watch?v=prNptonJAiY&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=33)

In `Startup.cs`, if we use `app.UseMvc()` only without route, any URL we give will return 404 error.

**Attribute Routing Example**

With attribute routing, we use the `Route` attribute to define our routes. 
We could apply the `Route` attribute on the `Controller` or on the `Controller Action Methods`.

```C#
public class HomeController : Controller
{
    [Route("")]
    [Route("Home")]
    [Route("Home/Index")]
    public ViewResult Index()
    {
        return View();
    }
}
```

The `Route()` attribute is specified 3 times on the `Index()` action method. With each instance of the `Route()` attribute 
we specified a different route template. With these 3 route templates in place, the `Index()` action method of the `HomeController` will be executed 
for any of the following 3 URL paths.
- `/`
- `/Home`
- `/Home/Index`

Also, we can use it for parameters

```C#
[Route("Home/Details/{id?}")]
public ViewResult Details(int? id)
{
    HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
    {
        Employee = _employeeRepository.GetEmployee(id ?? 1),
        PageTitle = "Employee Details"
    };

    return View(homeDetailsViewModel);
}
```

With attribute routing the controller name and action method names play no role in which action is selected. Consider the example below. 

```C#
public class WelcomeController : Controller
{
    [Route("")]
    [Route("Home")]
    [Route("Home/Index")]
    public ViewResult Welcome()
    {
        return View("~/Views/Home/Index.cshtml", _employeeRepository.GetAllEmployee());
    }
}
```

`View()` needs an absolute path because it need to pass model to some place, which the default is the action name. 
However, the action name has been changed to `Welcome()`.

**Attribute Routes are Hierarchical**

The `Route()` attribute can be applied on the `Controller` class as well on the individual actions. To make attribute routing less repetitive, route attributes on the controller are combined with route attributes on the individual action methods. 

```C#
[Route("C")]
public class CController : Controller
{
    [Route("A")]
    public ViewResult A()
    {
        return View();
    }
}

public class CController : Controller
{
    [Route("C/A")]
    public ViewResult A()
    {
        return View();
    }
}
```

The two classes above have the same route

However, use `Route()` on `Controller` means it is adding the class route to action regardless. In example above, there is always a `C/` in action.
Using absolute path with start with `~/` to disable this feature.

```C#
[Route("Home")]
public class HomeController : Controller
{

    [Route("~/")]
    [Route("~/Home")]
    [Route("Index")]
    public ViewResult Index()
    {
        return View();
    }
}
```

With these templates in place, the `Index()` action method of the `HomeController` will be executed 
for any of the following 3 URL paths.
- `/`
- `/Home`
- `/Home/Index`

**Tokens in Attribute Routing**

Attribute routes support token replacement by enclosing a token in square-braces ([ ]). 
The tokens `[controller]` and `[action]` are replaced with the values of the controller name and action name where the route is defined. 
```C#
[Route("[controller]/[action]")]
public class HomeController : Controller
{
    [Route("~/")]
    [Route("~/Home")]
    public ViewResult Index()
    {
        return View();
    }

    [Route("{id?}")]
    public ViewResult Details(int? id)
    {
        HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
        {
            Employee = _employeeRepository.GetEmployee(id ?? 1),
            PageTitle = "Employee Details"
        };
        return View(homeDetailsViewModel);
    }
}
```

**Conventional Routing vs Attribute Routing**

With attribute routing, routes are placed next to the action methods that will actually use them. 
Attribute routes offer a bit more flexibility than conventional routes. 

However, in general, conventional routes are used for controllers that serve HTML pages, and attribute routes for controllers that serve REST APIs. 

However, there is nothing stopping us from mixing conventional routing with attribute routing in a single application to get a bit more flexibility with routes.

#### [Back to Table of Contents](#table-of-contents)

### Ep 35 - [Tag helpers in .Net Core MVC](https://www.youtube.com/watch?v=iaSdTMdReWg&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=35)

Tag Helpers are server side components. They are processed on the server to create and render HTML elements in Razor files. 
Tag Helpers are similar to HTML helpers.

To make the built-in tag helpers available for all the views in our entire application, import the tag helpers using `_ViewImports.cshtml` file.
```HTML
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
```
The wildcard * indicates that we want to import all the tag helpers.
Microsoft.AspNetCore.Mvc.TagHelpers is the assemly that contains the built-in tag helpers

There are 3 ways to generate links in Razor view.
1. Manually generating the links
```HTML
@foreach (var employee in Model)
{
    <a href="/home/details/@employee.Id">View</a>
}
```

2. Using HTML helpers
```HTML
@Html.ActionLink("View", "details", new { id = employee.Id })
```
Which generates an anchor element
```HTML
 <a href="/hom/details/5">View</a>
 ```
 Or we can use 
 ```HTML
 @Url.Action("details", "home", new { id = employee.Id })
 ```
 Which generates a string
 ```HTML
 /home/details/5
 ```
so we can style it.

3. Using Tag Helpers
```HTML
<a asp-controller="home" asp-action="details" asp-route-id="@employee.Id" class="btn btn-primary">View</a>
```
Which generates an anchor element
```HTML
<a href="/Home/details/5" class="btn btn-primary">View</a>
```

**Advantage of using Tag helpers**

Tag helpers generate links based on the application routing templates. This means if we later change routing templates, 
the links generated by tag helpers will automatically reflect those changes made to the routing templates. The generated links just work. 

Where as if we have hard-coded the URL paths manually, we would have to change the code in lot of places when the application routing templates change.

For example, if we change the route from this
```C#
app.UseMvc(routes =>
{
    routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
});
```
to 
```C#
app.UseMvc(routes =>
{
    routes.MapRoute("default", "v1/{controller=Home}/{action=Index}/{id?}");
});
```
Where as the code that's not using the anchor tag helper continues to generate the  link which the URL path **"/v1"** is missing.

```HTML
<a href="/v1/home/details/1">View</a>
<a href="/home/details/1">View</a>
```

We also have tag helpers that generate forms. When this form is posted back to the server, 
the posted values are automatically handled and the associated validation messages are displayed. 
Without these tag helpers we would have to write a lot of custom code to achieve the same. 

#### [Back to Table of Contents](#table-of-contents)

### Ep 37 - [Image Tag helpers in .Net Core MVC](https://www.youtube.com/watch?v=4jW9T-TLPTM&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=37)

When we visit a web page, most modern browsers cache the images of that web page. 
When we visit the page again, instead of downloading the same image again from the web server, 
the browser serves the image from the cache. In most cases, this is not a problem as images do not change that frequently.

From a performance standpoint, wouldn't it be great to download the image only if it has changed on the server. 
If the image has not changed, use the image from the browser cache. This means we will have the best of both the worlds.

Image Tag Helper can help us achieve this. To use the Image tag helper, 
include `asp-append-version` attribute and set it to true.

```HTML
<img src="~/images/noimage.jpg" asp-append-version="true" />
```
**Image Tag Helper** enhances the `<img>` tag to provide **cache-busting behavior** for static image files. 
Based on the content of the image, a unique hash value is calculated and is appended to image URL. 
This unique string prompts the browser to reload the image from the server and not from the browser cache.

```HTML
<img class="card-img-top" src="/images/noimage.jpg?v=IqNLbsazJ7ijEbbyzWPke-xWxkOFaVcgzpQ4SsQKBqY" />
```

#### [Back to Table of Contents](#table-of-contents)

### Ep 38 - [Environment Tag helpers in .Net Core MVC](https://www.youtube.com/watch?v=-E4zP2L-R_U&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=38)

- For ease of debugging, on our local development machine (i.e on the **Development Environment**) we want the application to load non-minified bootstrap css file (bootstrap.css)

- On **Staging, Production** or any other environment except Development environment we want the application to load minified bootstrap css file (bootstrap.min.css) 
from a **CDN** (Content Delivery Network) for better performance.

- However, if the **CDN is down** or for some reason, our application is not able to reach the CDN, 
we want our application to fallback and load the minified bootstrap file (bootstrap.min.css) from our own application web server.

We can achieve this very easily using ASP.NET Core `<environment>` tag helper.

Use the `ASPNETCORE_ENVIRONMENT` variable to set the application environment. 
On our local development machine we usually set this environment variable in `launchsettings.json file`. 
On a staging or production environment it is set **in the operating system**. 

When we add script to `_Layout.cshtml`, we can do
```HTML
    <environment include="Development">
        <link href="~/node_modules/bootstrap/dist/css/bootstrap.css" rel="stylesheet" />
        <script src="~/node_modules/jquery/dist/jquery.slim.js"></script>
        <script src="~/node_modules/popper.js/dist/umd/popper.js"></script>
        <script src="~/node_modules/bootstrap/dist/js/bootstrap.js"></script>
    </environment>

    <environment exclude="Development">
        <link rel="stylesheet"
            href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"
            integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"
            crossorigin="anonymous"
            asp-fallback-href="~/node_modules/bootstrap/dist/css/bootstrap.min.css"
            asp-fallback-test-class="sr-only" 
            asp-fallback-test-property="position"
            asp-fallback-test-value="absolute"
            asp-suppress-fallback-integrity="true" />
        <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"
            integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"
            crossorigin="anonymous"
            asp-fallback-href="~/node_modules/jquery/dist/jquery.slim.min.js"
            asp-fallback-test-class="sr-only" 
            asp-fallback-test-property="position"
            asp-fallback-test-value="absolute"
            asp-suppress-fallback-integrity="true"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"
            integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"
            crossorigin="anonymous"
            asp-fallback-href="~/node_modules/popper.js/dist/umd/popper.min.js"
            asp-fallback-test-class="sr-only" 
            asp-fallback-test-property="position"
            asp-fallback-test-value="absolute"
            asp-suppress-fallback-integrity="true"></script>
        <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"
            integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"
            crossorigin="anonymous"
            asp-fallback-href="~/node_modules/bootstrap/dist/js/bootstrap.min.js"
            asp-fallback-test-class="sr-only" 
            asp-fallback-test-property="position"
            asp-fallback-test-value="absolute"
            asp-suppress-fallback-integrity="true"></script>
    </environment>
```

 the application environment is "Development", non-minified bootstrap css file (bootstrap.css) is loaded from our application web server

If the application environment IS NOT "Development", minified bootstrap css file (bootstrap.min.css) is loaded from the CDN

A fallback source is specified using asp-fallback-href attribute. This means, if the CDN is down, our application fallsback and load the minified bootstrap file (bootstrap.min.css) from our own application web server

The following 3 attributes and their associated values are used to check if the CDN is down
```C#==HTML
asp-fallback-test-class="sr-only" 
asp-fallback-test-property="position" 
asp-fallback-test-value="absolute"
```

Obviously, there is some processing involved to calculate hash and compare it with the integrity attribute hash value. For most applications, fallback source is their own server. You have the option to turn off integrity check for the files downloaded from the fallback source by setting `asp-suppress-fallback-integrity` attribute to `true`.

#### [Back to Table of Contents](#table-of-contents)

### Ep 40 - [Form Tag helpers in .Net Core MVC](https://www.youtube.com/watch?v=mU4hV50rkVE&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=40)

We use the following common tag helpers to create a form in ASP.NET Core
- Form Tag Helper
- Label Tag Helper
- Input Tag Helper
- Select Tag Helper
- Textarea Tag Helper
- Validation Tag Helper

**Form Tag Helper**

To create a form we use the `<form>` tag helper

Notice, we are using `asp-controller` and `asp-action` tag helpers. 
These 2 tag helpers specify the controller and the action method to which the form data must be posted when the form is submitted. 
We want to issue a `POST` request when the form is submitted, so we have set the method attribute to `post`

```HTML
<form asp-controller="home" asp-action="create" method="post">
</form>
```

The above code produces the following HTML when the form is rendered on the client browser.

```HTML
<form method="post" action="/home/create"></form>
```

**Please note** : By default, when a form is submitted, it will be posted to the same action of the controller that rendered the form. 
So this means, even if we did not specify the controller and action using the asp-controller and asp-action tag helpers, 
the form will still be posted to the index() action of the HomeController.

**Input Tag Helper**

First, we can import `Employee` class because we want to create a new employee.

```HTML
@model Employee
```

To b able to capture the employee name we want a text box. We want the text box to **bind to the Name property of the Employee model class**. 
We do this by using `asp-for` tag helper and setting it's value to the Name property of the Employee model class. 
Notice we also have intellisense. Later if we change the property name form Name to FullName on the Employee class, 
and if we do not change the value assigned to the tag helper, we get a compiler error.

```HTML
<input asp-for="Name">
```

The above code generates an input element with id and name attributes. Notice both of them are set to a value of Name. 

```HTML
<input type="text" id="Name" name="Name" value="">
```

The name attribute is **required** and it is used to **map the value of the input element to the corresponding property of the model class** when the form is submitted. 
This is done by a process called **model binding** in ASP.NET Core. 

**Label Tag Helper**

The Label Tag Helper generates a label with for attribute. The for attribute links the label with it's associated input element.

```HTML
<label asp-for="Name"></label>
<input asp-for="Name">
```

The above code generates the following HTML. 

```HTML
<label for="Name">Name</label>
<input type="text" id="Name" name="Name" value="">
```

The label is linked to the input element, because both the label for attribute and the input element id attribute have the same value (Name). 
So this means when we click on the label, the corresponding input element receives the focus.

**Select Tag Helper**

The options for the department select element can be hard-coded, or they can come from an **`enum`** or a **database table**.

Place the following `enum` in `Dept.cs` file in the `Models` folder

```C#
namespace EmployeeManagement.Models
{
    public enum Dept
    {
        None,
        HR,
        IT,
        Payroll
    }
}
```

Update the `Employee` class in `Employee.cs` file in the Models folder
Department property data type is Dept `enum`.

```C#
namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Dept Department { get; set; }
    }
}
```

In `MockEmployeeRepository.cs` we change the code to this `Department = Dept.HR`

```C#
public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Mary", Department = Dept.HR, Email = "mary@gmail.com" },
                new Employee() { Id = 2, Name = "John", Department = Dept.IT, Email = "john@gmail.com" },
                new Employee() { Id = 3, Name = "Sam", Department = Dept.IT, Email = "sam@gmail.com" },
            };
        }
```

In `Create.cshtml` view, include the following code

```HTML
<label asp-for="Department"></label>
<select asp-for="Department"
        asp-items="Html.GetEnumSelectList<Dept>()"></select>
```

The above code generates the following HTML. 

```HTML
<div>
    <label for="Department">Department</label>
    <select id="Department" name="Department">
        <option value="0">None</option>
        <option value="1">HR</option>
        <option value="2">IT</option>
        <option value="3">Payroll</option>
    </select>
</div>
```

#### [Back to Table of Contents](#table-of-contents)

### Ep 41 - [.Net Core Model Binding](https://www.youtube.com/watch?v=-GkZERrqEQo&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=41)

**What is Model Binding**

- Model binding maps data in an HTTP request to controller action method parameters
- The action parameters may be simple types such as integers, strings, etc or complex types like Customer, Employee, Order etc.
- Model binding is great, because without it we have to write lot of custom code to map request data to action method parameters 
which is not only tedious but also error prone.

**ASP.NET Core Model Binding Example**

When an HTTP request arrives at our MVC application it is the `Controller action` method that handles the incoming request.

```HTML
http://localhost:xxxxx/home/details/2?name=tom&id=99&gendee=male
```

The following `Details()` action method handles the above request URL and maps the value `2` to the **id** parameter, 
the value `tom` to the **name** parameter and the value `male` to the **gendee**.

```C#
public string Details(int? id, string name, string gender)
{
    return "id = " + id.Value.ToString() + " and name = " + name + " and gender = " + gender;
}
```

Result

```HTML
id=2 and name= tom and gender =
```

In this case, the name mapped to parameter name, the gendee has a typo which means it mapped to parameter gendee instead of gender.

And the mapped id value is 2 instead of 99, because model binding looks for data in the HTTP request in the following places in the order specified below.

1. Form values
2. Route values
3. Query strings

So, the id 2 here is Route values which has higher priority than the query strings 99.
And because of the route value id here is optional, we can do this

```HTML
http://localhost:xxxxx/home/details?name=tom&id=99&gendee=male
```

Then the result will be

```HTML
id=99 and name= tom and gender =
```

**Model Binding Objects**

In create form, we set the form method to `post` before. Let us implement it.

First, in `IEmployeeRepository.cs` interface, we can add
```C#
void AddEmployee(Employee employee);
```

Then, we need to implement the repository `MockEmployeeRepository.cs`
```C#
public void AddEmployee(Employee employee)
{
    employee.Id = _employeeList.Max(e => e.Id) + 1;
    _employeeList.Add(employee);
}
```
In this case, the employee id will be auto-increment by 1.

Then, we can add another `Create` class in the controller to handle the post.

```C#
[HttpGet]
public ViewResult Create()
{
    return View();
}
[HttpPost]
public RedirectToActionResult Create(Employee employee)
{
    _employeeRepository.AddEmployee(employee);
    return RedirectToAction("details", new {id = employee.Id});
}
```

To avoid ambiguity, we use `[HttpGet]` and `[HttpPost]` to specify two actions.
And in post action, after adding employee, we redirect to the details page of that new employee. 
```C#

public virtual RedirectToActionResult RedirectToAction(string actionName, object routeValues);
```

Notice that the `RedirectToAction` can take two parameters here.

#### [Back to Table of Contents](#table-of-contents)

### Ep 42 - [.Net Core Model Validation](https://www.youtube.com/watch?v=aDRC_IgwmH8&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=42)

First, we need to modify the model attributes
```C#
public class Employee
{
    public int Id { get; set; }
    [Required, MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
    public string Name { get; set; }
    [Display(Name = "Office Email")]
    [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email format")]
    [Required]
    public string Email { get; set; }
    public Dept Department { get; set; }
}
```

**ASP.NET Core Built-in Model Validation Attributes**

The following are some of the common built-in validation attributes in ASP.NET Core.

**Attribute** | **Purpose**
:---: | :---:
Required | Specifies the field is required
Range | Specifies the minimum and maximum value allowed
MinLength | Specifies the minimum length of a string
MaxLength | Specifies the maximum length of a string
Compare | Compares 2 properties of a model. For example compare Email and ConfirmEmail properties
RegularExpression | Validates if the provided value matches the pattern specified by the regular expression

Then, we can display the validation message in the page
```HTML
<span asp-validation-for="Name" class="text-danger"></span>
<span asp-validation-for="Email" class="text-danger"></span>
<div asp-validation-summary="All" class="text-danger"></div>
```

Last, we add conditions in the action, if the model is not valid, the redirect will not happen.

```C#
public IActionResult Create(Employee employee)
{
    if (ModelState.IsValid) 
    {
        _employeeRepository.AddEmployee(employee);
        return RedirectToAction("details", new {id = employee.Id});
    }
    return View();
}
```

Notice that since we return both `RedirectToAction` and `View` in this method, we changed return type `ReidrectToActionResult` to `IActionResult`. 
Which means both `RedirectToAction` and `View` are implementation of `IActionResult`.

#### [Back to Table of Contents](#table-of-contents)

### Ep 43 - [.Net Core Model Select List Validation](https://www.youtube.com/watch?v=woFHR3iNEEI&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=43)

First, we can add an option `Please Selet` with value `""` to the list.

```HTML
<div>
    <label asp-for="Department"></label>
    <div>
        <select asp-for="Department" asp-items="Html.GetEnumSelectList<Dept>()">
            <option value="">Please Select</option>
        </select>
        <span asp-validation-for="Department" class="text-danger"></span>
    </div>
</div>
```

Then, when we submit with this option, the error message will be 
```HTML
The value '' is invalid.
```

This is because we are using `enum` in `Dept.cs`, which each elements there has a value start from `0`. 
However, the value we are submitting is `null` and the `Department` attribute in `Employee` class is not `nullable`. 
Which gives the above error message.

So, we can make the `Department` attribute `nullable` and `required` for validation.
```C#
[Required]
public Dept? Department { get; set; }
```

#### [Back to Table of Contents](#table-of-contents)
























































































































































