using MageCorp.ClashRoyaleApi.Client.Model;
using MageCorp.ClashRoyaleApi.Client.Interfaces;
using System.Collections.Specialized;
using MageCorp.ClashRoyaleApi.Client.Abstract;
using System.Web;

namespace MageCorp.ClashRoyaleApi.Client;

internal class TournamentsService : ApiClient, ITournamentsService
{
    internal TournamentsService(HttpClient httpClient) : base(httpClient) { }

    public TournamentsService(IHttpClientFactory httpClientFactory) : base(httpClientFactory) { }

    public async Task<TournamentHeaderList?> SearchAsync(string? name, int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<TournamentHeaderList>($"tournaments",
            new NameValueCollection { { "name", name }, { "limit", limit?.ToString() }, { "after", after }, { "before", before } });

    public async Task<Tournament?> GetTournamentAsync(string tournamentTag) =>
        await GetAsync<Tournament>($"tournaments/{HttpUtility.UrlEncode(tournamentTag)}");
}
