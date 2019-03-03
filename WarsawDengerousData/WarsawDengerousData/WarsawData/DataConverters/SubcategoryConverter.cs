using Newtonsoft.Json;
using System;
using static WarsawDengerousData.Services.DataModels.Enums;

namespace WarsawDengerousData.Services.DataConverters
{
    internal class SubcategoryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Subcategory) || t == typeof(Subcategory?);

        public override object ReadJson(JsonReader reader, Type t, object existingVaslue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Inne":
                    return Subcategory.Inne;

                case "Komunikacja/Transport":
                    return Subcategory.KomunikacjaTransport;

                case "Śmieci":
                    return Subcategory.Śmieci;
            }
            throw new Exception("Cannot unmarshal type Subcategory");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Subcategory)untypedValue;
            switch (value)
            {
                case Subcategory.Inne:
                    serializer.Serialize(writer, "Inne");
                    return;

                case Subcategory.KomunikacjaTransport:
                    serializer.Serialize(writer, "Komunikacja/Transport");
                    return;

                case Subcategory.Śmieci:
                    serializer.Serialize(writer, "Śmieci");
                    return;
            }
            throw new Exception("Cannot marshal type Subcategory");
        }

        public static readonly SubcategoryConverter Singleton = new SubcategoryConverter();
    }
}