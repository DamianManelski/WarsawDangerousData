using System.Threading.Tasks;
using WarsawDengerousData.Services.DataModels;
using WarsawDengerousData.WarsawApi;
using WarsawDengerousData.WarsawApi.Commands;

namespace WarsawDengerousData.Services
{
    public class WarsawDataService : IWarsawDataService
    {
        private readonly IWarsawApiGatewayFactory _apiGatewayFactory;

        public WarsawDataService(IWarsawApiGatewayFactory apiGatewayFactory)
        {
            _apiGatewayFactory = apiGatewayFactory;
        }

        public async Task<WarsawData> GetIncydentForAsync(string districtName, string resourceId)
        {
            using (var apiGateway = _apiGatewayFactory.Create())
            {
                return await apiGateway.CallAsync(new GetNotificationDataForDistrict(districtName, resourceId));
            }
        }
    }
}