# Notifications
Implementation of the [Notification API](https://developer.mozilla.org/en-US/docs/Web/API/notification) in C# for [Blazor](https://github.com/aspnet/Blazor) via Interop.

## Demo
There is a sample application in /tests/ folder
For some other references of what the API does see the example [demo](https://web-push-book.gauntface.com/demos/notification-examples/)

## Installation

Coming Soon (waiting on the nuspec/ci)

## Usage

### Add INotificationService via DI
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
bool IsSupportedByBrowser = NotificationService.IsSupportedByBrowserAsync; 
```
### Request Permission
```csharp
PermissionType permission = await NotificationService.RequestPermissionAsync();
```
