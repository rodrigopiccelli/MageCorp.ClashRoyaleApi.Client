using MageCorp.ClashRoyaleApi.Client.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model;
using MageCorp.ClashRoyaleApi.Client.Interfaces;

namespace MageCorp.ClashRoyaleApi.Client;

internal class CardsService : ApiClient, ICardsService
{
    internal CardsService(HttpClient httpClient) : base(httpClient) { }

    public CardsService(IHttpClientFactory httpClientFactory) : base(httpClientFactory) { }

    public async Task<CardList> ListAsync(int? limit = null, string? after = null, string? before = null) => 
        await GetAsync<CardList>($"cards",
            CreatePagingParameters(limit, after, before));
}
