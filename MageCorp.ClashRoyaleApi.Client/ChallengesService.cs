using MageCorp.ClashRoyaleApi.Client.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model;
using MageCorp.ClashRoyaleApi.Client.Interfaces;

namespace MageCorp.ClashRoyaleApi.Client;

internal class ChallengesService : ApiClient, IChallengesService
{
    internal ChallengesService(HttpClient httpClient) : base(httpClient) { }

    public ChallengesService(IHttpClientFactory httpClientFactory) : base(httpClientFactory) { }

    public async Task<ChallengeChainsList?> ListChallengesAsync() => 
        await GetAsync<ChallengeChainsList>($"challenges");
}
