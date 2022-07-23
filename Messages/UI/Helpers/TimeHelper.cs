using System;
using System.Linq;

namespace Messages.UI.Helpers
{
    public static class TimeHelper
    {
        public static string ToHoursString(this TimeSpan span, bool showPlusWhenPositive = false)
        {
            string prefix = "";
            if (span.TotalSeconds < 0)
            {
                span = TimeSpan.FromSeconds(-span.TotalSeconds);
                prefix = "-";
            }
            else if (showPlusWhenPositive)
                prefix = "+";

            return $"{prefix}{(int)Math.Truncate(span.TotalHours)}:{span.Minutes:D2}";
        }

        /// <summary>
        /// Expected input '#:##'
        /// Digits only will be handled as minutes
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static TimeSpan ParseToTimeSpan(this string text)
        {
            text = text.Replace(".", ":").Replace(",", ":").Replace("-0:", "-");
            var split = text.Split(':').Reverse().ToArray();
            var minutePart = split[0] == String.Empty ? "0" : split[0];
            var minSpan = TimeSpan.FromMinutes(int.Parse(minutePart));
            TimeSpan deltaSpan;
            if (split.Length == 1) // minutes only
                deltaSpan = minSpan;
            else
            {
                deltaSpan = TimeSpan.FromHours(int.Parse(split[1]));
                if (deltaSpan < TimeSpan.Zero)
                    deltaSpan -= minSpan;
                else
                    deltaSpan += minSpan;
            }

            return deltaSpan;
        }
    }
}