# DotNet Core Journey

**DotNet Core Version 2.1**

This repository is created based on **[ASP.NET core tutorial for beginners](https://www.youtube.com/playlist?list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU)** by **[kudvenkat](https://www.youtube.com/channel/UCCTVrRB5KpIiK6V2GGVsR1Q)**

## Notes
### [Ep 6 - DotNet Core in process hosting](https://www.youtube.com/watch?v=ydR2jd3ZaEA&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=6)
Some of the tasks that `CreateDefaultBuilder()` performs
1. Setting up the web server
2. Loading the host and application configuration from various configuration sources and
3. Configuring logging

An DotNet Core application can be hosted
- InProcess or
- OutOfProcess 

To configure hosting you can modify `<AspNetCoreHostingModel>InProcess</AspNetCoreHostingModel>` under `.csproj`