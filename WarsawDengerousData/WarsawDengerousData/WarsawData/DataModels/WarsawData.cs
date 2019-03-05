using Newtonsoft.Json;
using static WarsawDengerousData.Services.DataModels.Enums;

namespace WarsawDengerousData.Services.DataModels
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
        public Category Category { get; set; }

        [JsonProperty("city")]
        public City? City { get; set; }

        [JsonProperty("subcategory")]
        public Subcategory Subcategory { get; set; }

        [JsonProperty("district")]
        public District District { get; set; }

        [JsonProperty("aparmentNumber")]
        public object AparmentNumber { get; set; }

        [JsonProperty("street2")]
        public string Street2 { get; set; }

        [JsonProperty("notificationType")]
        public NotificationType NotificationType { get; set; }

        [JsonProperty("createDate")]
        public long CreateDate { get; set; }

        [JsonProperty("siebelEventId")]
        public string SiebelEventId { get; set; }

        [JsonProperty("source")]
        public Source Source { get; set; }

        [JsonProperty("yCoordOracle")]
        public double YCoordOracle { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("deviceType")]
        public DeviceType DeviceType { get; set; }

        [JsonProperty("statuses")]
        public Status[] Statuses { get; set; }

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

    public partial class Status
    {
        [JsonProperty("status")]
        public string StatusStatus { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("changeDate")]
        public long ChangeDate { get; set; }
    }
}