using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebUI.Utilities
{
    public static class Helper
    {
        public static string ToRelativeDate(this DateTime dateTime)
        {
            var timeSpan = DateTime.Now - dateTime;

            if (timeSpan <= TimeSpan.FromSeconds(60))
                return string.Format("{0} seconds ago", timeSpan.Seconds);

            if (timeSpan <= TimeSpan.FromMinutes(60))
                return timeSpan.Minutes > 1 ? String.Format("{0} minutes ago", timeSpan.Minutes) : "about a minute ago";

            if (timeSpan <= TimeSpan.FromHours(24))
                return timeSpan.Hours > 1 ? String.Format("{0} hours ago", timeSpan.Hours) : "about an hour ago";

            if (timeSpan <= TimeSpan.FromDays(30))
                return timeSpan.Days > 1 ? String.Format("{0} days ago", timeSpan.Days) : "yesterday";

            if (timeSpan <= TimeSpan.FromDays(365))
                return timeSpan.Days > 30 ? String.Format("{0} months ago", timeSpan.Days / 30) : "about a month ago";

            return timeSpan.Days > 365 ? String.Format("{0} years ago", timeSpan.Days / 365) : "about a year ago";
        }

        private static void ChangeCulture(CultureInfo culture)
        {
            culture.DateTimeFormat.FullDateTimePattern = "dd.MM.yyyy HH:mm:ss";
            culture.DateTimeFormat.ShortDatePattern = "dd.MM.yyyy";
            culture.DateTimeFormat.ShortTimePattern = "HH:mm:ss";
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }
    }
}
