using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Blazor.Extensions
{
    internal class NotificationService : INotificationService
    {
        private const string AreSupportedFunctionName = "BlazorExtensions.Notifications.IsSupported";
        private const string RequestPermissionFunctionName = "BlazorExtensions.Notifications.RequestPermission";
        private const string CreateFunctionName = "BlazorExtensions.Notifications.Create";

        private readonly IJSRuntime runtime;

        public NotificationService(IJSRuntime runtime)
        {
            this.runtime = runtime;
        }

        public ValueTask<bool> IsSupportedByBrowserAsync()
        {
            return this.runtime.InvokeAsync<bool>(AreSupportedFunctionName);
        }
        public async Task<PermissionType> RequestPermissionAsync()
        {
            string permission = await this.runtime.InvokeAsync<string>(RequestPermissionFunctionName);

            if (permission.Equals("granted", StringComparison.InvariantCultureIgnoreCase))
                return PermissionType.Granted;

            if (permission.Equals("denied", StringComparison.InvariantCultureIgnoreCase))
                return PermissionType.Denied;

            return PermissionType.Default;
        }


        public ValueTask<string> CreateAsync(string title, NotificationOptions options) => this.runtime.InvokeAsync<string>(CreateFunctionName, title, options);

        public ValueTask<string> CreateAsync(string title, string body, string icon)
        {
            NotificationOptions options = new NotificationOptions
            {
                Body = body,
                Icon = icon,
            };

            return this.runtime.InvokeAsync<string>(CreateFunctionName, title, options);
        }
    }
}
