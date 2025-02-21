using MageCorp.ClashRoyaleApi.Client.Abstract;
using MageCorp.ClashRoyaleApi.Client.Interfaces;
using MageCorp.ClashRoyaleApi.Client.Model;
using System.Web;

namespace MageCorp.ClashRoyaleApi.Client;
internal class LeaderboardsService : ApiClient, ILeaderboardsService
{
    internal LeaderboardsService(HttpClient httpClient) : base(httpClient) { }

    public LeaderboardsService(IHttpClientFactory httpClientFactory) : base(httpClientFactory) { }

    public async Task<PlayerLeaderboardList> GetLeaderboardAsync(long leaderboardId, int? limit = null, string? after = null, string? before = null) =>
        await GetAsync<PlayerLeaderboardList>($"leaderboard/{HttpUtility.UrlEncode(leaderboardId.ToString())}",
            CreatePagingParameters(limit, after, before));

    public async Task<LeaderboardList> ListLeaderboardsAsync() => 
        await GetAsync<LeaderboardList>("leaderboards");
}
