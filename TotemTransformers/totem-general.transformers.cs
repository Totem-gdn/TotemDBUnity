using System;

namespace TotemTransformers
{
    public class GeneralTotemTransformers {
        public static DateTime ItemDateToDateTime(string dateStr)
        {
            return DateTime.Parse(dateStr);
        }
    }
}