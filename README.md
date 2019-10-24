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

##### [Back to Table of Contents](#table-of-contents)

#### Ep 15 - [.Net Core MVC](https://www.youtube.com/watch?v=f72ookCWhsQ&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=15)

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

##### [Back to Table of Contents](#table-of-contents)

#### Ep 16 - [Setup MVC in .Net Core](https://www.youtube.com/watch?v=KQH51Yip0K0&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=16)

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

##### [Back to Table of Contents](#table-of-contents)

#### Ep 18 - [Model in .Net Core MVC](https://www.youtube.com/watch?v=KXPbJ9I4ce0&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=18)

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

##### [Back to Table of Contents](#table-of-contents)

#### Ep 19 - [.Net Core dependency injection](https://www.youtube.com/watch?v=BPGtVpu81ek&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=19)

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

##### [Back to Table of Contents](#table-of-contents)

#### Ep 20 - [Controller in .Net Core MVC](https://www.youtube.com/watch?v=-O0UYM0ZIIc&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=20)

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

##### [Back to Table of Contents](#table-of-contents)

#### Ep 21 - [View in .Net Core MVC](https://www.youtube.com/watch?v=SWIcHLBnJUg&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=21)

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

##### [Back to Table of Contents](#table-of-contents)

#### Ep 23 - [ViewData in .Net Core MVC](https://www.youtube.com/watch?v=tz4q6q0_JwQ&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=23)

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

##### [Back to Table of Contents](#table-of-contents)

#### Ep 24 - [ViewBag in .Net Core MVC](https://www.youtube.com/watch?v=FBvNz00o7jg&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=24)

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

##### [Back to Table of Contents](#table-of-contents)

#### Ep 25 - [Strongly Typed View in .Net Core MVC](https://www.youtube.com/watch?v=5auO0iXrOs4&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=25)

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

##### [Back to Table of Contents](#table-of-contents)


























































































































































