using System.Threading.Tasks;
using WarsawDengerousData.Models;
using WarsawDengerousData.WarsawApi;
using WarsawDengerousData.WarsawApi.Commands;
using WarsawDengerousData.WarsawApiData;

namespace WarsawDengerousData.Services
{
    public class WarsawDataService : IWarsawDataService
    {
        private readonly IWarsawApiGatewayFactory _apiGatewayFactory;

        public WarsawDataService(IWarsawApiGatewayFactory apiGatewayFactory)
        {
            _apiGatewayFactory = apiGatewayFactory;
        }

        public async Task<WarsawData> GetIncydentForAsync(UserData userData, string resourceId)
        {
            using (var apiGateway = _apiGatewayFactory.Create(userData.ApiKey))
            {
                return await apiGateway.CallAsync(new GetNotificationDataForDistrict(userData.DistrictName, resourceId));
            }
        }
    }
}