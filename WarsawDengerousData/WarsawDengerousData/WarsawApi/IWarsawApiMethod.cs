using System.Net.Http;

namespace WarsawDengerousData.WarsawApi
{
    public interface IWarsawApiMethod
    {
    }

    public interface IWarsawApiMethod<Tresult> : IWarsawApiMethod
    {
        HttpMethod Method { get; }

        string RequestUri { get; }
    }
}