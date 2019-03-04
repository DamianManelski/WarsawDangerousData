namespace WarsawDengerousData.WarsawApi
{
    public class WarsawApiGatewayFactory : IWarsawApiGatewayFactory
    {
        private readonly string _baseUrl;
        private readonly string _apiKey;
        private readonly string _resourceId;

        public WarsawApiGatewayFactory(string baseUrl, string apiKey, string resourceId)
        {
            _baseUrl = baseUrl;
            _apiKey = apiKey;
            _resourceId = resourceId;
        }

        public IWarsawApiGateway Create()
        {
            return new WarsawApiGateway(_baseUrl, _apiKey, _resourceId);
        }
    }
}