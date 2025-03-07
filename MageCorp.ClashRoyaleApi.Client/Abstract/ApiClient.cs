using MageCorp.ClashRoyaleApi.Client.Interfaces;
using MageCorp.ClashRoyaleApi.Client.Model;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using System.Web;

namespace MageCorp.ClashRoyaleApi.Client.Abstract;

internal abstract class ApiClient
{
    private readonly IHttpClientFactory? httpClientFactory;
    private readonly HttpClient? localHttpClient;
    private readonly JsonSerializerOptions jsonSerializerOptions = new() { PropertyNameCaseInsensitive = true, };

    protected ApiClient(IHttpClientFactory httpClientFactory)
    {
        this.httpClientFactory = httpClientFactory;
    }

    private protected ApiClient(HttpClient httpClient)
    {
        localHttpClient = httpClient;
    }

    public async Task<T> GetAsync<T>(string requestUri)
        where T : class, IApiResponse, new() =>
            await GetAsync<T>(requestUri, null);

    public async Task<T> GetAsync<T>(string requestUri, Dictionary<string, string?>? parameters)
        where T : class, IApiResponse, new()
    {
        T? result = new();
        requestUri = BuildRequestUri(requestUri, parameters);

        try
        {
            using var diHttpClient = httpClientFactory?.CreateClient("ClashRoyaleApiClient");
            var httpClient = diHttpClient ?? localHttpClient;

            if (httpClient != null)
            {
                var response = await httpClient.GetAsync(requestUri).ConfigureAwait(false);

                if (response.StatusCode == HttpStatusCode.OK)
                    result = await response.Content.ReadFromJsonAsync<T>(jsonSerializerOptions) ?? new();
                else
                    result.Error = await response.Content.ReadFromJsonAsync<ClientError>(jsonSerializerOptions);

                result.HttpStatusCode = response.StatusCode;
            }
        }
        catch (Exception ex)
        {
            result.Error = new ClientError
            {
                Message = ex.Message,
                Type = ex.GetType().Name,
                Detail = ex,
                Reason = ex.StackTrace
            };
        }

        return result;
    }

    private static string BuildRequestUri(string requestUri, Dictionary<string, string?>? parameters)
    {
        if (parameters != null && parameters.Count > 0)
            requestUri = $"{requestUri}?{GetQueryString(parameters)}";

        return requestUri;
    }

    protected static Dictionary<string, string?> CreatePagingParameters(int? limit, string? after, string? before) =>
        new() { { "limit", limit?.ToString() }, { "after", after }, { "before", before } };

    private static string GetQueryString(Dictionary<string, string?> parameters) =>
        string.Join("&", parameters
            .Where(p => p.Value != null)
            .Select(a => $"{HttpUtility.UrlEncode(a.Key)}={HttpUtility.UrlEncode(a.Value)}"));
}
