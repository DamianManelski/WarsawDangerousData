using System.Text;
using WarsawDengerousData.WarsawApiData;

namespace WarsawDengerousData.Helpers
{
    public class StatusHelper
    {
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