using Newtonsoft.Json;
using System;
using static WarsawDengerousData.Services.DataModels.Enums;

namespace WarsawDengerousData.Services.DataConverters
{
    internal class CategoryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Category) || t == typeof(Category?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Infrastruktura":
                    return Category.Infrastruktura;

                case "Inne":
                    return Category.Inne;

                case "Porządek":
                    return Category.Porządek;

                case "Proces Interwencyjny":
                    return Category.ProcesInterwencyjny;
            }
            throw new Exception("Cannot unmarshal type Category");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Category)untypedValue;
            switch (value)
            {
                case Category.Infrastruktura:
                    serializer.Serialize(writer, "Infrastruktura");
                    return;

                case Category.Inne:
                    serializer.Serialize(writer, "Inne");
                    return;

                case Category.Porządek:
                    serializer.Serialize(writer, "Porządek");
                    return;

                case Category.ProcesInterwencyjny:
                    serializer.Serialize(writer, "Proces Interwencyjny");
                    return;
            }
            throw new Exception("Cannot marshal type Category");
        }

        public static readonly CategoryConverter Singleton = new CategoryConverter();
    }
}