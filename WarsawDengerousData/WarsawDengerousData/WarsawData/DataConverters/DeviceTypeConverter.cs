using Newtonsoft.Json;
using System;
using static WarsawDengerousData.Services.DataModels.Enums;

namespace WarsawDengerousData.Services.DataConverters
{
    internal class DeviceTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DeviceType) || t == typeof(DeviceType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            var value = serializer.Deserialize<string>(reader);
            if (value == "UNKNOWN")
            {
                return DeviceType.Unknown;
            }
            throw new Exception("Cannot unmarshal type DeviceType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (DeviceType)untypedValue;
            if (value == DeviceType.Unknown)
            {
                serializer.Serialize(writer, "UNKNOWN");
                return;
            }
            throw new Exception("Cannot marshal type DeviceType");
        }

        public static readonly DeviceTypeConverter Singleton = new DeviceTypeConverter();
    }
}