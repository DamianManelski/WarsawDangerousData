using Newtonsoft.Json;
using System;
using static WarsawDengerousData.Services.DataModels.Enums;

namespace WarsawDengerousData.Services.DataConverters
{
    internal class NotificationTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(NotificationType) || t == typeof(NotificationType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "COMPLAINT":
                    return NotificationType.Complaint;

                case "INCIDENT":
                    return NotificationType.Incident;
            }
            throw new Exception("Cannot unmarshal type NotificationType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (NotificationType)untypedValue;
            switch (value)
            {
                case NotificationType.Complaint:
                    serializer.Serialize(writer, "COMPLAINT");
                    return;

                case NotificationType.Incident:
                    serializer.Serialize(writer, "INCIDENT");
                    return;
            }
            throw new Exception("Cannot marshal type NotificationType");
        }

        public static readonly NotificationTypeConverter Singleton = new NotificationTypeConverter();
    }
}