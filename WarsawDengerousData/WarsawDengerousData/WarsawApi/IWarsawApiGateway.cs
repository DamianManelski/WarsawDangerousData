using System;
using System.Threading.Tasks;

namespace WarsawDengerousData.WarsawApi
{
    public interface IWarsawApiGateway : IDisposable
    {
        Task<TResult> CallAsync<TResult>(IWarsawApiMethod<TResult> apiCall);
    }
}