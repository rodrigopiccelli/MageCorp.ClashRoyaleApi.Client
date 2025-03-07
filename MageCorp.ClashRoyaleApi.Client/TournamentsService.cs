using MageCorp.ClashRoyaleApi.Client.Model;
using MageCorp.ClashRoyaleApi.Client.Interfaces;
using MageCorp.ClashRoyaleApi.Client.Abstract;
using System.Web;

namespace MageCorp.ClashRoyaleApi.Client;

internal class TournamentsService : ApiClient, ITournamentsService
{
    internal TournamentsService(HttpClient httpClient) : base(httpClient) { }

    public TournamentsService(IHttpClientFactory httpClientFactory) : base(httpClientFactory) { }

    public async Task<TournamentHeaderList> SearchAsync(string? name, int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<TournamentHeaderList>($"tournaments",
            new Dictionary<string, string?> { { "name", name } }
            .Concat(CreatePagingParameters(limit, after, before))
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value));

    public async Task<Tournament> GetTournamentAsync(string tournamentTag) =>
        await GetAsync<Tournament>($"tournaments/{HttpUtility.UrlEncode(tournamentTag)}");

    public TournamentHeaderList Search(string? name, int? limit = null, string? after = null, string? before = null) =>
        SearchAsync(name, limit, after, before).GetAwaiter().GetResult();

    public Tournament GetTournament(string tournamentTag) =>
        GetTournamentAsync(tournamentTag).GetAwaiter().GetResult();
}
