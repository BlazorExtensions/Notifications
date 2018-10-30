using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions
{
    internal class NotificationService : INotificationService
    {
        private const string AreSupportedFunctionName = "BlazorExtensions.Notifications.IsSupported";
        private const string RequestPermissionFunctionName = "BlazorExtensions.Notifications.RequestPermission";
        private const string CreateFunctionName = "BlazorExtensions.Notifications.Create";

        public Task<bool> IsSupportedByBrowserAsync()
        {
            return JSRuntime.Current.InvokeAsync<bool>(AreSupportedFunctionName);
        }
        public async Task<PermissionType> RequestPermissionAsync()
        {
            string permission = await JSRuntime.Current.InvokeAsync<string>(RequestPermissionFunctionName);

            if (permission.Equals("granted", StringComparison.InvariantCultureIgnoreCase))
                return PermissionType.Granted;

            if (permission.Equals("denied", StringComparison.InvariantCultureIgnoreCase))
                return PermissionType.Denied;

            return PermissionType.Default;
        }


        public Task CreateAsync(string title, NotificationOptions options) => JSRuntime.Current.InvokeAsync<string>(CreateFunctionName, title, options);

        public Task CreateAsync(string title, string body, string icon)
        {
            NotificationOptions options = new NotificationOptions
            {
                Body = body,
                Icon = icon,
            };

            return JSRuntime.Current.InvokeAsync<string>(CreateFunctionName, title, options);
        }
    }
}
