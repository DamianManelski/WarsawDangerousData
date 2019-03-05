using System.Net.Http;
using WarsawDengerousData.Services.DataModels;

namespace WarsawDengerousData.WarsawApi.Commands
{
    public class GetNotificationDataForDistrict : IWarsawApiMethod<WarsawData>
    {
        public HttpMethod Method => HttpMethod.Get;

        public string RequestUri { get; }

        public string DistrictName { get; set; }

        public GetNotificationDataForDistrict(string districtName, string resourceId)
        {
            DistrictName = districtName;

            RequestUri = $"19115store_getNotifications?id={resourceId}" +
                "&filters=%22filters%22%3A[{%22field%22%3A%22DISTRICT%22%2C%22" +
                "operator%22%3A%22EQ%22%2C%22value%22%3A%22" +
                $"{DistrictName}" +
                "%22}]&operators=%22operators%22%3Anull";
        }
    }
}