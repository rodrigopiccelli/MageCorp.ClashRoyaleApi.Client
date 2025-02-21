using System.Net.Http.Headers;

namespace MageCorp.ClashRoyaleApi.Client.Extensions
{
    internal static class HttpClientExtensions
    {
        internal static void ConfigureClashRoyaleApiOptions(this HttpClient httpClient, ClashRoyaleApiOptions clashRoyaleApiOptions)
        {
            ArgumentNullException.ThrowIfNull(clashRoyaleApiOptions);
            ArgumentException.ThrowIfNullOrEmpty(clashRoyaleApiOptions.ApiVersion);

            if (clashRoyaleApiOptions.UseProxy)
            {
                ArgumentException.ThrowIfNullOrEmpty(clashRoyaleApiOptions.ProxyAddress);
                httpClient.BaseAddress = new Uri($"{clashRoyaleApiOptions.ProxyAddress}/{clashRoyaleApiOptions.ApiVersion}/");
            }
            else
            {
                ArgumentException.ThrowIfNullOrEmpty(clashRoyaleApiOptions.ApiAddress);
                httpClient.BaseAddress = new Uri($"{clashRoyaleApiOptions.ApiAddress}/{clashRoyaleApiOptions.ApiVersion}/");
            }

            var apiToken = clashRoyaleApiOptions.BearerToken?.Replace("Bearer", "").Replace(" ", "").Trim();
            ArgumentException.ThrowIfNullOrEmpty(apiToken?.Trim());
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiToken);
        }
    }
}
