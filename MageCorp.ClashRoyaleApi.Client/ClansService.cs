using MageCorp.ClashRoyaleApi.Client.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model;
using MageCorp.ClashRoyaleApi.Client.Interfaces;
using System.Web;

namespace MageCorp.ClashRoyaleApi.Client;

internal class ClansService : ApiClient, IClansService
{
    internal ClansService(HttpClient httpClient) : base(httpClient) { }

    public ClansService(IHttpClientFactory httpClientFactory) : base(httpClientFactory) { }

    public async Task<ClanWarLog> ListWarlogAsync(string clanTag, int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<ClanWarLog>($"clans/{HttpUtility.UrlEncode(clanTag)}/warlog",
            CreatePagingParameters(limit, after, before));

    public async Task<ClanList> SearchAsync(
        string? name = null, 
        int? locationId = null, 
        int? minMembers = null, 
        int? maxMambers = null, 
        int? minScore = null, 
        int? limit = null, 
        string? after = null, 
        string? before = null) => 
            await GetAsync<ClanList>($"clans",
                new Dictionary<string, string?> {
                    { "name", name },
                    { "locationId", locationId?.ToString() },
                    { "minMembers", minMembers?.ToString() },
                    { "maxMambers", maxMambers?.ToString() },
                    { "minScore", minScore?.ToString() } }
                .Concat(CreatePagingParameters(limit, after, before))
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value));

    public async Task<RiverRaceLog> ListRiverRaceLogAsync(string clanTag, int? limit = null, string? after = null, string? before = null) => 
        await GetAsync<RiverRaceLog>($"clans/{HttpUtility.UrlEncode(clanTag)}/riverracelog", 
            CreatePagingParameters(limit, after, before));

    public async Task<CurrentClanWar> GetCurrentWarAsync(string clanTag) =>
        await GetAsync<CurrentClanWar>($"clans/{HttpUtility.UrlEncode(clanTag)}/currentwar");

    public async Task<Clan> GetAsync(string clanTag) =>
        await GetAsync<Clan>($"clans/{HttpUtility.UrlEncode(clanTag)}");

    public async Task<ClanMemberList> ListMembersAsync(string clanTag, int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<ClanMemberList>($"clans/{HttpUtility.UrlEncode(clanTag)}/members",
            CreatePagingParameters(limit, after, before));

    public async Task<CurrentRiverRace> GetCurrentRiverRaceAsync(string clanTag) =>
        await GetAsync<CurrentRiverRace>($"clans/{HttpUtility.UrlEncode(clanTag)}/currentriverrace");

    public ClanWarLog ListWarlog(string clanTag, int? limit = null, string? after = null, string? before = null) =>
        ListWarlogAsync(clanTag, limit, after, before).GetAwaiter().GetResult();

    public ClanList Search(
        string? name = null,
        int? locationId = null,
        int? minMembers = null,
        int? maxMambers = null,
        int? minScore = null,
        int? limit = null,
        string? after = null,
        string? before = null) =>
            SearchAsync(name, locationId, minMembers, maxMambers, minScore, limit, after, before).GetAwaiter().GetResult();

    public RiverRaceLog ListRiverRaceLog(string clanTag, int? limit = null, string? after = null, string? before = null) =>
        ListRiverRaceLogAsync(clanTag, limit, after, before).GetAwaiter().GetResult();

    public CurrentClanWar GetCurrentWar(string clanTag) =>
        GetCurrentWarAsync(clanTag).GetAwaiter().GetResult();

    public Clan Get(string clanTag) =>
        GetAsync(clanTag).GetAwaiter().GetResult();

    public ClanMemberList ListMembers(string clanTag, int? limit = null, string? after = null, string? before = null) =>
        ListMembersAsync(clanTag, limit, after, before).GetAwaiter().GetResult();

    public CurrentRiverRace GetCurrentRiverRace(string clanTag) =>
        GetCurrentRiverRaceAsync(clanTag).GetAwaiter().GetResult();
}
