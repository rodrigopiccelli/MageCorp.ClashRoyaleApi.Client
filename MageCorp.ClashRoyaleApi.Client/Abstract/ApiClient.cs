using MageCorp.ClashRoyaleApi.Client.Model;
using MageCorp.ClashRoyaleApi.Client.Interfaces;
using Newtonsoft.Json;
using System.Net;
using System.Collections.Specialized;
using MageCorp.ClashRoyaleApi.Client.Extensions;

namespace MageCorp.ClashRoyaleApi.Client.Abstract;

internal abstract class ApiClient
{
    private readonly IHttpClientFactory? httpClientFactory;
    private readonly HttpClient? localHttpClient;

    public ApiClient(IHttpClientFactory httpClientFactory)
    {
        this.httpClientFactory = httpClientFactory;
    }

    internal ApiClient(HttpClient httpClient)
    {
        localHttpClient = httpClient;
    }

    public async Task<T?> GetAsync<T>(string requestUri) where T : IApiResponse =>
        await GetAsync<T>(requestUri, null);

    public async Task<T?> GetAsync<T>(string requestUri, NameValueCollection? parameters)
        where T : IApiResponse
    {
        using var diHttpClient = httpClientFactory?.CreateClient("ClashRoyaleApi");
        var httpClient = diHttpClient ?? localHttpClient;

        T? result = Activator.CreateInstance<T>();

        try
        {
            parameters = parameters?.ConvertToHttpValueColletion();
            
            if(parameters != null && parameters.Count > 0)
                requestUri = $"{requestUri}?{parameters}";

            if (httpClient != null)
            {
                var response = await httpClient.GetAsync(requestUri);
                var message = await response.Content.ReadAsStringAsync();

                result.HttpStatusCode = response.StatusCode;

                if (result.HttpStatusCode == HttpStatusCode.OK)
                    result = JsonConvert.DeserializeObject<T>(message);
                else
                    result.Error = JsonConvert.DeserializeObject<ClientError>(message);
            }

            return result;
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message);
            throw;
        }
    }
}
