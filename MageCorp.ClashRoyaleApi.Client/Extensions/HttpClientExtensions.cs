using System.Net.Http.Headers;

namespace MageCorp.ClashRoyaleApi.Client.Extensions
{
    internal static class HttpClientExtensions
    {
        internal static void ConfigureApiOptions(this HttpClient httpClient, ApiOptions apiOptions)
        {
            if(string.IsNullOrEmpty(apiOptions.ApiVersion))
                throw new ArgumentException(nameof(apiOptions.ApiVersion));

            if (apiOptions.UseProxy)
            {
                if(string.IsNullOrEmpty(apiOptions.ProxyAddress))
                    throw new ArgumentException(nameof(apiOptions.ProxyAddress));
                httpClient.BaseAddress = new Uri($"{apiOptions.ProxyAddress}/{apiOptions.ApiVersion}/");
            }
            else
            {
                if (string.IsNullOrEmpty(apiOptions.ApiAddress))
                    throw new ArgumentException(nameof(apiOptions.ApiAddress));
                httpClient.BaseAddress = new Uri($"{apiOptions.ApiAddress}/{apiOptions.ApiVersion}/");
            }

            var apiToken = apiOptions.BearerToken?.Replace("Bearer", "").Replace(" ", "").Trim();
            if (string.IsNullOrEmpty(apiToken?.Trim()))
                throw new ArgumentException(nameof(apiOptions.BearerToken));
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiToken);
        }
    }
}
