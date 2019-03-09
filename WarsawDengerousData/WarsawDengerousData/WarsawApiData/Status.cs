using Newtonsoft.Json;
using System.Text;
using WarsawDengerousData.Helpers;

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

        public static string GetStatusesAsString(Status[] statuses)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var status in statuses)
            {
                sb.AppendLine($"Status:{status.StatusStatus}, " +
                    $"Description:{status.Description}, " +
                    $"ChangeDate: {DateTimeHelper.GetUtcTime(status.ChangeDate)}");
            }
            return sb.ToString();
        }
    }
}