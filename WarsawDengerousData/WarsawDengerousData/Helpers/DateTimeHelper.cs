using System;
using WarsawDengerousData.Exceptions;

namespace WarsawDengerousData.Helpers
{
    public class DateTimeHelper
    {
        public static string GetUtcTime(long unixDateTime)
        {
            try
            {
                var dtOffset = DateTimeOffset.FromUnixTimeMilliseconds(unixDateTime);
                return dtOffset.UtcDateTime.ToString();
            }
            catch (Exception ex)
            {
                throw new DateTimeHelperException($"Cannot parse unix date time: {unixDateTime}", ex);
            }
        }
    }
}