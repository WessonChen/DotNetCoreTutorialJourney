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
34. [Ep 44 - AddSingleton vs AddScoped vs AddTransient](#ep-44---addSingleton-vs-addscoped-vs-addtransient)
35. [Ep 45 - Entity Framework Core](#ep-45---entity-framework-core)
36. [Ep 46 - Install Entity Framework Core](#ep-46---install-entity-framework-core)
37. [Ep 47 - DbContext in Entity Framework Core](#ep-47---dbContext-in-entity-framework-core)
38. [Ep 48 - Using sql server with Entity Framework Core](#ep-48---using-sql-server-with-entity-framework-core)
39. [Ep 49 - Repository Pattern in Entity Framework Core](#ep-49---repository-pattern-in-entity-framework-core)
40. [Ep 50 - Entity Framework Core Migrations](#ep-50---entity-framework-core-migrations)
41. [Ep 51 - Entity Framework Core Seed Data](#ep-51---entity-framework-core-seed-data)
42. [Ep 52 - Keeping Domain Models and Database Schema in Sync](#ep-52---keeping-domain-models-and-database-schema-in-sync)
43. [Ep 53 - File Upload in .Net Core MVC](#ep-53---file-upload-in-net-core-mvc)
44. [Ep 55 - Edit View in .Net Core MVC](#ep-55---edit-view-in-net-core-mvc)
45. [Ep 57 - Handling 404 Not Found in .Net Core MVC](#ep-57---handling-404-not-found-in-net-core-mvc)
46. [Ep 59 - UseStatusCodePagesWithRedirects vs UseStatusCodePagesWithReExecute](#ep-59---usestatuscodepageswithredirects-vs-usestatuscodepageswithreexecute)
47. [Ep 60 - Global Exception Handling in .Net Core MVC](#ep-60---global-exception-handling-in-net-core-mvc)
48. [Ep 61 - Logging in .Net Core MVC](#ep-61---logging-in-net-core-mvc)
49. [Ep 62 - Logging Exceptions in .Net Core MVC](#ep-62---logging-exceptions-in-net-core-mvc)
50. [Ep 63 - Logging to File in .Net Core MVC Using Nlog](#ep-63---logging-to-file-in-net-core-mvc-using-nlog)
51. [Ep 64 - LogLevel Configuration in .Net Core MVC](#ep-64---loglevel-configuration-in-net-core-mvc)
52. [Ep 65 - Identity in .Net Core MVC](#ep-65---identity-in-net-core-mvc)
53. [Ep 66 - Register in .Net Core MVC](#ep-66---register-in-net-core-mvc)
54. [Ep 67 - Register in .Net Core MVC by UserManager and SignInManager](#ep-67---register-in-net-core-mvc-by-usermanager-and-signinmanager)
55. [Ep 68 - Identity Password Complexity in .Net Core MVC](#ep-68---identity-password-complexity-in-net-core-mvc)
56. [Ep 69 - Navigation Bar Based on Login Status in .Net Core MVC](#ep-69---navigation-bar-based-on-login-status-in-net-core-mvc)
57. [Ep 70 - Login in .Net Core MVC](#ep-70---login-in-net-core-mvc)
58. [Ep 71 - Authorization in .Net Core MVC](#ep-71---authorization-in-net-core-mvc)
59. [Ep 72 - Redirect User to Original URL after Login in .Net Core MVC](#ep-72---redirect-user-to-original-url-after-login-in-net-core-mvc)
60. [Ep 73 - Open redirect vulnerability example](#ep-73---open-redirect-vulnerability-example)
61. [Ep 74 - Client Side Validation in .Net Core MVC](#ep-74---client-side-validation-in-net-core-mvc)
62. [Ep 75 - Remote Validation in .Net Core MVC](#ep-75---remote-validation-in-net-core-mvc)
63. [Ep 76 - Custom Validation Attribute in .Net Core MVC](#ep-76---custom-validation-attribute-in-net-core-mvc)
64. [Ep 77 - Extend IdentityUser in .Net Core MVC](#ep-77---extend-identityuser-in-net-core-mvc)
65. [Ep 78 - Creating Roles in .Net Core MVC](#ep-78---creating-roles-in-net-core-mvc)
66. [Ep 79 - Get List of Roles in .Net Core MVC](#ep-79---get-list-of-roles-in-net-core-mvc)
67. [Ep 80 - Edit Role in .Net Core MVC](#ep-80---edit-role-in-net-core-mvc)

 
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
Notice, we have 2 profiles - **IIS Express** and **DotNetCoreTutorialJourney** 

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
@model DotNetCoreTutorialJourney.Employee

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
        var employee = ViewData["Employee"] as DotNetCoreTutorialJourney.Models.Employee;
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
@model DotNetCoreTutorialJourney.Models.Employee

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
namespace DotNetCoreTutorialJourney.Models
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
namespace DotNetCoreTutorialJourney.Models
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

This is because we are using `enum` in `Dept.cs`, which by default an `enum` underlying data type is `int`, start from `0`. 
However, the value we are submitting is `""` and value types (such as int, float, decimal, DateTime) are **inherently required and don't need the Required attribute**.
Which gives the above error message.

So, we can make the `Department` attribute `nullable` and `required` for validation.
```C#
[Required]
public Dept? Department { get; set; }
```

#### [Back to Table of Contents](#table-of-contents)

### Ep 44 - [AddSingleton vs AddScoped vs AddTransient](https://www.youtube.com/watch?v=v6Nr7Zman_Y&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=44)

With a singleton service, there is only a single instance. An instance is created, 
when the service is first requested and that single instance is used by all http requests throughout the application.

With a scoped service we get the same instance within the scope of a given http request 
but a new instance across different http requests.

With a transient service a new instance is provided everytime an instance is requested 
whether it is in the scope of the same http request or across different http requests.

**Service Type** | **In the scope of a given http request** | Across different http requests**
:---: | :---: | :---:
Singleton Service | Same Instance | Same Instance
Scoped Service | Same Instance | New Instance
Transient Service | New Instance | New Instance

#### [Back to Table of Contents](#table-of-contents)

### Ep 45 - [Entity Framework Core](https://www.youtube.com/watch?v=OE0_9c-K-Ow&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=45)

**What is EF Core**

EF Core is an ORM (Object-Relational Mapper). EF core is lightweight, extensible, and open source software. Like .NET Core, EF Core is also cross platform.

**What is ORM**

ORM stands for Object-Relational Mapper and it enables developers to work with a database using business objects. 
As a developer we work with the application business objects and the ORM generates the SQL that the underlying database understands. 
In-short, an ORM, eliminates the need for most of the data-access code that developers usually need to write.  

**Why use an ORM**

If we are developing an application to manage employees we would have classes like Employee, Department etc in our application code. 
These classes are called the Domain classes. 

Without an ORM like EF Core, we have to write a lot of custom data access code to store and retrieve employee and department data from the underlying database. 

For example to read, insert, update or delete data from the underlying database table we have to write code in the application 
to generate the required sql statements that the underlying database understands. Also when the data is read from the database into our application, 
we again have to write custom code to map the database data to our model classes like Employee, Department etc.

An ORM like EF Core can do all of this for us and saves a lot of time. It sits between our application code and the Database. 
It eliminates the need for most of the custom data-access code that we usually have to write without an ORM. 

<p align="center">
  <img src="https://i.ibb.co/YTGtFCz/entity-framework-core-tutorial.png">
</p>

**EF Core Code First Approach**

EF Core supports both Code First approach and Database First approach. 
However, with the Database First approach there is very limited support in EF core at the moment. 

<p align="center">
  <img src="https://i.ibb.co/5K9QVQV/ef-core-code-first-approach.png">
</p>

With the Code First Approach, we first create our application domain classes like Employee, Customer etc and a special class that derives from Entity Framework `DbContext` class. 
Based on these domain and DBContext classes, **EF Core creates the database and relevant tables**. Out of the box, 
EF Core uses it's default conventions to create the database and database tables. You can change these default conventions if you want to.

**EF Core Database First Approach**

<p align="center">
  <img src="https://i.ibb.co/qyGGmKV/ef-core-database-first-approach.png">
</p>

Sometimes we may have an existing database. When we have a database and the database tables already, we use the database first approach. 
With the database first approach, EF Core creates the DBContext and Domain classes based on the existing database schema. 

**EF Core Database Providers**

EF Core supports many relational and even non relational databases. EF Core is able to do this by using plug-in libraries called the database providers. 
These database providers are available as NuGet packages.  

<p align="center">
  <img src="https://i.ibb.co/Y0gQftW/ef-core-database-providers.png">
</p>

List of EF Core Database Providers
> https://docs.microsoft.com/en-us/ef/core/providers/ 

A database provider, usually sits between EF Core and the database it supports. 
The database provider contains the functionality specific to the database it supports. 

#### [Back to Table of Contents](#table-of-contents)

### Ep 46 - [Install Entity Framework Core](https://www.youtube.com/watch?v=8aHzSx-inDE&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=46)

Depending on how you have your project set up, you may have Entity Framework Core already installed. 

**Single Layer Web Application**

If it's a small project, you may have your presentation layer, business layer and data access layer all in one project. 
So if you have created a web application project using ASP.NET Core 2.1 or higher, then in that web application project, 
you already have Entity Framework Core installed. 

**Entity Framework Core in ASP.NET Core Web Application Project**

An ASP.NET Core Web application project that is created using ASP.NET Core 2.1 or higher has the following NuGet package installed. 
> Microsoft.AspNetCore.App

This package is called - metapackage. A metapackage has no content of its own but is a list of dependencies (other packages). 
You can find this metapackage, in the Solution Explorer. When you expand the metapackage, you can find all the dependencies. 
In the dependencies you will find the Entity Framework Core nuget packages already installed. 

**Multi Layer Web Application**

In a large application we will usually have at least the following 3 layers 
- Presentation Layer
- Business Logic Layer
- Data Access Layer

These layers are implemented as separate projects. Entity Framework Core is usually required in the Data Access Layer project. 
The Data Access Layer project is a class library project and does not usually have the meta package referenced. So this means, 
Entity Framework Core is not installed for the Data Access Layer project. 

To install Entity Framework Core and to be able to use SQL server as the database for your application, 
you need to install the following nuget packages. 

**Package**	| **Purpose**
:---: | :---:
Microsoft.EntityFrameworkCore.SqlServer	| This nuget package contains SQL Server specific functionality
Microsoft.EntityFrameworkCore.Relational | This nuget package contains functionality that is common to all relational databases
Microsoft.EntityFrameworkCore | This nuget package contains common entity frameowrk core functionality

<p align="center">
  <img src="https://i.ibb.co/ckxGV2P/install-ef-core-in-visual-studio.png">
</p>

This image is the dependant relationships. When we install `Microsoft.EntityFrameworkCore.SqlServer` package, 
it also installs all the other dependant nuget packages automatically.  

If you want to use a different database with your application, then you will have to install that database provider specific nuget package 
instead of `Microsoft.EntityFrameworkCore.SqlServer` database provider package. 

For example, if you want to use mysql as your database, then install `Pomelo.EntityFrameworkCore.MySql` database provider package. 

You can find all the provider specific NuGet packages on the following MSDN page
> https://docs.microsoft.com/en-us/ef/core/providers/ 

#### [Back to Table of Contents](#table-of-contents)

### Ep 47 - [DbContext in Entity Framework Core](https://www.youtube.com/watch?v=nN9jOORIFtc&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=47)

One of the very important classes in Entity Framework Core is the `DbContext` class. This is the class that we use in our application code 
to interact with the underlying database. It is this class that manages the database connection and is used to retrieve and save data in the database. 

**To use the DbContext class in our application**
- We create a class that derives from the `DbContext` class.
- `DbContext` class is in `Microsoft.EntityFrameworkCore` namespace.

```C#
public class AppDbContext : DbContext
{
}
```

**DbContextOptions in Entity Framework Core**
- For the `DbContext` class to be able to do any useful work, it needs an instance of the `DbContextOptions` class.
- The `DbContextOptions` instance carries configuration information such as the connection string, database provider to use etc.
- To pass the `DbContextOptions` instance we use the constructor as shown in the example below.

```C#
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
}
```

**Entity Framework Core DbSet**
- The `DbContext` class includes a `DbSet<TEntity>` property for each entity in the model.
- At the moment in our application we have, only one entity class - `Employee`.
- So in our `AppDbContext` class we only have one `DbSet<Employee>` property.
- We will use this `DbSet` property `Employees` to query and save instances of the `Employee` class.
- The LINQ queries against the `DbSet<TEntity>` will be translated into queries against the underlying database.

```C#
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Employee> Employees { get; set; }
}
```

#### [Back to Table of Contents](#table-of-contents)

### Ep 48 - [Using sql server with Entity Framework Core](https://www.youtube.com/watch?v=xMktEpPmadI&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=48)

When using Entity Framework Core, one of the important things that we need to configure is the database provider that we plan to use. 
Entity Framework Core supports a wide variety of databases including non-relational databases. 
The following MSDN link has the list of all supported databases.
> https://docs.microsoft.com/en-us/ef/core/providers/ 

```C#
public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContextPool<AppDbContext>(
		options => options.UseSqlServer(_config.GetConnectionString("EmployeeDBConnection")));
	services.AddMvc().AddXmlSerializerFormatters();
	services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
}
```

- We want to configure and use Microsoft SQL Server with entity framework core.
- We usually specify this configuration in `ConfigureServices()` method in `Startup.cs` file.

**Difference between `AddDbContext()` and `AddDbContextPool()` methods**
- We can use either `AddDbContext()` or `AddDbContextPool()` method to register our application specific DbContext class with the ASP.NET Core dependency injection system.
- The difference between `AddDbContext()` and `AddDbContextPool()` methods is, `AddDbContextPool()` method provides **DbContext pooling**.
- With **DbContext pooling**, an instance from the DbContext pool is provided if available, rather than creating a new instance.
- From a performance standpoint `AddDbContextPool()` method is **better** over `AddDbContext()` method.
- `AddDbContextPool()` method is introduced in ASP.NET Core 2.0. So if you are using ASP.NET Core 2.0 or later use `AddDbContextPool()` method over `AddDbContext()` method.

**UseSqlServer() Extension Method**
- `UseSqlServer()` extension method is used to configure our application specific DbContext class to use Microsoft SQL Server as the database.
- To connect to a database, we need the database connection string which is provided as a parameter to `UseSqlServer()` extension method.

**Database Connection String in ASP.NET Core**

Instead of hard-coding the connection string in application code, we store it `appsettings.json` configuration file. 

```json
{
  "ConnectionStrings": {
    "EmployeeDBConnection": "server=(localdb)\\MSSQLLocalDB;database=EmployeeDB;Trusted_Connection=true"
  }
}
```
To read connection string from `appsettings.json` file we use `IConfiguration` service `GetConnectionString()` method. 

What is the difference between the following in a database connection string 
- Trusted_Connection=True;
- Integrated Security=SSPI;
- Integrated Security=true;

All the above 3 settings specify the same thing, use Integrated Windows Authentication to connect to SQL Server instead of using SQL Server authentication. 

#### [Back to Table of Contents](#table-of-contents)

### Ep 49 - [Repository Pattern in Entity Framework Core](https://www.youtube.com/watch?v=qJmEI2LtXIY&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=49)

**What is Repository Pattern**

Repository Pattern is an abstraction of the Data Access Layer. It hides the details of how exactly the data is saved or retrieved from the underlying data source. 
The details of how the data is stored and retrieved is in the respective repository. For example, you may have a repository that stores and retrieves data from an in-memory collection. 
You may have another repository that stores and retrieves data from a database like SQL Server

```C#
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public Dept? Department { get; set; }
}
```

**Repository Pattern Interface**

The interface in the repository pattern specifies 
- What operations (i.e methods) are supported by the repository
- The data required for each of the operations i.e the parameters that need to be passed to the method and the data the method returns
- The repository interface contains what it can do, but not, how it does, what it can do
- The implementation details are in the respective repository class that implements the repository Interface

```C#
public interface IEmployeeRepository
{
    Employee GetEmployee(int Id);
    IEnumerable<Employee> GetAllEmployee();
    Employee Add(Employee employee);
    Employee Update(Employee employeeChanges);
    Employee Delete(int Id);
}
```

**Repository Pattern - In-memory Implementation**

The following `MockEmployeeRepository` class provides an implementation for `IEmployeeRepository`. 
This specific implementation stores and retrieves employees from an in-memory collection. 

```C#
public class MockEmployeeRepository : IEmployeeRepository
{
    private List<Employee> _employeeList;

    public MockEmployeeRepository()
    {
        _employeeList = new List<Employee>()
        {
            new Employee() { Id = 1, Name = "Mary", Department = Dept.HR, Email = "mary@gmail.com" },
            new Employee() { Id = 2, Name = "John", Department = Dept.IT, Email = "john@gmail.com" },
            new Employee() { Id = 3, Name = "Sam", Department = Dept.IT, Email = "sam@gmail.com" },
        };
    }

    public Employee Add(Employee employee)
    {
        employee.Id = _employeeList.Max(e => e.Id) + 1;
        _employeeList.Add(employee);
        return employee;
    }

    public Employee Delete(int Id)
    {
        Employee employee = _employeeList.FirstOrDefault(e => e.Id == Id);
        if (employee != null)
        {
            _employeeList.Remove(employee);
        }
        return employee;
    }

    public IEnumerable<Employee> GetAllEmployee()
    {
        return _employeeList;
    }

    public Employee GetEmployee(int Id)
    {
        return this._employeeList.FirstOrDefault(e => e.Id == Id);
    }

    public Employee Update(Employee employeeChanges)
    {
        Employee employee = _employeeList.FirstOrDefault(e => e.Id == employeeChanges.Id);
        if (employee != null)
        {
            employee.Name = employeeChanges.Name;
            employee.Email = employeeChanges.Email;
            employee.Department = employeeChanges.Department;
        }
        return employee;
    }
}
```

**Repository Pattern - SQL Server Implementation**

The following `SQLEmployeeRepository` class provides another implementation for `IEmployeeRepository`. 
This specific implementation stores and retrieves employees from a sql server database using entity framework core. 

```C#
public class SQLEmployeeRepository : IEmployeeRepository
{
    private readonly AppDbContext context;

    public SQLEmployeeRepository(AppDbContext context)
    {
        this.context = context;
    }

    public Employee Add(Employee employee)
    {
        context.Employees.Add(employee);
        context.SaveChanges();
        return employee;
    }

    public Employee Delete(int Id)
    {
        Employee employee = context.Employees.Find(Id);
        if (employee != null)
        {
            context.Employees.Remove(employee);
            context.SaveChanges();
        }
        return employee;
    }

    public IEnumerable<Employee> GetAllEmployee()
    {
        return context.Employees;
    }

    public Employee GetEmployee(int Id)
    {
        return context.Employees.Find(Id);
    }

    public Employee Update(Employee employeeChanges)
    {
        var employee = context.Employees.Attach(employeeChanges);
        employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        context.SaveChanges();
        return employeeChanges;
    }
}
```

**Which implementation to use** 

Take a look at the following `HomeController` in our application. ASP.NET Core Dependency injection system injects an instance of `IEmployeeRepository`. 

```C#
public class HomeController : Controller
{
    private IEmployeeRepository _employeeRepository;

    public HomeController(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    // Rest of the code
}
```

There are 2 implementations for `IEmployeeRepository` interface. How does the application know which implementation to use. 
The answer to this is in `Startup` class in `Startup.cs` file. With the following line of code, 
ASP.NET Core provides an instance of `SQLEmployeeRepository` class when an instance of `IEmployeeRepository` is requested. 

We are using` AddScoped()` method because we want the instance to be alive and available for the entire scope of the given HTTP request. 
For another new HTTP request, a new instance of `SQLEmployeeRepository` class will be provided and it will be available throughout the entire scope of that HTTP request. 

```C#
public void ConfigureServices(IServiceCollection services)
{
    // Rest of the code
    services.AddScoped<IEmployeeRepository, SQLEmployeeRepository>();
}
```

**Benefits of Repository Pattern**
- The code is cleaner, and easier to reuse and maintain.
- Enables us to create loosely coupled systems.
- In an unit testing project, it is easy to replace a real repository with a fake implementation for testing.

#### [Back to Table of Contents](#table-of-contents)

### Ep 50 - [Entity Framework Core Migrations](https://www.youtube.com/watch?v=G14lmWS-h4k&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=50)

**What is a migration in entity framework core**

Migration is an entity framework core feature that keeps the database schema and our application model classes (also called entity class) in sync

To work with migrations, we can either use the Package Manager Console (PMC) or the .NET core command-line interface (CLI).

**Common entity framework core migration commands**

We will be using the following 3 common commands to work with migrations in entity framework core. 

**Command** | **Purpose**
:---: | :---:
get-help about_entityframeworkcore | Provides entity framework core help
Add-Migration | Adds a new migration
Update-Database | Updates the database to a specified migration

**Creating a Migration in Entity Framework Core**

The following command creates the initial migration.
> `Add-Migration {name}`

When the above command completes, you will see a file in the "Migrations" folder that contains the name `{name}.cs`. 
This file has the code required to create the respective database tables.

**Update-Database in Entity Framework Core**

We need to execute the migration code to create the tables. If the database does not exist already, it creates the database and then the database tables. 
For updating the database, we use Update-Database command. To the Update-Database command we may pass the migration name we want to execute. 
If no migration is specified, the command by default executes the last migration.

We can confirm this in SQL Server Object Explorer window in Visual Studio. 

#### [Back to Table of Contents](#table-of-contents)

### Ep 51 - [Entity Framework Core Seed Data](https://www.youtube.com/watch?v=qDUS8ocavBU&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=51)

If you are using Entity Framework Core 2.1 or later there is a new method of seeding database data. In your application DbContext class, 
override `OnModelCreating()` method. In this example, `HasData()` method configures Employee entity to have the specified seed data. 

```C#
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                Id = 1,
                Name = "Mark",
                Department = Dept.IT,
                Email = "mark@gmail.com"
            }
        );
    }
}
```

**Using Migrations to seed data**

The following command adds a new migration.

> `Add-Migration SeedMigration`

The above command generates the following code 

using Microsoft.EntityFrameworkCore.Migrations;

```C#
namespace DotNetCoreTutorialJourney.Migrations
{
    public partial class SeedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Email", "Name" },
                values: new object[] { 1, 3, "mark@gmail.com", "Mark" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
```

Finally, execute `Update-Database` command to apply the above migration to the database. 

**Altering Existing Database Seed data**

You can alter the existing seed data or add new seed data by adding another new migration.  

Step 1 : Modify the code in `OnModelCreating()` method. 

```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Employee>().HasData(
        new Employee
        {
            Id = 1,
            Name = "Mary",
            Department = Dept.IT,
            Email = "mary@gmail.com"
        },
        new Employee
        {
            Id = 2,
            Name = "John",
            Department = Dept.HR,
            Email = "john@gmail.com"
        }
    );
}
```

Step 2 : Add a new migration 

> `Add-Migration AlterSeedMigration`

Step 3 : Update the database with the latest migration 

> `Update-Database`

**Keeping DbContext Class Clean**

To keep the DbContext class clean, you may move the seeding code from the `DbContext` class into an extension method on the ModelBuilder class. 

```C#
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreTutorialJourney.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Mary",
                    Department = Dept.IT,
                    Email = "mary@pragimtech.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "John",
                    Department = Dept.HR,
                    Email = "john@pragimtech.com"
                }
            );
        }
    }
}
```

In `OnModelCreating()` method of the `DbContext` class, you can then call `Seed()` method as shown below. 

```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Seed();
}
```

#### [Back to Table of Contents](#table-of-contents)

### Ep 52 - [Keeping Domain Models and Database Schema in Sync](https://www.youtube.com/watch?v=MhvOKHUWgiY&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=52)

As we develop our application and add new features, our application domain classes change. When the domain classes change, 
the corresponding changes have to be made to the underlying database schema. 
Otherwise the database schema goes out of sync and the application does not work as expected.  

However, it is important not to manually make these changes to the database schema. 
We use migrations to keep the database schema in sync as the application domain classes change.

**For Example**

At the moment our domain Employee class does not have a property to store the Photo Path of the employee. 

To be able to store the Photo Path of the employee, we want to add `PhotoPath` property to the `Employee` class. 

```C#
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public Dept? Department { get; set; }
    public string PhotoPath { get; set; }
}
```

To keep the Employees database table in sync with the Employee Model class, add a new migration and execute it to update the database.  

```
Add-Migration AddPhotoPathToEmployees
Update-Database
```

**Use of __EFMigrationsHistory table**

`__EFMigrationsHistory` table is created in the database, when the first migration is executed. 
This table is used to keep track of the migrations that are applied to the database. 
There will be an entry for every migration that is applied. 

**Removing a migration**

To remove a migration execute `Remove-Migration` command 

It only removes **one migration** at a time and that too **only the latest migration** that is **not yet applied** to the database. 
If all the migrations are already applied, executing Remove-Migration command throws the following exception. 

> The migration 'Latest_Migration_Name' has already been applied to the database. Revert it and try again. 

**Removing a migration that is already applied to the database**

Let us say we have the following 3 migrations already applied to the database. 
1. Migration_One
2. Migration_Two
3. Migration_Three

We want to remove both migration Migration_Two and Migration_Three. Since all these 3 migrations are already applied to the database, 
executing Remove-Migration command will throw an error. 

If we relate this to our example, we want to undo the changes done by Migration_Two and Migration_Three and bring the database state to the state it was in, 
when Migration_One was executed. To achieve this we execute Update-Database command with Migration_One name as shown below. 

```
Update-Database Migration_One
```

Executing the above command will undo the changes made by Migration_Two and Migration_Three. 
EF core will also remove the entries for these 2 migrations from __EFMigrationsHistory table. 

However, the migration code files will still be there in the Migrations folder. To remove the code files use Remove-Migration command. 
Since we want to remove both Migration_Three and Migration_Two code files, we want to execute `Remove-Migration` command **twice**. 

#### [Back to Table of Contents](#table-of-contents)

### Ep 53 - [File Upload in .Net Core MVC](https://www.youtube.com/watch?v=aoxEJii70_I&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=53)

First, because our `Employee` class has photoPath as a string, and we take **file** from the form, we need a new model.
Let us create `EmployeeCreateViewModel` Class 

```C#
public class EmployeeCreateViewModel
{
    public string Name { get; set; }
    public string Email { get; set; }
    public Dept? Department { get; set; }
    public IFormFile Photo { get; set; }
}
```

- `IFormFile` is in `Microsoft.AspNetCore.Http` namespace.
- The file uploaded to the server can be accessed through Model Binding using the `IFormFile` interface.
- The interface `IFormFile` has the following properties and methods

```C#
public interface IFormFile
{
    string ContentType { get; }
    string ContentDisposition { get; }
    IHeaderDictionary Headers { get; }
    long Length { get; }
    string Name { get; }
    string FileName { get; }
    Stream OpenReadStream();
    void CopyTo(Stream target);
    Task CopyToAsync(Stream target, CancellationToken cancellationToken = null);
}
```

**Create View Code**

The code specific to uploading the file is commented 

```HTML
@model EmployeeCreateViewModel

@{
    ViewBag.Title = "Create Employee";
}

@*To support file upload set the form element enctype="multipart/form-data" *@

<form enctype="multipart/form-data" asp-controller="Home" asp-action="Create" method="post" class="mt-3" autocomplete="off">
    <div class="form-group row">
        <label asp-for="Name" class="col-sm-2 col-form-label"></label>
        <div class="col-sm-10">
            <input asp-for="Name" class="form-control" placeholder="Name">
            <span asp-validation-for="Name" class="text-danger"></span>
        </div>
    </div>
    <div class="form-group row">
        <label asp-for="Email" class="col-sm-2 col-form-label"></label>
        <div class="col-sm-10">
            <input asp-for="Email" class="form-control" placeholder="Email">
            <span asp-validation-for="Email" class="text-danger"></span>
        </div>
    </div>
    <div class="form-group row">
        <label asp-for="Department" class="col-sm-2 col-form-label"></label>
        <div class="col-sm-10">
            <select asp-for="Department" class="custom-select mr-sm-2"
                    asp-items="Html.GetEnumSelectList<Dept>()">
                <option value="">Please Select</option>
            </select>
            <span asp-validation-for="Department" class="text-danger"></span>
        </div>
    </div>

    @*  asp-for tag helper is set to "Photo" property. "Photo" property type is IFormFile
        so at runtime asp.net core generates file upload control (input type=file)  *@

    <div class="form-group row">
        <label asp-for="Photo" class="col-sm-2 col-form-label"></label>
        <div class="col-sm-10">
            <div class="custom-file">
                <input asp-for="Photo" class="form-control custom-file-input">
                <label class="custom-file-label">Choose File...</label>
            </div>
        </div>
    </div>

    <div asp-validation-summary="All" class="text-danger"></div>

    <div class="form-group row">
        <div class="col-sm-10">
            <button type="submit" class="btn btn-primary">Create</button>
        </div>
    </div>

    @*This script is required to display the selected file in the file upload element*@

    @section Scripts {
        <script>
            $(document).ready(function () {
                $('.custom-file-input').on("change", function () {
                    var fileName = $(this).val().split("\\").pop();
                    $(this).next('.custom-file-label').html(fileName);
                });
            });
        </script>
    }
</form>
```

**Create Action Method**


```C#
private readonly IEmployeeRepository _employeeRepository;
private readonly IHostingEnvironment _hostingEnvironment;

public HomeController(IEmployeeRepository employeeRepository, 
                        IHostingEnvironment hostingEnvironment)
{
    _employeeRepository = employeeRepository;
    _hostingEnvironment = hostingEnvironment;
}

[HttpPost]
public IActionResult Create(EmployeeCreateViewModel model)
{
    if (ModelState.IsValid)
    {
        string uniqueFileName = null;
        if (model.Photo != null)
        {
            // The image must be uploaded to the images folder in wwwroot
            // To get the path of the wwwroot folder we are using the inject
            // HostingEnvironment service provided by ASP.NET Core
            string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
            // To make sure the file name is unique we are appending a new
            // GUID value and and an underscore to the file name
            uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(model.Photo.FileName);
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);
            model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
        }

        Employee employee = new Employee {
            Name = model.Name,
            Email = model.Email,
            Department = model.Department,
            PhotoPath = uniqueFileName
        };

        _employeeRepository.AddEmployee(employee);
        return RedirectToAction("details", new { id = employee.Id });
    }
    return View();
}
```

The rest of the code on this page is not required to upload a file. 
It contains code to display a specific employee details using the details view and the list of employees using the index view. 

**Details View Code**

```HTML
@model Employee

@{
    ViewBag.Title = "Employee Details";
    var photoPath = "~/images/" + (Model.PhotoPath ?? "avatar_placeholder.png");
}

<div class="row justify-content-center m-3">
    <div class="col-sm-8">
        <div class="card">
            <div class="card-header">
                <h1>@Model.Name</h1>
            </div>

            <div class="card-body text-center">
                <img class="card-img-top" src="@photoPath" asp-append-version="true" />

                <h4>Employee ID : @Model.Id</h4>
                <h4>Email : @Model.Email</h4>
                <h4>Department : @Model.Department</h4>
            </div>
            <div class="card-footer text-center">
                <a asp-controller="home" asp-action="index" class="btn btn-primary m-1">Back</a>
                <a href="#" class="btn btn-primary m-1">Edit</a>
                <a href="#" class="btn btn-danger m-1">Delete</a>
            </div>
        </div>
    </div>
</div>
```

**Index View Code**

```HTML
@model IEnumerable<Employee>

@{
    ViewBag.Title = "Employee List";
}

<div class="card-deck">
    @foreach (var employee in Model)
    {
        var photoPath = "~/images/" + (employee.PhotoPath ?? "avatar_placeholder.png");

        <div class="card m-3 card-3-columns">
            <div class="card-header">
                <h3>@employee.Name</h3>
            </div>
            <img class="card-img-top imageThumbnail" src="@photoPath" asp-append-version="true" />
            <div class="card-footer text-center">
                <a asp-controller="home" asp-action="details" asp-route-id="@employee.Id" class="btn btn-primary m-1">View</a>
                <a href="#" class="btn btn-primary m-1">Edit</a>
                <a href="#" class="btn btn-danger m-1">Delete</a>
            </div>
        </div>
    }
</div>
```

**main.css**

```CSS
.imageThumbnail {
    width: auto;
}

.card-3-columns {
    min-width: 18rem;
    max-width: 30.5%;
}
```

If we want to add **Multiple files**, we can use `multiple` attribute

```HTML
<input asp-for="Photos" multiple class="form-control custom-file-input">
```

#### [Back to Table of Contents](#table-of-contents)

### Ep 55 - [Edit View in .Net Core MVC](https://www.youtube.com/watch?v=lhiIvx7jMaY&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=55)

When the Edit button is clicked we want to redirect to the Edit view. In index.chtml modify the Edit anchor element as shown below. 

```HTML
<a asp-controller="home" asp-action="edit" asp-route-id="@employee.Id"
    class="btn btn-primary m-1">Edit</a>
```

**Edit View Model**

In the ViewModels folder include the following `EmployeeEditViewModel` class 

```C#
namespace DotNetCoreTutorialJourney.ViewModels
{
    public class EmployeeEditViewModel : EmployeeCreateViewModel
    {
        public string ExistingPhotoPath { get; set; }
    }
}
```

- This view model carries the data the Edit view needs
- We used the inheritance approach in order not to duplicate code

**Edit Action Method in the Home Controller**

```C#
[HttpGet]
public IActionResult Edit(int id)
{
    Employee employee = _employeeRepository.GetEmployee(id);
    if (employee != null)
    {
        EmployeeEditViewModel employeeEditViewModel = new EmployeeEditViewModel
        {
            Id = employee.Id,
            Name = employee.Name,
            Email = employee.Email,
            Department = employee.Department,
            ExistingPhotoPath = employee.PhotoPath
        };
        return View(employeeEditViewModel);
    }
    return RedirectToAction("index");
}
```

**Edit View**

```HTML
@model EmployeeEditViewModel

@{
    ViewBag.Title = "Update Employee";
    // Get the full path of the existing employee photo for display
    var photoPath = "~/images/" + (Model.ExistingPhotoPath ?? "avatar_placeholder.png");
}

<form enctype="multipart/form-data" asp-controller="Home" asp-action="edit" method="post" class="mt-3" autocomplete="off">

    @*Use hidden input elements to store employee id and ExistingPhotoPath 
	which we need when we submit the form and update data in the database*@
    <input hidden asp-for="Id" />
    <input hidden asp-for="ExistingPhotoPath" />

    @*Bind to the properties of the EmployeeEditViewModel. The asp-for tag helper 
	takes care of displaying the existing data in the respective input elements*@
    <div class="form-group row">
        <label asp-for="Name" class="col-sm-2 col-form-label"></label>
        <div class="col-sm-10">
            <input asp-for="Name" class="form-control" placeholder="Name">
            <span asp-validation-for="Name" class="text-danger"></span>
        </div>
    </div>
    <div class="form-group row">
        <label asp-for="Email" class="col-sm-2 col-form-label"></label>
        <div class="col-sm-10">
            <input asp-for="Email" class="form-control" placeholder="Email">
            <span asp-validation-for="Email" class="text-danger"></span>
        </div>
    </div>
    <div class="form-group row">
        <label asp-for="Department" class="col-sm-2 col-form-label"></label>
        <div class="col-sm-10">
            <select asp-for="Department" class="custom-select mr-sm-2"
                    asp-items="Html.GetEnumSelectList<Dept>()">
                <option value="">Please Select</option>
            </select>
            <span asp-validation-for="Department" class="text-danger"></span>
        </div>
    </div>
    <div class="form-group row">
        <label asp-for="Photo" class="col-sm-2 col-form-label"></label>
        <div class="col-sm-10">
            <div class="custom-file">
                <input asp-for="Photo" class="form-control custom-file-input">
                <label class="custom-file-label">Click to Change Photo...</label>
            </div>
        </div>
    </div>

    @*Display the existing employee photo*@
    <div class="form-group row offset-4">
        <img src="@photoPath" asp-append-version="true" style="width:auto; height:200px" />
    </div>

    <div asp-validation-summary="All" class="text-danger"></div>

    <div class="form-group row">
        <div class="col-sm-10">
            <button type="submit" class="btn btn-primary">Update</button>
            <a asp-action="index" asp-controller="home" class="btn btn-primary">Cancel</a>
        </div>
    </div>

    @section Scripts {
        <script>
            $(document).ready(function () {
                $('.custom-file-input').on("change", function () {
                    var fileName = $(this).val().split("\\").pop();
                    $(this).next('.custom-file-label').html(fileName);
                });
            });
        </script>
    }
</form>
```

**HttpPost Edit Action**

The following is the Edit action that handles the posted Edit view.

```C#
// Through model binding, the action method parameter
// EmployeeEditViewModel receives the posted edit form data
[HttpPost]
public IActionResult Edit(EmployeeEditViewModel model)
{
    // Check if the provided data is valid, if not rerender the edit view
    // so the user can correct and resubmit the edit form
    if (ModelState.IsValid)
    {
        // Retrieve the employee being edited from the database
        Employee employee = _employeeRepository.GetEmployee(model.Id);
        // Update the employee object with the data in the model object
        employee.Name = model.Name;
        employee.Email = model.Email;
        employee.Department = model.Department;
        // If the user wants to change the photo, a new photo will be
        // uploaded and the Photo property on the model object receives
        // the uploaded photo. If the Photo property is null, user did
        // not upload a new photo and keeps his existing photo
        if (model.Photo != null)
        {
            // If a new photo is uploaded, the existing photo must be
            // deleted. So check if there is an existing photo and delete
            if (model.ExistingPhotoPath != null)
            {
                string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "images", model.ExistingPhotoPath);
                System.IO.File.Delete(filePath);
            }
            // Save the new photo in wwwroot/images folder and update
            // PhotoPath property of the employee object which will be
            // eventually saved in the database
            employee.PhotoPath = ProcessUploadedFile(model);
        }
        // Call update method on the repository service passing it the
        // employee object to update the data in the database table
        _employeeRepository.UpdateEmployee(employee);
        return RedirectToAction("index");
    }
    return View();
}
```

The following is the private `ProcessUploadedFile()` method which saves the photo in wwwroot/images folder and returns the unique file name. 
This file name is then assigned as the value for the PhotoPath on the employee object which will eventually be saved in the database. 

```C#
private string ProcessUploadedFile(EmployeeCreateViewModel model)
{
    string uniqueFileName = null;
    if (model.Photo != null)
    {
        string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
        uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(model.Photo.FileName);
        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
        using (var fileStream = new FileStream(filePath, FileMode.Create))
        {
            model.Photo.CopyTo(fileStream);
        }
    }
    return uniqueFileName;
}
```

#### [Back to Table of Contents](#table-of-contents)

### Ep 57 - [Handling 404 Not Found in .Net Core MVC](https://www.youtube.com/watch?v=QiF3eJ4Zb0o&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=57)

There are **2 types** of 404 errors. 

**Type 1** : Resource with the specified ID does not exit. This type of 404 errors occur when you cannot find the employee, product, customer etc with the provided ID. 

```C#
public ViewResult Details(int id)
{
    Employee employee = _employeeRepository.GetEmployee(id);
    if (employee == null)
    {
        Response.StatusCode = 404;
        return View("EmployeeNotFound", id);
    }
    return View(employee);
}
```

```HTML
@model int

@{
    ViewBag.Title = "404 Error";
}

<div class="alert alert-danger mt-1 mb-1">
    <h4>404 Not Found Error :</h4>
    <hr />
    <h5>
        Employee with ID = @Model cannot be found
    </h5>
</div>

<a asp-controller="home" asp-action="index" class="btn btn-outline-success" 
   style="width:auto">Click here to see the list of all employees</a>
```

In this case, we know the user is trying to go to the employee details page, but the provided ID value is invalid. 
So we are returning a custom error page with the message, the ID cannot be found and a link 
that he could click to see the list of all employees. 

<p align="center">
  <img src="https://i.ibb.co/q0tfWvJ/handling-404-not-found-in-asp-net-core-mvc.png">
</p>

**Type 2** : The URL does not match any route 

Consider the following route. This also results in a 404 error 

> http://localhost/foo/bar

**Default 404 error page in ASP.NET Core**

At the moment we do not have anything configured in this http request processing pipeline to handle 404 errors. 
So if we navigate to `http://localhost/foo/bar`, we see the following default 404 error page. 
This is because the URL `/foo/bar` does not match any routes in our application. 

<p align="center">
  <img src="https://i.ibb.co/XCWL92Z/asp-net-core-404-error-handling.png">
</p>

**Handling non-success http status codes**

To handle non-success http status codes such as 404 for example, 
we could use the following 3 built-in asp.net core middleware components. 

- UseStatusCodePages
- UseStatusCodePagesWithRedirects
- UseStatusCodePagesWithReExecute 

**UseStatusCodePages Middleware**

This is the least useful of the 3 status code middleware components. For this reason, we rarely use it in a real world production application. 
To use it in an application and see what it can do, plug it into the http processing pipeline as shown below. 

```C#
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    } else
    {
        app.UseStatusCodePages();
    }

    app.UseStaticFiles();
    app.UseMvcWithDefaultRoute();
}
```

With UseStatusCodePages Middleware configured, if we navigate to `http://localhost/foo/bar`, 
it returns the following simple text response. 

<p align="center">
  <img src="https://i.ibb.co/54PYvCs/asp-net-core-usestatuscodepages.png">
</p>

**UseStatusCodePagesWithRedirects Middleware** 

In a production quality application we want to intercept these non-success http status codes and return a custom error view. 
To achieve this, we can either use `UseStatusCodePagesWithRedirects` middleware or `UseStatusCodePagesWithReExecute` middleware. 

```C#
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    } else
    {
        app.UseStatusCodePagesWithRedirects("/Error/{0}");
    }

    app.UseStaticFiles();
    app.UseMvcWithDefaultRoute();
}
```

If there is a 404 error, the user is redirected to /Error/404. The placeholder {0}, in "/Error/{0}" 
will automatically receive the http status code. 

**ErrorController.cs**

```C#
namespace DotNetCoreTutorialJourney.Controllers
{
    public class ErrorController : Controller
    {
        // If there is 404 status code, the route path will become Error/404
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry, the resource you requested could not be found";
                    break;
            }

            return View("NotFound");
        }
    }
}
```

**NotFound View**

```HTML
@{
    ViewBag.Title = "Not Found";
}

<h1>@ViewBag.ErrorMessage</h1>

<a asp-action="index" asp-controller="home">
    Click here to navigate to the home page
</a>
```

At this point, if we navigate to `http://localhost/foo/bar` we see the following custom 404 error view NotFound.cshtml as expected. 

<p align="center">
  <img src="https://i.ibb.co/NVwrJ8x/asp-net-core-usestatuscodepageswithredirects.png">
</p>

To use `UseStatusCodePagesWithReExecute` middleware instead of `UseStatusCodePagesWithRedirects` middleware 

REPLACE `app.UseStatusCodePagesWithRedirects("/Error/{0}");` WITH `app.UseStatusCodePagesWithReExecute("/Error/{0}");`

#### [Back to Table of Contents](#table-of-contents)

### Ep 59 - [UseStatusCodePagesWithRedirects vs UseStatusCodePagesWithReExecute](https://www.youtube.com/watch?v=9CwgiSxrkeQ&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=59)

Irrespective of the middleware component you use, from an end user standpoint, 
there is no difference in the behaviour. We see the specified custom error view in both the cases. 

**UseStatusCodePagesWithRedirects**

`app.UseStatusCodePagesWithRedirects("/Error/{0}");` When a request is issued to `http://localhost/foo/bar`. 
Since this URL does not match with any route in our application status code 404 is raised,
`UseStatusCodePagesWithRedirects` middleware component **intercepts** the 404 status code and as the name implies, 
issues a redirect to the provided error path (in our case "/Error/404")

**Request processing with UseStatusCodePagesWithRedirects**

- When a request is issued to http://localhost/foo/bar
- **404 status code** is raised 
- `StatusCodePagesWithRedirects` middleware **intercepts** this and changes it to **302**, pointing it to the error path (**/Error/404**)
- **302 status code** means the URL of the requested resource has been changed temporarily, in our case it changed to **/Error/404**
- So another `GET` request is issued to serve the redirected request
- Because a redirect is issued, notice the URL in the address bar also changes **from /foo/bar to /Error/404**
- The request flows through the pipeline and handled by the MVC middleware which ultimately returns NotFound view HTML 
with **status code 200**(which means the request completed successfully)
- As far as the browser is concerned in this entire request flow there was **no 404 error**.
- If you closely observe this request and response flow, we are returning a success status code (**200**) 
when actually an error occurred which **isn't semantically correct**.

<p align="center">
  <img src="https://i.ibb.co/zNCs6Y8/Use-Status-Code-Pages-With-Redirects-vs-Use-Status-Code-Pages-With-Re-Execute.png">
</p>

**Request processing with UseStatusCodePagesWithReExecute**
- `app.UseStatusCodePagesWithReExecute("/Error/{0}")`
- When a request is issued to `http://localhost/foo/bar`
- `404 status code` is raised 
- `UseStatusCodePagesWithReExecute` middleware **intercepts** the **404 status code** and **re-executes** the pipeline pointing it to the URL (**/Error/404**)
- The request flows through the pipeline and handled by the MVC middleware which returns `NotFound` view HTML along with status code **200**
- As the response flows out to the client, it passes through `UseStatusCodePagesWithReExecute` middleware which uses the HTML response 
but **replaces the 200 status code with the original 404 status code**.
- This is a clever piece of middleware. As the name implies it **re-executes the pipeline keeping the correct (404) status code**. 
It just returns the custom view (NotFound) HTML
- As it is just re-executing the pipeline and **not issuing a redirect request**, we also preserve the **original URL** (`/foo/bar`) in the address bar. 
It **does not change** from `/foo/bar` to `/Error/404`.

<p align="center">
  <img src="https://i.ibb.co/JFGyL7c/usestatuscodepageswithreexecute-vs-usestatuscodepageswithredirects.png">
</p>

If you are using `UseStatusCodePagesWithReExecute` middleware, 
it's also possible to get the original path in the `ErrorController` using `IStatusCodeReExecuteFeature` interface as shown below. 

```C#
public class ErrorController : Controller
{
    [Route("Error/{statusCode}")]
    public IActionResult HttpStatusCodeHandler(int statusCode)
    {
        var statusCodeResult =
                HttpContext.Features.Get<IStatusCodeReExecuteFeature>();

        switch (statusCode)
        {
            case 404:
                ViewBag.ErrorMessage =
                        "Sorry, the resource you requested could not be found";
                ViewBag.Path = statusCodeResult.OriginalPath;
                ViewBag.QS = statusCodeResult.OriginalQueryString;
                break;
        }

        return View("NotFound");
    }
}
```

You can then display it in the custom error view as shown below 

```HTML
@{
    ViewBag.Title = "Not Found";
}

<h1>@ViewBag.ErrorMessage</h1>

<h1>@ViewBag.Path</h1>

<h1>@ViewBag.QS</h1>

<a asp-action="index" asp-controller="home">
    Click here to navigate to the home page
</a>
```

<p align="center">
  <img src="https://i.ibb.co/R6jx86d/Use-Status-Code-Pages-With-Re-Execute-Path-And-Query.png">
</p>

#### [Back to Table of Contents](#table-of-contents)

### Ep 60 - [Global Exception Handling in .Net Core MVC](https://www.youtube.com/watch?v=jeBttUIqpuc&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=60)

**Throwing an Exception in ASP.NET Core**

Consider the following Details action method in `HomeController`. We are deliberately throwing an exception using the throw keyword. 

```C#
public ViewResult Details(int? id)
{
    throw new Exception("Error in Details View");

    // Rest of the code
}
```

**Step 1** : For a non-development environment, add the Exception Handling Middleware to the request processing pipeline using `UseExceptionHandler()` method. 
We do this in the `Configure()` method of the `Startup` class. Exception Handling Middleware looks for `ErrorController`. 

```C#
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    else
    {
        app.UseExceptionHandler("/Error");
    }

    // Rest of the code
}
```

**Step 2** : Implement the `ErrorController` that retrieves the exception details and returns the custom Error view. 
In a production application, we **do not display** the exception details on the error view. We instead log them to a database table, file, event viewer etc, 
so a developer can review them and provide a code fix if required.

```C#
public class ErrorController : Controller
{
    [AllowAnonymous]
    [Route("Error")]
    public IActionResult Error()
    {
        // Retrieve the exception Details
        var exceptionHandlerPathFeature =
                HttpContext.Features.Get<IExceptionHandlerPathFeature>();

        ViewBag.ExceptionPath = exceptionHandlerPathFeature.Path;
        ViewBag.ExceptionMessage = exceptionHandlerPathFeature.Error.Message;
        ViewBag.StackTrace = exceptionHandlerPathFeature.Error.StackTrace;

        return View("Error");
    }
}
```

**Step 3** : Implement Error View 

```HTML
<h3>An occured while processing your request. The support team is notified and we are working on the fix</h3>
<hr />
<h3>Exception Details:</h3>
<div class="alert alert-danger">
    <h5>Exception Path</h5>
    <hr />
    <p>@ViewBag.ExceptionPath</p>
</div>

<div class="alert alert-danger">
    <h5>Exception Message</h5>
    <hr />
    <p>@ViewBag.ExceptionMessage</p>
</div>

<div class="alert alert-danger">
    <h5>Exception Stack Trace</h5>
    <hr />
    <p>@ViewBag.StackTrace</p>
</div>
```

#### [Back to Table of Contents](#table-of-contents)

### Ep 61 - [Logging in .Net Core MVC](https://www.youtube.com/watch?v=WyAJe6lA-bY&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=61)

**Logging providers in ASP.NET Core**

A logging provider is the component that stores or displays logs. For example, the Console log provider displays logs on the console. 
Similarly, the Debug log provider displays logs on the Debug window in Visual Studio.

**ASP.NET Core built-in logging providers**
- Console
- Debug
- EventSource
- EventLog
- TraceSource
- AzureAppServicesFile
- AzureAppServicesBlob
- ApplicationInsights

**Third party logging providers for ASP.NET Core**
- NLog
- elmah
- Serilog
- Sentry
- Gelf
- JSNLog
- KissLog.net
- Loggr
- Stackdriver

**Default logging providers in ASP.NET Core** 

`Main()` method in the `Program` class in `Program.cs` file is the entry point for an asp.net core application. 
This method calls `CreateDefaultBuilder()` method performs several tasks like  
- Setting up the web server 
- Loading the host and application configuration from various configuration sources and 
- Configuring logging

Since ASP.NET Core is open source we can see the complete source on their official github page. 
The following is the code snippet from `CreateDefaultBuilder()` method.  

```C#
.ConfigureLogging((hostingContext, logging) =>
{
    logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
    logging.AddConsole();
    logging.AddDebug();
    logging.AddEventSourceLogger();
})
```

As part of configuring logging, `CreateDefaultBuilder()` method adds the following 3 logging providers by default. 
This is the reason when we run the asp.net core project we see the log displayed both on the `console` and on the `debug window` in Visual Studio. 
- Console
- Debug
- EventSource

`CreateDefaultBuilder()` method looks for `Logging` section in the application configuration file `appsettings.json`.

**Logging section in appsettings.json**

```JSON
"Logging": {
  "LogLevel": {
    "Default": "Warning",
    "Microsoft":  "Warning"
  }
}
```

LogLevel is used to control how much log data is logged or displayed.

To turn off iisexpress.exe logs under debug tab in visual studio, in Visual Studio click on Tools - Options. 
On the Options window, under Debugging - Output Window turn off the messages you do not need. 

<p align="center">
  <img src="https://i.ibb.co/7zrnpfs/visual-studio-debug-tab-turn-off-isexpress-exe-messages.png">
</p>

#### [Back to Table of Contents](#table-of-contents)

### Ep 62 - [Logging Exceptions in .Net Core MVC](https://www.youtube.com/watch?v=LhpO2sgxqfw&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=62)

If there are exceptions, while users are using our application we need to log the exceptions somewhere. 
A developer can then review the exception log and provide a fix if required. 
Logging exceptions is required to know what exceptions are occurring on production server as the application is being used. 

```C#
public class ErrorController : Controller
{
    private readonly ILogger<ErrorController> _logger;

    public ErrorController(ILogger<ErrorController> logger)
    {
        _logger = logger;
    }

    // If there is 404 status code, the route path will become Error/404
    [Route("Error/{statusCode}")]
    public IActionResult HttpStatusCodeHandler(int statusCode)
    {
        var statusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
        switch (statusCode)
        {
            case 404:
                ViewBag.ErrorMessage = "Sorry, the resource you requested could not be found";

                // LogWarning() method logs the message under
                // Warning category in the log
                _logger.LogWarning($"404 error occured. Path = " +
                    $"{statusCodeResult.OriginalPath} and QueryString = " +
                    $"{statusCodeResult.OriginalQueryString}");
                break;
        }

        return View("NotFound");
    }

    [AllowAnonymous]
    [Route("Error")]
    public IActionResult Error()
    {
        // Retrieve the exception Details
        var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

        // LogError() method logs the exception under Error category in the log
        _logger.LogError($"The path {exceptionHandlerPathFeature.Path} " + 
            $"threw an exception {exceptionHandlerPathFeature.Error}");

        return View("Error");
    }
}
```

**Logging Exceptions in ASP.NET Core**

Two simple steps to log your own custom messages, warnings or exceptions 

Inject an instance of ILogger where you need the logging functionality 

The type of the class or controller into which ILogger is injected can be specified as the argument for the generic parameter of ILogger. 
We do this because, the fully qualified name of the class or the controller is then included in the log output as the **log category**. 
**Log category** is used to group the log messages. 
> EmployeeManagement.Controllers.ErrorController:

Since we have specified the type of ErrorController as the generic argument for ILogger, 
the fully qualified name of ErrorController is also included in the log output below. 

```C#
private readonly ILogger<ErrorController> logger;

public ErrorController(ILogger<ErrorController> logger)
{
    this.logger = logger;
}
```

`LogError()` method logs the exception under `Error` category.  
> EmployeeManagement.Controllers.ErrorController:Error:

```C#
logger.LogError($"The path {exceptionHandlerPathFeature.Path} " +
    $"threw an exception {exceptionHandlerPathFeature.Error}");
```

Here is the log generated by `LogError()` method  

```
EmployeeManagement.Controllers.ErrorController:Error: The path /home/details/1 threw an exception System.Exception: Error in Details Controller
   at EmployeeManagement.Controllers.HomeController.Details(Nullable`1 id) in C:\Projects\EmployeeManagement\EmployeeManagement\Controllers\HomeController.cs:line 36
   at lambda_method(Closure , Object , Object[] )
   at Microsoft.Extensions.Internal.ObjectMethodExecutor.Execute(Object target, Object[] parameters)
   at Microsoft.AspNetCore.Mvc.Internal.ActionMethodExecutor.SyncActionResultExecutor.Execute(IActionResultTypeMapper mapper, ObjectMethodExecutor executor, Object controller, Object[] arguments)
   at Microsoft.AspNetCore.Mvc.Internal.ControllerActionInvoker.InvokeActionMethodAsync()
   at Microsoft.AspNetCore.Mvc.Internal.ControllerActionInvoker.InvokeNextActionFilterAsync()
   at Microsoft.AspNetCore.Mvc.Internal.ControllerActionInvoker.Rethrow(ActionExecutedContext context)
   at Microsoft.AspNetCore.Mvc.Internal.ControllerActionInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Internal.ControllerActionInvoker.InvokeInnerFilterAsync()
   at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.InvokeNextResourceFilter()
   at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.Rethrow(ResourceExecutedContext context)
   at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.InvokeFilterPipelineAsync()
   at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.InvokeAsync()
   at Microsoft.AspNetCore.Builder.RouterMiddleware.Invoke(HttpContext httpContext)
   at Microsoft.AspNetCore.StaticFiles.StaticFileMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.Diagnostics.StatusCodePagesMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.Diagnostics.ExceptionHandlerMiddleware.Invoke(HttpContext context)
```

`LogWarning()` method logs the message under `Warning` category.  
> EmployeeManagement.Controllers.ErrorController:Warning:

```
EmployeeManagement.Controllers.ErrorController:Warning: 404 error occured. Path = /foo/bar and QueryString = ?email=abc@gmail.com&abc=xyz
```

In a real world application we usually log the exceptions and warnings to a database table, event viewer or a file.

#### [Back to Table of Contents](#table-of-contents)

### Ep 63 - [Logging to File in .Net Core MVC Using Nlog](https://www.youtube.com/watch?v=o5u4fE0t79k&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=63)

**Step 1** : Install NLog.Web.AspNetCore nuget package 

**Step 2** : Create nlog.config file 

Create `nlog.config` file in the root of your project using text format.

```XML
<?xml version="1.0" encoding="utf-8" ?>
<nlog xmlns="http://www.nlog-project.org/schemas/NLog.xsd"
      xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">

  <!-- the targets to write to -->
  <targets>
    <!-- write logs to file  -->
    <target name="allfile" xsi:type="File"
            fileName="c:\Temp\nlog-all-${shortdate}.log"/>
  </targets>

  <!-- rules to map from logger name to target -->
  <rules>
    <!--All logs, including from Microsoft-->
    <logger name="*" minlevel="Trace" writeTo="allfile" />
  </rules>
</nlog>
```

To learn more about the nlog.config file please refer to the [github wiki page](https://github.com/NLog/NLog/wiki/Configuration-file)

**Step 3** : Enable copy to bin folder 

Right click on `nlog.config` file in the Solution Explorer and select `Properties`. In the `Properties` window set  
> Copy to Output Directory = Copy if newer

**Step 4** : Enable NLog as one of the Logging Provider 

In addition to using the default logging providers (i.e Console, Debug & EventSource), 
we also added NLog using the extension method `AddNLog()`. This method is in `NLog.Extensions.Logging` namespace.

```C#
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace DotNetCoreTutorialJourney
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        //CreateDefaultBuilder creates the 'WebHost' with certain pre-configure defaults.
        //UseStartup extension starts up the 'Startup' class by default.
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args).ConfigureLogging((hostingContext, logging) =>
            {
                logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                logging.AddConsole();
                logging.AddDebug();
                logging.AddEventSourceLogger();
                // Enable NLog as one of the Logging Provider
                logging.AddNLog();
            }).UseStartup<Startup>();
    }
}
```

If you want only NLog as the logging provider, clear all the logging providers and then add NLog. 

```C#
namespace DotNetCoreTutorialJourney
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        //CreateDefaultBuilder creates the 'WebHost' with certain pre-configure defaults.
        //UseStartup extension starts up the 'Startup' class by default.
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args).ConfigureLogging((hostingContext, logging) =>
            {
                //Remove all default logging provider
                logging.ClearProviders();

                logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                // Enable NLog as one of the Logging Provider
                logging.AddNLog();
            }).UseStartup<Startup>();
    }
}
```

#### [Back to Table of Contents](#table-of-contents)

### Ep 64 - [LogLevel Configuration in .Net Core MVC](https://www.youtube.com/watch?v=bTPnT13Efd4&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=64)

**LogLevel enum** is present in `Microsoft.Extensions.Logging` namespace 

```C#
namespace Microsoft.Extensions.Logging
{
    public enum LogLevel
    {
        Trace = 0,
        Debug = 1,
        Information = 2,
        Warning = 3,
        Error = 4,
        Critical = 5,
        None = 6
    }
}
```

LogLevel setting in `appsettings.json` file is used to control how much log data is logged or displayed.  

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Trace",
      "Microsoft": "Warning"
    }
  }
}
```

**ILogger Methods**

On the ILogger interface, we have log methods that include the log level in the method name. 
For example to log a TRACE message we use `LogTrace()` method. Similarly to log a WARNING message we use `LogWarning()` method. 
Notice, except for LogLevel = None, we have a corresponding method for every log level. 

```C#
LogTrace()
LogDebug()
LogInformation()
LogWarning()
LogError()
LogCritical()
```

**LogLevel Example**

```C#
public class HomeController : Controller
{
    public ViewResult Details(int? id)
    {
        logger.LogTrace("Trace Log");
        logger.LogDebug("Debug Log");
        logger.LogInformation("Information Log");
        logger.LogWarning("Warning Log");
        logger.LogError("Error Log");
        logger.LogCritical("Critical Log");

        // Rest of the code
    }
}
```
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Trace",
      "Microsoft": "Warning"
    }
  }
}
```

The following Log output is displayed in the **Debug Output window**. 
Since we have set `"Default": "Trace"`, we see everything from Trace level and higher. 
Since Trace is the lowest level we see all the logs. 

```
EmployeeManagement.Controllers.HomeController:Trace: Trace Log
EmployeeManagement.Controllers.HomeController:Debug: Debug Log
EmployeeManagement.Controllers.HomeController:Information: Information Log
EmployeeManagement.Controllers.HomeController:Warning: Warning Log
EmployeeManagement.Controllers.HomeController:Error: Error Log
EmployeeManagement.Controllers.HomeController:Critical: Critical Log
```

However if you want **WARNING** and higher then set `"Default": "Warning"` 

If you do not want anything logged set LogLevel to `None`. The integer value of LogLevel.None is 6, 
which is higher than all the other log levels. So nothing gets logged. 

**Log filtering in ASP.NET Core**

```
EmployeeManagement.Controllers.HomeController:Trace: My log message
```

`EmployeeManagement.Controllers.HomeController` is the **LOG CATEGORY**. `Trace` is the **LOG LEVEL**.

In simple terms, LOG CATEGORY is the fully qualified name of the class that logged the message. 
The log category is displayed as a string in the logged message so we can use it easily determine from which class the log came from. 
LOG CATEGORY is used to filter logs. 

With the following LogLevel configuration, we see everything from Trace level and higher from the log category **"EmployeeManagement.Controllers.HomeController"**. 
However, for the category **"EmployeeManagement.Models.SQLEmployeeRepository"** only Error level logs and higher are displayed. 

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "EmployeeManagement.Controllers.HomeController": "Trace",
      "EmployeeManagement.Models.SQLEmployeeRepository": "Error",
      "Microsoft": "Warning"
    }
  }
}
```

The above LogLevel configuration applies to **all logging providers**. A logging provider is the component that stores or displays logs. 
For example, **the Console logging provider** displays logs on the console. 
Similarly, **the Debug logging provider** displays logs on the Debug window in Visual Studio. 

**Log Filtering by Log Category and by Logging Provider**

It is also possible to filter logs **by Provider** and **by Category**. The following is an example. 
With the following configuration, for the Debug logging provider, Warning and higher level logs are logged and displayed for all the log categories. 
Where as for the rest of the logging providers, Trace and higher level logs are logged and displayed for all the log categories.  

```json
{
  "Logging": {
    "Debug": {
      "LogLevel": {
        "Default": "Warning",
        "EmployeeManagement.Controllers.HomeController": "Warning",
        "EmployeeManagement.Models.SQLEmployeeRepository": "Warning",
        "Microsoft": "Warning"
      }
    },
    "LogLevel": {
      "Default": "Trace",
      "EmployeeManagement.Controllers.HomeController": "Trace",
      "EmployeeManagement.Models.SQLEmployeeRepository": "Trace",
      "Microsoft": "Trace"
    }
  }
}
```

**LogLevel configuration in environment specific appsettings.json file**

Please remember the configuration in environment specific appsettings.json file (for example appsettings.development.json) 
overrides the settings in appsettings.json file. 
Make sure the log level configuration in the environment specific appsettings.json file is what you really want, to avoid surprises.

#### [Back to Table of Contents](#table-of-contents)

### Ep 65 - [Identity in .Net Core MVC](https://www.youtube.com/watch?v=egITMrwMOPU&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=65)

**ASP.NET Core Identity**

ASP.NET Core Identity is a membership system. It allows us to create, read, update and delete user accounts. 
Supports account confirmation, authentication, authorisation, password recovery, two-factor authentication with SMS. 
It also supports external login providers like Microsoft, Facebook, Google etc.

**Adding ASP.NET Core Identity Support in ASP.NET Core Application**

The following are the steps to add and configure ASP.NET Core Identity 

**Step 1** : Inherit from `IdentityDbContext` class 

```C#
public class AppDbContext : IdentityDbContext
{
    // Rest of the code
}
```

Your application DbContext class must inherit from `IdentityDbContext` class instead of `DbContext` class. 
This is required because `IdentityDbContext` provides all the `DbSet` properties needed to manage the identity tables in SQL Server. 
If you go through the hierarchy chain of `IdentityDbContext` class, you will see it inherits from `DbContext` class. 
So this is the reason you do not have to explicitly inherit from `DbContext` class if your class is inheriting from `IdentityDbContext` class.

**Step 2 : Configure ASP.NET Core Identity Services**

In `ConfigureServices()` method of the `Startup` class, include the following line of code.

```C#
public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContextPool<AppDbContext>(
        options => options.UseSqlServer(_configuration.GetConnectionString("EmployeeDBConnection")));

    services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();

    services.AddMvc().AddXmlSerializerFormatters();
    services.AddScoped<IEmployeeRepository, SQLEmployeeRepository>();
}
```

- `AddIdentity()` method adds the default identity system configuration for the specified user and role types.
- `IdentityUser` class is provided by ASP.NET core and contains properties for `UserName`, `PasswordHash`, `Email` etc. 
This is the class that is used by default by the ASP.NET Core Identity framework to manage registered users of your application. 
- If you want store additional information about the registered users like their `Gender`, `City` etc. 
Create a custom class that derives from `IdentityUser`. In this custom class add the additional properties you need 
and then plug-in this class instead of the built-in `IdentityUser` class.
- Similarly, `IdentityRole` is also a builtin class provided by ASP.NET Core Identity and contains Role information.
- We want to store and retrieve User and Role information of the registered users using EntityFrameWork Core from the underlying SQL Server database. 
We specify this using `AddEntityFrameworkStores<AppDbContext>()` passing our application `DbContext` class as the generic argument.

**Step 3** : Add Authentication middleware to the request pipeline 

```C#
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    } else
    {
        app.UseExceptionHandler("/Error");
        app.UseStatusCodePagesWithReExecute("/Error/{0}");
    }

    app.UseStaticFiles();
    app.UseAuthentication();
    app.UseMvcWithDefaultRoute();
}
```

In the `Configure()` method of the Startup class, call `UseAuthentication()` method to add the **Authentication middleware** to the application's request processing pipeline. 
We want to be able to authenticate users **before** the request reaches the **MVC middleware**. 
So it's important we add authentication middleware **before the MVC middleware** in the request processing pipeline. 

**Step 4** : Add Identity Migration

In Visual Studio, from the Package Manager Console window execute the following command to add a new migration 

> Add-Migration AddingIdentity

This migration contains code that creates the tables required by the ASP.NET Core Identity system.

> Error : The entity type 'IdentityUserLogin<string>' requires a primary key to be defined

If you get this error, the most likely cause is that you are overriding `OnModelCreating()` method in your application `DbContext` class 
but not calling the base `IdentityDbContext` class `OnModelCreating()` method. 

Keys of Identity tables are mapped in `OnModelCreating` method of `IdentityDbContext` class. So, to fix this error, all you need to do is, 
call the base class `OnModelCreating()` method using the `base` keyword as shown below. 

```C#
public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    {
    }

    public DbSet<Employee> Employees { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Seed();
    }
}
```

**Step 5** : Generate ASP.NET Core Identity Tables 

> Update-Database

<p align="center">
  <img src="https://i.ibb.co/xXYfHsH/asp-net-core-identity-tutorial.png">
</p>

#### [Back to Table of Contents](#table-of-contents)

### Ep 66 - [Register in .Net Core MVC](https://www.youtube.com/watch?v=sPbDrqpme_w&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=66)

**RegisterViewModel Class**

We will use this `RegisterViewModel` Class as the model for Register view. It carries the information from the view to the controller class. 
For validation we are using several asp.net core validation attributes.

```C#
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreTutorialJourney.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password",
            ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
```

**AccountController**

```C#
using DotNetCoreTutorialJourney.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreTutorialJourney.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Register(RegisterViewModel registerViewModel)
        {
            return View();
        }
    }
}
```

**Register View **

Place this view in `Views/Account` folder

```HTML
@model RegisterViewModel

@{
    ViewBag.Title = "User Registration";
}

<div class="row">
    <div class="col-md-12">
        <form method="post">
            <div class="form-group">
                <label asp-for="Email"></label>
                <input asp-for="Email" class="form-control" />
                <span asp-validation-for="Email" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="Password"></label>
                <input asp-for="Password" class="form-control" />
                <span asp-validation-for="Password" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="ConfirmPassword"></label>
                <input asp-for="ConfirmPassword" class="form-control" />
                <span asp-validation-for="ConfirmPassword" class="text-danger"></span>
            </div>
            <div asp-validation-summary="All" class="text-danger"></div>
            <button type="submit" class="btn btn-primary">Register</button>
        </form>
    </div>
</div>
```

**Register Link in the Layout View**

```HTML
<div class="collapse navbar-collapse" id="collapsibleNavbar">
    <ul class="navbar-nav">
        <li class="nav-item">
            <a class="nav-link" asp-controller="home" asp-action="index">List</a>
        </li>
        <li class="nav-item">
            <a class="nav-link" asp-controller="home" asp-action="create">Create</a>
        </li>
    </ul>
    <ul class="navbar-nav ml-auto">
        <li class="nav-item">
            <a class="nav-link" asp-controller="account" asp-action="register">Register</a>
        </li>
    </ul>
</div>
```

#### [Back to Table of Contents](#table-of-contents)

### Ep 67 - [Register in .Net Core MVC by UserManager and SignInManager](https://www.youtube.com/watch?v=TfarnVqnhX0&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=67)

`UserManager<IdentityUser>` class contains the required methods to manage users in the underlying data store. 
For example, this class has methods like `CreateAsync`, `DeleteAsync`, `UpdateAsync` to create, delete and update users.

`SignInManager<IdentityUser>` class contains the required methods for users signin. 
For example, this class has methods like `SignInAsync`, `SignOutAsync` to signin and signout a user. 
- Both `UserManager` and `SignInManager` services are injected into the `AccountController` using constructor injection
- Both these services accept a generic parameter. We use the generic parameter to specify the User class that these services should work with.
- At the moment, we are using the built-in `IdentityUser` class as the argument for the generic parameter.
- The generic parameter on these 2 services is an extension point. 
- This means, we can create our own custom user with any additional data that we want to capture about the user 
and then plug-in this custom class as an argument for the generic parameter instead of the built-in IdentityUser class. 

```C#
[HttpPost]
public async Task<IActionResult> Register(RegisterViewModel model)
{
    if (ModelState.IsValid)
    {
        var user = new IdentityUser { UserName = model.Email, Email = model.Email };
        var result = await _userManager.CreateAsync(user, model.Password);

        if (result.Succeeded)
        {
            await _signInManager.SignInAsync(user, isPersistent: false);
            return RedirectToAction("index", "home");
        }

        foreach (var error in result.Errors)
        {
            ModelState.AddModelError("", error.Description);
        }
    }
    return View(model);
}
```

#### [Back to Table of Contents](#table-of-contents)

### Ep 68 - [Identity Password Complexity in .Net Core MVC](https://www.youtube.com/watch?v=kC9qrUcy2Js&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=68)

**ASP.NET Core Identity Password Default Settings**

In ASP.NET Core Identity, Password Default Settings are specified in the `PasswordOptions` class. 
You can find the source code [HERE](https://github.com/aspnet/AspNetCore/blob/44e68134528e3095064dc04bcb44effab3cb52df/src/Identity/Extensions.Core/src/PasswordOptions.cs).

```C#
public class PasswordOptions
{
    public int RequiredLength { get; set; } = 6;
    public int RequiredUniqueChars { get; set; } = 1;
    public bool RequireNonAlphanumeric { get; set; } = true;
    public bool RequireLowercase { get; set; } = true;
    public bool RequireUppercase { get; set; } = true;
    public bool RequireDigit { get; set; } = true;
}
```

**How to override password default settings in asp.net core identity**

We could do this by, using the `Configure()` method of the `IServiceCollection` interface in the `ConfigureServices()` method of the `Startup` class 

```C#
services.Configure<IdentityOptions>(options =>
{
    options.Password.RequiredLength = 10;
    options.Password.RequiredUniqueChars = 3;
    options.Password.RequireNonAlphanumeric = false;
});
```

OR 

**We could also do this while adding Identity services**

```C#
services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.Password.RequiredLength = 10;
    options.Password.RequiredUniqueChars = 3;
    options.Password.RequireNonAlphanumeric = false;
})
.AddEntityFrameworkStores<AppDbContext>();
```

**ASP.NET Core IdentityOptions**

In this example, we are using the `IdentityOptions` object to configure `PasswordOptions`. We could also use this `IdentityOptions` object to configure 
- UserOptions
- SignInOptions
- LockoutOptions
- TokenOptions
- StoreOptions
- ClaimsIdentityOptions

#### [Back to Table of Contents](#table-of-contents)

### Ep 69 - [Navigation Bar Based on Login Status in .Net Core MVC](https://www.youtube.com/watch?v=YLAHIZmO2PI&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=69)

First, inject `SignInManager` in `_Layout.cshtml`
```
@inject SignInManager<IdentityUser> SignInManager
```

Because this injection depends on `Microsoft.AspNetCore.Identity`, we need to import it in `_ViewImports.cshtml`
```
@using Microsoft.AspNetCore.Identity
```

Then, in `_Layout.cshtml`
```HTML
<ul class="navbar-nav ml-auto">
    @if (_signinmanager.IsSignedIn(User))
    {
        <li class="nav-item">
            <form method="post" asp-controller="account" asp-action="logout">
                <button type="submit" class="nav-link btn btn-link py-0" style="width: auto">
                    Logout @User.Identity.Name
                </button>
            </form>
        </li>
    }
    else
    {
        <li class="nav-item">
            <a class="nav-link" asp-controller="account" asp-action="register">Register</a>
        </li>
        <li class="nav-item">
            <a class="nav-link" asp-controller="account" asp-action="login">Login</a>
        </li>
    }
</ul>
```

Use a **POST** request to log the user out. Using a **GET** request to log out the user is **not recommended** 
because the approach may be abused. A malicious user may trick you into clicking an image element where the src attribute is set to the application logout url. 
As a result you are unknowingly logged out. 

In `AccountCountroller.cs` add 
```C#
[HttpPost]
public async Task<IActionResult> Logout()
{
    await _signInManager.SignOutAsync();
    return RedirectToAction("index", "home");
}
```

#### [Back to Table of Contents](#table-of-contents)

### Ep 70 - [Login in .Net Core MVC](https://www.youtube.com/watch?v=9d8DXXc71RI&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=70)

**LoginViewModel**

To login a user, we need their Email which is the username, password and whether if they want a persistent cookie or session cookie. 

```C#
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreTutorialJourney.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
```

**Session Cookie vs Persistent Cookie**

Upon a successful login, a cookie is issued and this cookie is sent with each request to the server. 
The server uses this cookie to know that the user is already authenticated and logged-in. 
This cookie can either be a session cookie or a persistent cookie. 

A session cookie is created and stored within the session instance of the browser. 
A session cookie does not contain an expiration date and is permanently deleted when the browser window is closed. 

A persistent cookie on the other hand is not deleted when the browser window is closed. 
It usually has an expiry date and deleted on the date of expiry. 

**Login View**

```HTML
@model LoginViewModel

@{
    ViewBag.Title = "User Login";
}

<h1>User Login</h1>

<div class="row">
    <div class="col-md-12">
        <form method="post" autocomplete="off">
            <div class="form-group">
                <label asp-for="Email"></label>
                <input asp-for="Email" class="form-control" />
                <span asp-validation-for="Email" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="Password"></label>
                <input asp-for="Password" class="form-control" />
                <span asp-validation-for="Password" class="text-danger"></span>
            </div>
            <div class="form-group">
                <div class="checkbox">
                    <label asp-for="RememberMe">
                        <input asp-for="RememberMe" />
                        @Html.DisplayNameFor(m => m.RememberMe)
                    </label>
                </div>
            </div>
            <div asp-validation-summary="All" class="text-danger"></div>
            <button type="submit" class="btn btn-primary">Login</button>
        </form>
    </div>
</div>
```

**Login Action in AccountController**

```C#
[HttpGet]
public ViewResult Login()
{
    return View();
}

[HttpPost]
public async Task<IActionResult> Login(LoginViewModel model)
{
    if (ModelState.IsValid)
    {
        var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

        if (result.Succeeded)
        {
            return RedirectToAction("index", "home");
        }

        ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
    }
    return View(model);
}
```

#### [Back to Table of Contents](#table-of-contents)

### Ep 71 - [Authorization in .Net Core MVC](https://www.youtube.com/watch?v=uET7MjhUeY4&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=71)

**What is Authorization in ASP.NET Core**

- Authentication is the process of identifying who the user is. 
- Authorization is the process of identifying what the user can and cannot do.
- For example, if the logged in user is an administrator he may be able to Create, Read, Update and Delete orders, 
where as a normal user may only view orders but not Create, Update or Delete orders.
- Authorization in ASP.NET Core MVC is controlled through the **AuthorizeAttribute**

**Authorize Attribute**

When the Authorize attribute is used in it's simplest form, without any parameters, it only checks if the user is authenticated. 

**Authorize Attribute Example**

As the Authorize attribute is applied on the Controller, it is applicable to all the action methods in the controller. 
The user must be logged in, to access any of the controller action methods. 

```C#
[Authorize]
public class HomeController : Controller
{
    public ViewResult Details(int? id)
    { 
    }
}

Authorize attribute can be applied on individual action methods as well.

```C#
public class HomeController : Controller
}
    [Authorize]
    public ViewResult Details(int? id)
    { 
    }
}
````

**AllowAnonymous Attribute**

As the name implies, AllowAnonymous attribute allows anonymous access. 
We generally use this attribute in combination with the Authorize attribute.

As the Authorize attribute is applied at the controller level, all the action methods in the controller are protected from anonymous access. 
However, since the Details action method is decorated with AllowAnonymous attribute, it will be allowed anonymous access. 

```C#
[Authorize]
public class HomeController : Controller
{
    [AllowAnonymous]
    public ViewResult Details(int? id)
    {
    }
}
```

**Please note**: If you apply `[AllowAnonymous]` attribute at the controller level, any `[Authorize]` attribute attribute on the same controller actions is ignored. 

**Apply Authorize attribute globally**

To apply `[Authorize]` attribute **globally on all controllers **and controller actions throughout your application 
modify the code in `ConfigureServices` method of the `Startup` class. 

```C#
public void ConfigureServices(IServiceCollection services)
{
    // Other Code

    services.AddMvc(config => {
        var policy = new AuthorizationPolicyBuilder()
                        .RequireAuthenticatedUser()
                        .Build();
        config.Filters.Add(new AuthorizeFilter(policy));
    });

    // Other Code
}
```
- `AuthorizationPolicyBuilder` is in `Microsoft.AspNetCore.Authorization` namespace 
- `AuthorizeFilter` is in `Microsoft.AspNetCore.Mvc.Authorization` namespace

If you do not have `[AllowAnonymous]` attribute on the `Login` actions of the `AccountController` 
you will get the following error because the application is stuck in an infinite loop.  

> HTTP Error 404.15 - Not Found 

Because when you access `login` page, you will be redirect to `login` page, which is a infinite loop.

In addition to this simple authorization, asp.net core supports **role based**, **claims based** and **policy based** authorization.

#### [Back to Table of Contents](#table-of-contents)

### Ep 72 - [Redirect User to Original URL after Login in .Net Core MVC](https://www.youtube.com/watch?v=-asykt9Zo_w&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=72)

**ReturnUrl**

By default, ASP.NET Core redirects to the login URL with `ReturnUrl` query string parameter. 
The URL that we were trying to access will be the value of the `ReturnUrl` query string parameter. 

**ReturnUrl Query String Example**

In this example, `ReturnUrl` is set to `ReturnUrl=/home/create`. 
I was trying to Create a New Employee by navigating to `/home/create` **without** first signing in. 

> http://localhost:5000/Account/Login?ReturnUrl=%2Fhome%2Fcreate

The characters %2F are the encoded characters for a forward slash (/).

**Redirect to ReturnUrl after Login**

ASP.NET Core model binding automatically maps the value 
- from the URL query string parameter ReturnUrl 
- to the Login() action method parameter returnUrl

ASP.NET Core Redirect(returnUrl) method, redirects the user to the specified returnUrl

```C#
[HttpPost]
[AllowAnonymous]
public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
{
    if (ModelState.IsValid)
    {
        var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

        if (result.Succeeded)
        {
            if (string.IsNullOrEmpty(returnUrl))
                return RedirectToAction("index", "home");
            return Redirect(returnUrl);
        }

        ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
    }
    return View(model);
}
```

There is a serious flaw in the way we have used the ReturnUrl query string parameter. 
This **opens a serious security hole** with in our application which is commonly known as open **redirect vulnerability**.  

#### [Back to Table of Contents](#table-of-contents)

### Ep 73 - [Open Redirect Vulnerability Example](https://www.youtube.com/watch?v=0q0CZTliQ7A&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=73)

**Application Vulnerable to Open Redirect Attacks**

Your application is vulnerable to open redirect attacks if the following 2 conditions are true 

1. Your application redirects to a URL that's specified **via the request** such as the querystring or form data
2. The redirection is performed **without checking** if the URL is a **local URL**

**Open Redirect Vulnerability Example**

- The user of your application is tricked into clicking a link in an email where the returnUrl is set to the attackers website. 
> http://example.com/account/login?returnUrl=http://exampie.com/account/login

- The user logs in successfully on the authentic site and he is then redirected to the attackers website
> http://exampie.com/account/login

- The login page of the attackers website looks exactly like the authentic site.
- The user logs in again on the attackers website, thinking that the first login attempt was unsuccessful
- The user is then redirected back to the authentic site.
- During this entire process, the user does not even know his credentials are stolen.

**Prevent open redirect attacks**

We have an open redirect vulnerability because, the URL is supplied to the application from the query string.
We are simply redirecting to that URL without any validation
which is what is making our application vulnerable to open redirect attacks. 

ASP.NET Core has **built-in support** for local redirection. Simply use the `LocalRedirect()` method. **If a non-local URL is specified an exception is thrown**

```C#
public IActionResult Login(string returnUrl)
{
    return LocalRedirect(returnUrl);
}
```

Or, check if the provided URL is a local URL, use `IsLocalUrl()` method. 

```C#
public IActionResult Login(string returnUrl)
{
    if (Url.IsLocalUrl(returnUrl))
        return Redirect(returnUrl);
	return RedirectToAction("index", "home");
}
```

#### [Back to Table of Contents](#table-of-contents)

### Ep 74 - [Client Side Validation in .Net Core MVC](https://www.youtube.com/watch?v=PUX3PzyBofg&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=74)

**Server Side Validation**

As the name implies, server side validation is done on the server. So there is a round trip between the client browser and the web server. 
The request has to be sent over the network to the web server for processing. This means if the network is slow or 
if the server is busy processing other requests, the end user may have to wait a few seconds and it also increases load on the server.  

This validation can be performed on the client machine itself, which means there is no round trip to the server, no waiting time, 
client has instant feedback and the load on the server is also reduced to a great extent. 

We decorate the respective model properties with the `[Required]` attribute for server side validation

**Client Side Validation**

There are 2 approaches that you could take to implement client side validation in asp.net core. 

**Approach 1** : Write your own custom JavaScript code to implement client-side validation which is obviously tedious and time consuming. 

**Approach 2** : Use the unobtrusive client-side validation libraries provided by asp.net core. 

With the second approach, we do not have to write a single line of code. All we have to do is include the following 3 scripts in the order specified. 

```HTML
<script src="~/node_modules/jquery/dist/jquery.slim.js"></script>
<script src="~/node_modules/jquery-validation/dist/jquery.validate.js"></script>
<script src="~/node_modules/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.js"></script>
```

**What does "Unobtrusive Validation" Mean**

Unobtrusive Validation allows us to take the already-existing server side validation attributes and use them to implement client-side validation. 
We do not have to write a single line of custom JavaScript code. All we need is the above 3 script files in the order specified. 

The unobtrusive validation is done using the jquery.validate.unobtrusive.js library. This library is built on top of jquery.validate.js library, 
which in turns uses jQuery. This is the reason we need to import these 3 libraries in the order specified. 

**How does client side validation work in ASP.NET Core**

The Email property is decorated with `[Required]` attribute. To generate input field for Email, we use asp.net core input tag helper 

```HTML
<input asp-for="Email"/>
```

ASP.NET Core tag helpers work in combination with the model validation attributes and generate the following HTML. 
Notice in the generated HTML we have `data-*` attributes. 

```HTML
<input id="Email" name="Email" type="email" data-val="true"
       data-val-required="The Email field is required." />
```

The `data-*` attributes allow us to add extra information to an HTML element. 
These `data-*` attributes carry all the information required to perform the client-side validation. 
It is the unobtrusive library (i.e `jquery.validate.unobtrusive.js`) that reads these `data-val` attributes and performs the client side validation. 

#### [Back to Table of Contents](#table-of-contents)

### Ep 75 - [Remote Validation in .Net Core MVC](https://www.youtube.com/watch?v=2jZc11l67Zk&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=75)


**What is Remote Validation**

Remote validation allows a controller action method to be called using client side script. 
This is very useful when you want to call a server side method without a full page post back. 

For example, check if the provided email is already taken by another user can only be done on the server. 
The following `IsEmailInUse()` controller action method checks if the provided email is in use. 

```C#
[HttpGet]
[HttpPost]
[AllowAnonymous]
public async Task<IActionResult> IsEmailInUse(string email) => 
	Json(await _userManager.FindByEmailAsync(email) == null ? "true" : $"Email {email} is already in use.");
```

- ASP.NET Core MVC uses jQuery `remote()` method which in turn issues an **AJAX** call to invoke the server side method. 
- The jQuery `remote()` method expects a JSON response, 
this is the reason we are returning JSON response from the server-side method (IsEmailInUse)

**ASP.NET core remote attribute**

```C#
public class RegisterViewModel
{
    [Required]
    [EmailAddress]
    [Remote(action: "IsEmailInUse", controller: "Account")]
    public string Email { get; set; }

    // Other properties
}
```

The following 3 client-side libraries are required in the order specified for the remote validation to work. 
If any of them are missing or not loaded in the order specified, remote validation will not work. 
- jquery.js
- jquery.validate.js
- jquery.validate.unobtrusive.js

#### [Back to Table of Contents](#table-of-contents)

### Ep 76 - [Custom Validation Attribute in .Net Core MVC](https://www.youtube.com/watch?v=o_AH2MGti0A&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=76)

**Custom Attribute**

If you have a complex validation requirement that you cannot implement using the built-in attributes, 
you can create a custom validation attribute and reuse it in your project or even in multiple projects 
if you create it in a separate class library project. 

```C#
public class EmployeeCreateViewModel
{
    [AGreaterThanBC("B", "C", ErrorMessage = "It should be b+c")]
    public int? A { get; set; }
    public int? B { get; set; }
    public int? C { get; set; }
}
```

```C#
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreTutorialJourney.Utilities
{
    public class AGreaterThanBCAttribute : ValidationAttribute
    {
        private readonly string _b;
        private readonly string _c;

        public AGreaterThanBCAttribute(string b, string c)
        {
            _b = b;
            _c = c;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ErrorMessage = ErrorMessageString;

            var currentValue = value ?? 0;
            var comparingB = validationContext.ObjectType.GetProperty(_b);
            var comparingC = validationContext.ObjectType.GetProperty(_c);
            var comparisonValueB = comparingB.GetValue(validationContext.ObjectInstance) ?? 0;
            var comparisonValueC = comparingC.GetValue(validationContext.ObjectInstance) ?? 0;

            if ((int)currentValue != (int)comparisonValueB + (int)comparisonValueC)
                return new ValidationResult(ErrorMessage);
            return ValidationResult.Success;
        }
    }
}
```

#### [Back to Table of Contents](#table-of-contents)

### Ep 77 - [Extend IdentityUser in .Net Core MVC](https://www.youtube.com/watch?v=NV734cJdZts&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=77)

```C#
using Microsoft.AspNetCore.Identity;

namespace DotNetCoreTutorialJourney.Models
{
    public class AppUser : IdentityUser
    {
        public string Gender { get; set; }
    }
}
```

Find all references of `IdentityUser` class and replace it with our custom `AppUser` class. 
The easiest way to do this is to, right click on the `IdentityUser` class and then select **"Find All References"** from the context menu.

Specify `AppUser` class as the generic argument for the `IdentityDbContext` class in "AppDbContext.cs"

```C#
namespace DotNetCoreTutorialJourney.Models
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
```

Generate a new migration

> Add-Migration Extend_IdentityUser

Next, apply the migration to the database

> Update-Database

RegisterViewModel class

```C#
public class RegisterViewModel
{
    // Other Properties

    public string Gender { get; set; }
}
```

Register View 

```HTML
<div class="form-group">
    <label asp-for="City"></label>
    <input asp-for="City" class="form-control" />
</div>
```

AccountController - Register action 

```C#
[HttpPost]
[AllowAnonymous]
public async Task<IActionResult> Register(RegisterViewModel model)
{
    if (ModelState.IsValid)
    {
        var user = new AppUser { UserName = model.Email, Email = model.Email, Gender = model.Gender};
        var result = await _userManager.CreateAsync(user, model.Password);

        if (result.Succeeded)
        {
            await _signInManager.SignInAsync(user, isPersistent: false);
            return RedirectToAction("index", "home");
        }

        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }
    }
    return View(model);
}
```

#### [Back to Table of Contents](#table-of-contents)

### Ep 78 - [Creating Roles in .Net Core MVC](https://www.youtube.com/watch?v=TuJd2Ez9i3I&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=78)

**RoleManager in ASP.NET Core**

- To create a user in asp.net core we use `UserManager` class. Similarly, to create a role, we use `RoleManager` class provided by asp.net core
- The built-in `IdentityRole` class represents a Role
- `RoleManager` class performs all the CRUD operations i.e Creating, Reading, Updating and Deleting roles from the underlying database table AspNetRoles
- To tell the RoleManager class to work with `IdentityRole` class, we specify `IdentityRole` class as the generic argument to `RoleManager` 
- `RoleManager` is made available to any controller or view by asp.net core dependency injection system

```C#
public class AdministrationController : Controller
{
    private readonly RoleManager<IdentityRole> _roleManager;

    public AdministrationController(RoleManager<IdentityRole> roleManager)
    {
        _roleManager = roleManager;
    }
}
```

Controller code to create a new role

```C#
using DotNetCoreTutorialJourney.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DotNetCoreTutorialJourney.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdministrationController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        [HttpGet]
        public ViewResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole { Name = model.RoleName };
                IdentityResult result = await _roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                    return RedirectToAction("index", "home");

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }
    }
}
```

Create Role View Model 

```C#
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreTutorialJourney.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }
}
```

Create Role View

```HTML
@model CreateRoleViewModel

@{
    ViewBag.Title = "Create New Role";
}

<h1>Create New Role</h1>

<div class="row">
    <div class="col-md-12">
        <form method="post" autocomplete="off">
            <div class="form-group">
                <label asp-for="RoleName"></label>
                <input asp-for="RoleName" class="form-control" />
                <span asp-validation-for="RoleName" class="text-danger"></span>
            </div>
            <div asp-validation-summary="All" class="text-danger"></div>
            <button type="submit" class="btn btn-primary" style="width: auto">Create Role</button>
        </form>
    </div>
</div>
```

#### [Back to Table of Contents](#table-of-contents)

### Ep 79 - [Get List of Roles in .Net Core MVC](https://www.youtube.com/watch?v=KGIT8P29jf4&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=79)

**Roles** property of `RoleManager` class returns the list of all `IdentityRole` objects

```C#
[HttpGet]
public ViewResult ListRoles()
{
    var roles = _roleManager.Roles;
    return View(roles);
}
```

**List Roles View**

- **ID** property of the `IdentityRole` object returns the role ID
- **Name** property of the `IdentityRole` object returns the role Name

```HTML
@model IEnumerable<IdentityRole>

@if (Model.Any())
{
    foreach (var role in Model)
    {
        <div>
            Role Id : @role.Id
        </div>
        <div>
            <h5>@role.Name</h5>
        </div>
    }
}
else
{
    <div>
        <a asp-controller="administration" asp-action="CreateRole">
            Create Role
        </a>
    </div>
}
```

#### [Back to Table of Contents](#table-of-contents)

### Ep 80 - [Edit Role in .Net Core MVC](https://www.youtube.com/watch?v=7ikyZk5fGzk&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=80)

When **Edit** button on one of the roles is clicked, we want to go to `EditRole` action in the `AdministrationController`. 
We are using `asp-action` and `asp-controller` tag helpers to do that. 
We also want to pass the `ID` of the role to edit. We pass the Role ID using `asp-route-id` tag helper.

```HTML
<a asp-controller="Administration" asp-action="EditRole"
   asp-route-id="@role.Id" class="btn btn-primary">
    Edit
</a>
```

`asp-route-id` tag helper includes the Role ID in the URL  
> /Administration/EditRole/7360350f-2662-4842-8a78-58a308043477

**Edit Role View Model**

The constructor initializes `Users` property so we do not get **NULL reference** exceptions. 

```C#
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.ViewModels
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }

        public string Id { get; set; }

        [Required(ErrorMessage = "Role Name is required")]
        public string RoleName { get; set; }

        public List<string> Users { get; set; }
    }
}
```

**Edit Role Action Methods**

```C#
// Role ID is passed from the URL to the action
[HttpGet]
public async Task<IActionResult> EditRole(string id)
{
    // Find the role by Role ID
    var role = await roleManager.FindByIdAsync(id);

    if (role == null)
    {
        ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found";
        return View("NotFound");
    }

    var model = new EditRoleViewModel
    {
        Id = role.Id,
        RoleName = role.Name
    };

    // Retrieve all the Users
    foreach (var user in userManager.Users)
    {
        // If the user is in this role, add the username to
        // Users property of EditRoleViewModel. This model
        // object is then passed to the view for display
        if (await userManager.IsInRoleAsync(user, role.Name))
        {
            model.Users.Add(user.UserName);
        }
    }

    return View(model);
}

// This action responds to HttpPost and receives EditRoleViewModel
[HttpPost]
public async Task<IActionResult> EditRole(EditRoleViewModel model)
{
    var role = await roleManager.FindByIdAsync(model.Id);

    if (role == null)
    {
        ViewBag.ErrorMessage = $"Role with Id = {model.Id} cannot be found";
        return View("NotFound");
    }
    else
    {
        role.Name = model.RoleName;

        // Update the Role using UpdateAsync
        var result = await roleManager.UpdateAsync(role);

        if (result.Succeeded)
        {
            return RedirectToAction("ListRoles");
        }

        foreach (var error in result.Errors)
        {
            ModelState.AddModelError("", error.Description);
        }

        return View(model);
    }
}
```

**Edit Role View**

```HTML
@model EditRoleViewModel

@{
    ViewBag.Title = "Edit Role";
}

<h1>Edit Role</h1>

<form method="post" class="mt-3" autocomplete="off">
    <div class="form-group row">
        <label asp-for="Id" class="col-sm-2 col-form-label"></label>
        <div class="col-sm-10">
            <input asp-for="Id" disabled class="form-control">
        </div>
    </div>
    <div class="form-group row">
        <label asp-for="RoleName" class="col-sm-2 col-form-label"></label>
        <div class="col-sm-10">
            <input asp-for="RoleName" class="form-control">
            <span asp-validation-for="RoleName" class="text-danger"></span>
        </div>
    </div>

    <div asp-validation-summary="All" class="text-danger"></div>

    <div class="form-group row">
        <div class="col-sm-10">
            <button type="submit" class="btn btn-primary">Update</button>
            <a asp-action="ListRoles" class="btn btn-primary">Cancel</a>
        </div>
    </div>

    <div class="card">
        <div class="card-header">
            <h3>Users in this role</h3>
        </div>
        <div class="card-body">
            @if (Model.Users.Any())
            {
                foreach (var user in Model.Users)
                {
                    <h5 class="card-title">@user</h5>
                }
            }
            else
            {
                <h5 class="card-title">None at the moment</h5>
            }
        </div>
        <div class="card-footer">
            <a href="#" class="btn btn-primary" style="width:auto">Add Users</a>
            <a href="#" class="btn btn-primary" style="width:auto">Remove Users</a>
        </div>
    </div>
</form>
```

#### [Back to Table of Contents](#table-of-contents)


























































































































































































































































































































































































































































































































































































































































































































































































































































































































































