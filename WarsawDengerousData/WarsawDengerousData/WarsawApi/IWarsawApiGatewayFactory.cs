namespace WarsawDengerousData.WarsawApi
{
    public interface IWarsawApiGatewayFactory
    {
        IWarsawApiGateway Create();

        IWarsawApiGateway Create(string apiKey);
    }
}