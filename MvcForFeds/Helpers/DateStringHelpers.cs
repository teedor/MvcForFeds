using System;

namespace MvcForFeds.Helpers
{
    public class DateStringHelpers
    {
        public static string DaySuffix(DateTime date) => date.Day % 10 == 1 && date.Day != 11 ? "st"
                : date.Day % 10 == 2 && date.Day != 12 ? "nd"
                    : date.Day % 10 == 3 && date.Day != 13 ? "rd"
                        : "th";
    }
}