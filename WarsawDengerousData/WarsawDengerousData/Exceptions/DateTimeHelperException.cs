using System;

namespace WarsawDengerousData.Exceptions
{
    public class DateTimeHelperException : Exception
    {
        public DateTimeHelperException(string message, Exception ex)
            : base(message, ex)
        {
        }
    }
}