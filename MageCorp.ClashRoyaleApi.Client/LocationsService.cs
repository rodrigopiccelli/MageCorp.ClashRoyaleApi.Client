using MageCorp.ClashRoyaleApi.Client.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model;
using MageCorp.ClashRoyaleApi.Client.Interfaces;

namespace MageCorp.ClashRoyaleApi.Client;

internal class LocationsService : ApiClient, ILocationsService
{
    internal LocationsService(HttpClient httpClient) : base(httpClient) { }

    public LocationsService(IHttpClientFactory httpClientFactory) : base(httpClientFactory) { }

    public async Task<ClanRankingList> ListClanRankingsAsync(int locationId, int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<ClanRankingList>($"locations/{locationId}/rankings/clans",
            CreatePagingParameters(limit, after, before));

    public async Task<PlayerRankingList> ListPlayerRankingsAsync(int locationId, int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<PlayerRankingList>($"locations/{locationId}/rankings/players",
            CreatePagingParameters(limit, after, before));

    public async Task<ClanRankingList> ListClanWarRankingsAsync(int locationId, int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<ClanRankingList>($"locations/{locationId}/rankings/clanwars",
            CreatePagingParameters(limit, after, before));

    public async Task<LeagueSeason> GetLeagueSeasonAsync(string seasonId) =>
        await GetAsync<LeagueSeason>($"locations/global/seasons/{seasonId}");

    public async Task<PlayerRankingList> ListSeasonPlayerRankingsAsync(string seasonId, int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<PlayerRankingList>($"locations/global/seasons/{seasonId}/rankings/players",
            CreatePagingParameters(limit, after, before));

    public async Task<LeagueSeasonList> ListLeagueSeasonsAsync() =>
        await GetAsync<LeagueSeasonList>($"locations/global/seasons");

    public async Task<LocationList> ListLocationsAsync(int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<LocationList>($"locations",
            CreatePagingParameters(limit, after, before));

    public async Task<Location> GetLocationAsync(int locationId) =>
        await GetAsync<Location>($"locations/{locationId}");

    public async Task<LadderTournamentRankingList> ListLadderTournamentRankingsAsync(string tournamentTag, int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<LadderTournamentRankingList>($"locations/global/rankings/tournaments/{tournamentTag}/",
            CreatePagingParameters(limit, after, before));

    public async Task<PlayerPathOfLegendRankingList> ListPlayerPathOfLegendRankingsAsync(string seasonId, int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<PlayerPathOfLegendRankingList>($"locations/global/pathoflegend/{seasonId}/rankings/players",
            CreatePagingParameters(limit, after, before));

    public async Task<PlayerPathOfLegendRankingList> ListPlayerPathOfLegendRankingsAsync(int locationId, int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<PlayerPathOfLegendRankingList>("locations/{locationId}/pathoflegend/players",
            CreatePagingParameters(limit, after, before));

    public ClanRankingList ListClanRankings(int locationId, int? limit = null, string? after = null, string? before = null) =>
        ListClanRankingsAsync(locationId, limit, after, before).GetAwaiter().GetResult();

    public PlayerRankingList ListPlayerRankings(int locationId, int? limit = null, string? after = null, string? before = null) =>
        ListPlayerRankingsAsync(locationId, limit, after, before).GetAwaiter().GetResult();

    public ClanRankingList ListClanWarRankings(int locationId, int? limit = null, string? after = null, string? before = null) =>
        ListClanWarRankingsAsync(locationId, limit, after, before).GetAwaiter().GetResult();

    public LeagueSeason GetLeagueSeason(string seasonId) =>
        GetLeagueSeasonAsync(seasonId).GetAwaiter().GetResult();

    public PlayerRankingList ListSeasonPlayerRankings(string seasonId, int? limit = null, string? after = null, string? before = null) =>
        ListSeasonPlayerRankingsAsync(seasonId, limit, after, before).GetAwaiter().GetResult();

    public LeagueSeasonList ListLeagueSeasons() =>
        ListLeagueSeasonsAsync().GetAwaiter().GetResult();

    public LocationList ListLocations(int? limit = null, string? after = null, string? before = null) =>
        ListLocationsAsync(limit, after, before).GetAwaiter().GetResult();

    public Location GetLocation(int locationId) =>
        GetLocationAsync(locationId).GetAwaiter().GetResult();

    public LadderTournamentRankingList ListLadderTournamentRankings(string tournamentTag, int? limit = null, string? after = null, string? before = null) =>
        ListLadderTournamentRankingsAsync(tournamentTag, limit, after, before).GetAwaiter().GetResult();

    public PlayerPathOfLegendRankingList ListPlayerPathOfLegendRankings(string seasonId, int? limit = null, string? after = null, string? before = null) =>
        ListPlayerPathOfLegendRankingsAsync(seasonId, limit, after, before).GetAwaiter().GetResult();

    public PlayerPathOfLegendRankingList ListPlayerPathOfLegendRankings(int locationId, int? limit = null, string? after = null, string? before = null) =>
        ListPlayerPathOfLegendRankingsAsync(locationId, limit, after, before).GetAwaiter().GetResult();
}
