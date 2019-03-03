using Newtonsoft.Json;
using System;
using static WarsawDengerousData.Services.DataModels.Enums;

namespace WarsawDengerousData.Services.DataConverters
{
    internal class CityConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(City) || t == typeof(City?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            var value = serializer.Deserialize<string>(reader);
            if (value == "Warszawa")
            {
                return City.Warszawa;
            }
            throw new Exception("Cannot unmarshal type City");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (City)untypedValue;
            if (value == City.Warszawa)
            {
                serializer.Serialize(writer, "Warszawa");
                return;
            }
            throw new Exception("Cannot marshal type City");
        }

        public static readonly CityConverter Singleton = new CityConverter();
    }
}