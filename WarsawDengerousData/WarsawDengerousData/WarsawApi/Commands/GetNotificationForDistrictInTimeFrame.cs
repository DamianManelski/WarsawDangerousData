using System;
using System.Net.Http;
using WarsawDengerousData.Services.DataModels;

namespace WarsawDengerousData.WarsawApi.Commands
{
    public class GetNotificationForDistrictInTimeFrame : IWarsawApiMethod<WarsawData>
    {
        public HttpMethod Method => HttpMethod.Get;

        public string RequestUri { get; }

        public string DistrictName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        private const string DateTimeFormat = "yyyy-MM-ddThh:mm:ss";

        public GetNotificationForDistrictInTimeFrame(
            string districtName,
            DateTime startDate,
            DateTime endDate)
        {
            DistrictName = districtName;
            StartDate = startDate;
            EndDate = endDate;

            RequestUri = "19115store_getNotifications?id=28dc65ad-fff5-447b-99a3-95b71b4a7d1e&filters=%22filters%22%3A[{%22field%22%3A%22DISTRICT%22%2C%22operator%22%3A%22EQ%22%2C%22value%22%3A%22" +
                $"{DistrictName}" +
                "%22}]&operators=%22operators%22%3Anull";
        }
    }
}