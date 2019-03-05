using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WarsawDengerousData.Exceptions;
using WarsawDengerousData.Services;

namespace WarsawDengerousData.WarsawApi
{
    public class WarsawApiGateway : IWarsawApiGateway
    {
        private string _apiKey;

        public string BaseUrl { get; }

        private readonly string _resourceId;

        public WarsawApiGateway(string baseUrl, string apiKey, string resourceId)
        {
            _apiKey = apiKey;
            BaseUrl = baseUrl;
            _resourceId = resourceId;
        }

        public async Task<TResult> CallAsync<TResult>(IWarsawApiMethod<TResult> apiCall)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(BaseUrl);
                    var httpRequest = CreateHttpRequestMessage(apiCall);
                    var httpResponse = await client.SendAsync(httpRequest);
                    AssertHasSuccessStatusCode(httpResponse, apiCall);

                    var responseContents = await httpResponse.Content.ReadAsStringAsync();
                    if (responseContents != null)
                    {
                        return (TResult)WarsawDataSerializator.FromJson(responseContents);
                    }

                    return default(TResult);
                }
            }
            catch (OperationCanceledException operationCanceledException)
            {
                throw new WarsawDataApiException($"Call to {apiCall.RequestUri} was cancelled.", operationCanceledException);
            }
        }

        private void AssertHasSuccessStatusCode(HttpResponseMessage httpResponseMessage, IWarsawApiMethod apiCall)
        {
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                return;
            }
            //TODO: throw more reasonable exception here:

            throw new Exception("Something is wrong");
        }

        private HttpRequestMessage CreateHttpRequestMessage<TResult>(IWarsawApiMethod<TResult> apiCall)
        {
            var httpRequestMessage = new HttpRequestMessage
            {
                Method = apiCall.Method
            };

            httpRequestMessage.RequestUri = new Uri(apiCall.RequestUri + "&apikey=" + _apiKey, UriKind.Relative);

            var apiMethodRequestContent = apiCall as IWarsawApiMethodBodyContent;
            if (apiMethodRequestContent?.BodyContent != null)
            {
                var serializedBody = JsonConvert.SerializeObject(apiMethodRequestContent.BodyContent);
                httpRequestMessage.Content = new StringContent(serializedBody, Encoding.UTF8, "application/json");
            }

            return httpRequestMessage;
        }

        public void Dispose()
        {
            _apiKey = null;
        }
    }
}