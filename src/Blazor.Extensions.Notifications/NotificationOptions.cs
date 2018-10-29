using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.Extensions
{
    public class NotificationOptions
    {
        #region Properties
        /// <summary>
        /// A <see cref="DateTime"/> representing the time, in milliseconds since 00:00:00 UTC on 1 January 1970, of the event for which the notification was created.
        /// </summary>
        public DateTime? TimeStamp { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// The direction in which to display the notification. It defaults to auto, which just adopts the browser's language setting behavior, but you can override that behaviour by setting values of ltr and rtl (although most browsers seem to ignore these settings.)
        /// </summary>
        public string Dir { get; set; } = "auto";
        /// <summary>
        /// The notification's language, as specified using a <see cref="string"/> representing a BCP 47 language tag. See the Sitepoint ISO 2 letter language codes page for a simple reference.
        /// </summary>
        public string Lang { get; set; } = "en";
        /// <summary>
        /// a <see cref="string"/> containing the URL of the image used to represent the notification when there is not enough space to display the notification itself.
        /// </summary>
        public string Badge { get; set; }
        /// <summary>
        /// A <see cref="string"/> representing the body text of the notification, which will be displayed below the title.
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// A <see cref="string"/> representing an identifying tag for the notification.
        /// </summary>
        public string Tag { get; set; }
        /// <summary>
        /// A <see cref="string"/> containing the URL of an icon to be displayed in the notification.
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// A <see cref="string"/> containing the URL of an image to be displayed in the notification.
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// An <see cref="object"/> with arbitrary data that you want associated with the notification. This can be of any data type.
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// A <see cref="bool"/> specifying whether the user should be notified after a new notification replaces an old one. The default is false, which means they won't be notified.
        /// </summary>
        public bool? Renotify { get; set; }
        /// <summary>
        /// Indicates that a notification should remain active until the user clicks or dismisses it, rather than closing automatically. The default value is false.
        /// </summary>
        public bool? RequireInteraction { get; set; }
        /// <summary>
        /// A <see cref="bool"/> specifying whether the notification should be silent, i.e. no sounds or vibrations should be issued, regardless of the device settings.
        /// The default is false, which means it won't be silent.
        /// </summary>
        public bool? Silent { get; set; }
        /// <summary>
        /// A <see cref="string"/> containing the URL of an audio file to be played when the notification fires.
        /// </summary>
        public string Sound { get; set; }
        /// <summary>
        /// A <see cref="bool"/> specifying whether the notification firing should enable the device's screen or not.
        /// The default is false, which means it will enable the screen.
        /// </summary>
        public bool? NoScreen { get; set; }
        /// <summary>
        /// A <see cref="bool"/> specifying whether the notification should be 'sticky', i.e. not easily clearable by the user.
        /// The default is false, which means it won't be sticky.
        /// </summary>
        public bool? Sticky { get; set; }
        /// <summary>
        /// The amount of seconds until the notifciation is closed.
        /// </summary>
        public int? TimeOut { get; set; } = 5;
        #endregion
    }
}
