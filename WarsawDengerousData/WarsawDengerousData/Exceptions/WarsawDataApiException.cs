using System;

namespace WarsawDengerousData.Exceptions
{
    public class WarsawDataApiException : Exception
    {
        public WarsawDataApiException(string message, Exception exception)
            : base(message, exception)
        {
        }
    }
}