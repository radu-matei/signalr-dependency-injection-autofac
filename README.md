# SignalR Dependency Injection using Autofac
This project demonstrates  the use of DI in SignalR using Autofac

The purpose is:
- to inject dependencies in SignalR Hubs
- to avoid using the `GlobalHost` global property to retrieve hub context and to inject the `IConnectionManager` 
