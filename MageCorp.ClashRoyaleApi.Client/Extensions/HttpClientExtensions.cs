using System.Net.Http.Headers;

namespace MageCorp.ClashRoyaleApi.Client.Extensions
{
    internal static class HttpClientExtensions
    {
        internal static void ConfigureApiOptions(this HttpClient httpClient, ApiOptions apiOptions)
        {
            ArgumentNullException.ThrowIfNull(apiOptions);
            ArgumentException.ThrowIfNullOrEmpty(apiOptions.ApiVersion);

            if (apiOptions.UseProxy)
            {
                ArgumentException.ThrowIfNullOrEmpty(apiOptions.ProxyAddress);
                httpClient.BaseAddress = new Uri($"{apiOptions.ProxyAddress}/{apiOptions.ApiVersion}/");
            }
            else
            {
                ArgumentException.ThrowIfNullOrEmpty(apiOptions.ApiAddress);
                httpClient.BaseAddress = new Uri($"{apiOptions.ApiAddress}/{apiOptions.ApiVersion}/");
            }

            var apiToken = apiOptions.BearerToken?.Replace("Bearer", "").Replace(" ", "").Trim();
            ArgumentException.ThrowIfNullOrEmpty(apiToken?.Trim());
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiToken);
        }
    }
}
