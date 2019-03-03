using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;
using WarsawDengerousData.Services.DataConverters;
using WarsawDengerousData.Services.DataModels;

namespace WarsawDengerousData.Services
{
    public static class WarsawDataSerializator
    {
        public static object FromJson(string json) => JsonConvert.DeserializeObject<WarsawData>(json, Settings);

        public static string ToJson(this WarsawData self) => JsonConvert.SerializeObject(self, Settings);

        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                CategoryConverter.Singleton,
                CityConverter.Singleton,
                DeviceTypeConverter.Singleton,
                DistrictConverter.Singleton,
                NotificationTypeConverter.Singleton,
                SourceConverter.Singleton,
                SubcategoryConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}