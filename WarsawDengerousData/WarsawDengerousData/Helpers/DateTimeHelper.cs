using System;

namespace WarsawDengerousData.Helpers
{
    public class DateTimeHelper
    {
        public static string GetUtcTime(long unixDateTime)
        {
            var dtOffset = DateTimeOffset.FromUnixTimeMilliseconds(unixDateTime);
            return dtOffset.UtcDateTime.ToString();
        }
    }
}