# Notifications
Implementation of the [Notification API](https://developer.mozilla.org/en-US/docs/Web/API/notification) in C# for [Microsoft Blazor](https://github.com/aspnet/Blazor).

[![Build status](https://dotnet-ci.visualstudio.com/DotnetCI/_apis/build/status/Blazor-Extensions-Notifications-CI?branch=master)](https://dotnet-ci.visualstudio.com/DotnetCI/_build/latest?definitionId=8&branch=master)
[![Package Version](https://img.shields.io/nuget/v/Blazor.Extensions.Notifications.svg)](https://www.nuget.org/packages/Blazor.Extensions.Notifications)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Blazor.Extensions.Notifications.svg)](https://www.nuget.org/packages/Blazor.Extensions.Notifications)
[![License](https://img.shields.io/github/license/BlazorExtensions/Notifications.svg)](https://github.com/BlazorExtensions/Notifications/blob/master/LICENSE)

# Blazor Extensions

Blazor Extensions are a set of packages with the goal of adding useful things to [Blazor](https://blazor.net).

## Installation

```
Install-Package Blazor.Extensions.Notifications
```

## Demo
There is a sample application in /tests/ folder
For some other references of what the API does see the example [demo](https://web-push-book.gauntface.com/demos/notification-examples/)

## Usage

### Add `INotificationService` via DI
> Scoped by default.
```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddNotifications();
}
```

### Inject into component/pages
```csharp
@using Blazor.Extensions
@inject INotificationService NotificationService
```

or

### Inject on a `BlazorComponent` class:

```c#
[Inject] private INotificationService _notificationService { get; set; }
```

### Create a notification
```csharp
NotificationOptions options = new NotificationOptions
{
    Body = body,
    Icon = icon,
};

await NotificationService.CreateAsync(title, options);
```
 ### Browser Support
```csharp
bool IsSupportedByBrowser = NotificationService.IsSupportedByBrowserAsync(); 
```
### Request Permission
```csharp
PermissionType permission = await NotificationService.RequestPermissionAsync();
```

# Contributions and feedback

Please feel free to use the component, open issues, fix bugs or provide feedback.

# Contributors

This project is created and maintained by:

- [Benjamin Vertonghen](https://github.com/vertonghenb)

The following people are the maintainers of the Blazor Extensions projects:

- [Attila Hajdrik](https://github.com/attilah)
- [Gutemberg Ribiero](https://github.com/galvesribeiro)
