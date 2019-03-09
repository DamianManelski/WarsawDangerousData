using Newtonsoft.Json.Converters;

namespace WarsawDengerousData.WarsawApiData
{
    public class DateFormatConverter : IsoDateTimeConverter
    {
        public DateFormatConverter(string format)
        {
            DateTimeFormat = format;
        }
    }
}