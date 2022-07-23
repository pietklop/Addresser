using System;
using System.Globalization;

namespace Messages.UI.Helpers
{
    public static class DateHelper
    {
        public static bool IsWeekend(this DateTime date) => date.DayOfWeek.IsWeekend();
        
        public static bool IsWeekend(this DayOfWeek day) => day == DayOfWeek.Saturday || day == DayOfWeek.Sunday;

        public static string ToDayString(this DateTime date, bool displayThreeCharDay = true)
        {
            string month = date.ToString("MMM", CultureInfo.CurrentCulture).Substring(0, 3);
            var sDay = displayThreeCharDay ? $"{Day()} " : "";
            return $"{sDay}{date.Day} {month}";

            string Day()
            {
                switch (date.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        return "Sun";
                    case DayOfWeek.Monday:
                        return "Mon";
                    case DayOfWeek.Tuesday:
                        return "Tue";
                    case DayOfWeek.Wednesday:
                        return "Wed";
                    case DayOfWeek.Thursday:
                        return "Thu";
                    case DayOfWeek.Friday:
                        return "Fri";
                    case DayOfWeek.Saturday:
                        return "Sat";
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        public static int WeekOfYear(this DateTime date)
        {
            var cal = CultureInfo.InvariantCulture.Calendar;
            return cal.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        public static DateTime Max(DateTime dateTime1, DateTime dateTime2) => dateTime1 > dateTime2 ? dateTime1 : dateTime2;
        public static DateTime Min(DateTime dateTime1, DateTime dateTime2) => dateTime1 < dateTime2 ? dateTime1 : dateTime2;
    }

}