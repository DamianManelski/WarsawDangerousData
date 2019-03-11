using Newtonsoft.Json;

namespace WarsawDengerousData.WarsawApiData
{
    public class Status
    {
        [JsonProperty("status")]
        public string StatusStatus { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("changeDate")]
        public long ChangeDate { get; set; }
    }
}