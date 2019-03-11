using Newtonsoft.Json;
using WarsawDengerousData.Helpers;

namespace WarsawDengerousData.WarsawApiData
{
    public partial class WarsawData
    {
        [JsonProperty("result")]
        public WarsawDataResult Result { get; set; }
    }

    public partial class WarsawDataResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("result")]
        public ResultResult Result { get; set; }
    }

    public partial class ResultResult
    {
        [JsonProperty("notifications")]
        public Notification[] Notifications { get; set; }

        [JsonProperty("responseDesc")]
        public string ResponseDesc { get; set; }

        [JsonProperty("responseCode")]
        public string ResponseCode { get; set; }
    }

    public partial class Notification
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("aparmentNumber")]
        public object AparmentNumber { get; set; }

        [JsonProperty("street2")]
        public string Street2 { get; set; }

        [JsonProperty("notificationType")]
        public string NotificationType { get; set; }

        [JsonProperty("createDate")]
        public long CreateDate { get; set; }

        public string CreateDateFormatted => DateTimeHelper.GetUtcTime(CreateDate);

        [JsonProperty("siebelEventId")]
        public string SiebelEventId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("yCoordOracle")]
        public double YCoordOracle { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("deviceType")]
        public string DeviceType { get; set; }

        [JsonProperty("statuses")]
        public Status[] Statuses { get; set; }

        public string StatusesFormatted => StatusHelper.GetStatusesAsString(Statuses);

        [JsonProperty("xCoordOracle")]
        public double XCoordOracle { get; set; }

        [JsonProperty("notificationNumber")]
        public string NotificationNumber { get; set; }

        [JsonProperty("yCoordWGS84")]
        public long YCoordWgs84 { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("xCoordWGS84")]
        public long XCoordWgs84 { get; set; }
    }
}