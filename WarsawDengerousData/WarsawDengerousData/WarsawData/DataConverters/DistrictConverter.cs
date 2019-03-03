using Newtonsoft.Json;
using System;
using static WarsawDengerousData.Services.DataModels.Enums;

namespace WarsawDengerousData.Services.DataConverters
{
    internal class DistrictConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(District) || t == typeof(District?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            var value = serializer.Deserialize<string>(reader);
            if (value == "Wola")
            {
                return District.Wola;
            }
            throw new Exception("Cannot unmarshal type District");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (District)untypedValue;
            if (value == District.Wola)
            {
                serializer.Serialize(writer, "Wola");
                return;
            }
            throw new Exception("Cannot marshal type District");
        }

        public static readonly DistrictConverter Singleton = new DistrictConverter();
    }
}