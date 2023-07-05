using MageCorp.ClashRoyaleApi.Client.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model;
using MageCorp.ClashRoyaleApi.Client.Interfaces;
using System.Web;
using System.Collections.Specialized;

namespace MageCorp.ClashRoyaleApi.Client;

internal class ClansService : ApiClient, IClansService
{
    internal ClansService(HttpClient httpClient) : base(httpClient) { }

    public ClansService(IHttpClientFactory httpClientFactory) : base(httpClientFactory) { }

    public async Task<ClanWarLog?> ListWarlogAsync(string clanTag, int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<ClanWarLog>($"clans/{HttpUtility.UrlEncode(clanTag)}/warlog",
            new NameValueCollection { { "limit", limit?.ToString() }, { "after", after }, { "before", before } });

    public async Task<ClanList?> SearchAsync(
        string? name = null, 
        int? locationId = null, 
        int? minMembers = null, 
        int? maxMambers = null, 
        int? minScore = null, 
        int? limit = null, 
        string? after = null, 
        string? before = null) => 
            await GetAsync<ClanList>($"clans",
                new NameValueCollection {
                    { "name", name },
                    { "locationId", locationId?.ToString() },
                    { "minMembers", minMembers?.ToString() },
                    { "maxMambers", maxMambers?.ToString() },
                    { "minScore", minScore?.ToString() },
                    { "limit", limit?.ToString() }, 
                    { "after", after }, 
                    { "before", before } 
                });

    public async Task<RiverRaceLog?> ListRiverRaceLogAsync(string clanTag, int? limit = null, string? after = null, string? before = null) => 
        await GetAsync<RiverRaceLog>($"clans/{HttpUtility.UrlEncode(clanTag)}/riverracelog", 
            new NameValueCollection { { "limit", limit?.ToString() }, { "after", after }, { "before", before } });

    public async Task<CurrentClanWar?> GetCurrentWarAsync(string clanTag) =>
        await GetAsync<CurrentClanWar>($"clans/{HttpUtility.UrlEncode(clanTag)}/currentwar");

    public async Task<Clan?> GetAsync(string clanTag) =>
        await GetAsync<Clan>($"clans/{HttpUtility.UrlEncode(clanTag)}");

    public async Task<ClanMemberList?> ListMembersAsync(string clanTag, int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<ClanMemberList>($"clans/{HttpUtility.UrlEncode(clanTag)}/members",
            new NameValueCollection { { "limit", limit?.ToString() }, { "after", after }, { "before", before } });

    public async Task<CurrentRiverRace?> GetCurrentRiverRaceAsync(string clanTag) =>
        await GetAsync<CurrentRiverRace>($"clans/{HttpUtility.UrlEncode(clanTag)}/currentriverrace");


}
