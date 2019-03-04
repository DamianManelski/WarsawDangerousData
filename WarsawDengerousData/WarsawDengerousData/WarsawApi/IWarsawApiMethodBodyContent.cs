namespace WarsawDengerousData.WarsawApi
{
    public interface IWarsawApiMethodBodyContent : IWarsawApiMethod
    {
        object BodyContent { get; }
    }
}