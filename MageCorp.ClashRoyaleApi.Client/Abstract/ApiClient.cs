using MageCorp.ClashRoyaleApi.Client.Extensions;
using MageCorp.ClashRoyaleApi.Client.Interfaces;
using MageCorp.ClashRoyaleApi.Client.Model;
using System.Collections.Specialized;
using System.Net;
using System.Text.Json;

namespace MageCorp.ClashRoyaleApi.Client.Abstract;

internal abstract class ApiClient
{
    private readonly IHttpClientFactory? httpClientFactory;
    private readonly HttpClient? localHttpClient;
    private readonly JsonSerializerOptions jsonSerializerOptions;

    protected ApiClient(IHttpClientFactory httpClientFactory)
    {
        this.httpClientFactory = httpClientFactory;
        jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };
    }

    private protected ApiClient(HttpClient httpClient)
    {
        localHttpClient = httpClient;
        jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };
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

            if (parameters != null && parameters.Count > 0)
                requestUri = $"{requestUri}?{parameters}";

            if (httpClient != null)
            {
                var response = await httpClient.GetAsync(requestUri).ConfigureAwait(false);
                var message = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                if (response.StatusCode == HttpStatusCode.OK)
                    result = JsonSerializer.Deserialize<T>(message, jsonSerializerOptions);
                else if(message != string.Empty)
                    result.Error = JsonSerializer.Deserialize<ClientError>(message, jsonSerializerOptions);

                result!.HttpStatusCode = response.StatusCode;
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
