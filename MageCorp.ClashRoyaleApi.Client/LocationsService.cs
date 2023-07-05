using MageCorp.ClashRoyaleApi.Client.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model;
using MageCorp.ClashRoyaleApi.Client.Interfaces;
using System.Collections.Specialized;

namespace MageCorp.ClashRoyaleApi.Client;

internal class LocationsService : ApiClient, ILocationsService
{
    internal LocationsService(HttpClient httpClient) : base(httpClient) { }

    public LocationsService(IHttpClientFactory httpClientFactory) : base(httpClientFactory) { }

    public async Task<ClanRankingList?> ListClanRankingsAsync(int locationId, int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<ClanRankingList>($"locations/{locationId}/rankings/clans",
            new NameValueCollection { { "limit", limit?.ToString() }, { "after", after }, { "before", before } });

    public async Task<PlayerRankingList?> ListPlayerRankingsAsync(int locationId, int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<PlayerRankingList>($"locations/{locationId}/rankings/players",
            new NameValueCollection { { "limit", limit?.ToString() }, { "after", after }, { "before", before } });

    public async Task<ClanRankingList?> ListClanWarRankingsAsync(int locationId, int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<ClanRankingList>($"locations/{locationId}/rankings/clanwars",
            new NameValueCollection { { "limit", limit?.ToString() }, { "after", after }, { "before", before } });

    public async Task<LeagueSeason?> GetLeagueSeasonAsync(string seasonId) =>
        await GetAsync<LeagueSeason>($"locations/global/seasons{seasonId}");

    public async Task<PlayerRankingList?> ListSeasonPlayerRankingsAsync(string seasonId, int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<PlayerRankingList>($"locations/global/seasons/{seasonId}/rankings/players",
            new NameValueCollection { { "limit", limit?.ToString() }, { "after", after }, { "before", before } });

    public async Task<LeagueSeasonList?> ListLeagueSeasonsAsync() =>
        await GetAsync<LeagueSeasonList>($"locations/global/seasons");

    public async Task<LocationList?> ListLocationsAsync(int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<LocationList>($"locations",
            new NameValueCollection { { "limit", limit?.ToString() }, { "after", after }, { "before", before } });

    public async Task<Location?> GetLocationAsync(int locationId) =>
        await GetAsync<Location>($"locations/{locationId}");

    public async Task<LadderTournamentRankingList?> ListLadderTournamentRankingsAsync(string tournamentTag, int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<LadderTournamentRankingList>($"locations/global/rankings/tournaments/{tournamentTag}/",
            new NameValueCollection { { "limit", limit?.ToString() }, { "after", after }, { "before", before } });

    public async Task<PlayerPathOfLegendRankingList?> ListPlayerPathOfLegendRankingsAsync(string seasonId, int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<PlayerPathOfLegendRankingList>($"locations/global/pathoflegend/{seasonId}/rankings/players",
            new NameValueCollection { { "limit", limit?.ToString() }, { "after", after }, { "before", before } });

    public async Task<PlayerPathOfLegendRankingList?> ListPlayerPathOfLegendRankings(int locationId, int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<PlayerPathOfLegendRankingList>("locations/{locationId}/pathoflegend/players",
            new NameValueCollection { { "limit", limit?.ToString() }, { "after", after }, { "before", before } });
}
