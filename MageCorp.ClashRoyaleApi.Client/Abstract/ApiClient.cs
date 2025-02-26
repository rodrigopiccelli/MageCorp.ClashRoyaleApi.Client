﻿using MageCorp.ClashRoyaleApi.Client.Interfaces;
using MageCorp.ClashRoyaleApi.Client.Model;
using System.Net;
using System.Text.Json;
using System.Web;

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

    public async Task<T> GetAsync<T>(string requestUri) 
        where T : class, IApiResponse, new() =>
            await GetAsync<T>(requestUri, null);

    public async Task<T> GetAsync<T>(string requestUri, Dictionary<string, string?>? parameters)
        where T : class, IApiResponse, new()
    {
        using var diHttpClient = httpClientFactory?.CreateClient("ClashRoyaleApiClient");
        var httpClient = diHttpClient ?? localHttpClient;

        T? result = new();

        try
        {
            if (parameters != null && parameters.Count > 0)
                requestUri = $"{requestUri}?{GetQueryString(parameters)}";

            if (httpClient != null)
            {
                var response = await httpClient.GetAsync(requestUri).ConfigureAwait(false);
                var message = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                if (response.StatusCode == HttpStatusCode.OK)
                    result = JsonSerializer.Deserialize<T>(message, jsonSerializerOptions) ?? new();
                else if(message != string.Empty)
                    result.Error = JsonSerializer.Deserialize<ClientError>(message, jsonSerializerOptions);

                result.HttpStatusCode = response.StatusCode;
            }
        }
        catch (Exception ex)
        {
            result.Error = new ClientError { Message = ex.Message, Type = ex.GetType().Name, Detail = ex, Reason = ex.StackTrace };
        }

        return result;
    }

    protected static Dictionary<string, string?> CreatePagingParameters(int? limit, string? after, string? before) =>
        new() { { "limit", limit?.ToString() }, { "after", after }, { "before", before } };

    private static string GetQueryString(Dictionary<string, string?> parameters) =>
        string.Join("&", parameters
            .Where(p => p.Value != null)
            .Select(a => $"{HttpUtility.UrlDecode(a.Key)}={HttpUtility.UrlEncode(a.Value)}"));
}
