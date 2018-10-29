using System.Threading.Tasks;

namespace Blazor.Extensions
{
    public interface INotificationService
    {
        /// <summary>
        /// Checks if the Notifications' API is Support by the browser.
        /// </summary>
        /// <returns></returns>
        Task<bool> IsSupportedByBrowserAsync();
        /// <summary>
        /// Request the user for his permission to send notifications.
        /// </summary>
        /// <returns></returns>
        Task<PermissionType> RequestPermissionAsync();
        /// <summary>
        /// Create a Notification with <seealso cref="NotificationOptions"/>
        /// </summary>
        /// <param name="title"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        Task CreateAsync(string title, NotificationOptions options);
        Task CreateAsync(string title, string description, string iconUrl);
    }
}