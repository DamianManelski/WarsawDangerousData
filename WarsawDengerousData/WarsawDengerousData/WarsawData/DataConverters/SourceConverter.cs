using Newtonsoft.Json;
using System;
using static WarsawDengerousData.Services.DataModels.Enums;

namespace WarsawDengerousData.Services.DataConverters
{
    internal class SourceConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Source) || t == typeof(Source?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CALL":
                    return Source.Call;

                case "CKM":
                    return Source.Ckm;

                case "PORTAL":
                    return Source.Portal;
            }
            throw new Exception("Cannot unmarshal type Source");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Source)untypedValue;
            switch (value)
            {
                case Source.Call:
                    serializer.Serialize(writer, "CALL");
                    return;

                case Source.Ckm:
                    serializer.Serialize(writer, "CKM");
                    return;

                case Source.Portal:
                    serializer.Serialize(writer, "PORTAL");
                    return;
            }
            throw new Exception("Cannot marshal type Source");
        }

        public static readonly SourceConverter Singleton = new SourceConverter();
    }
}