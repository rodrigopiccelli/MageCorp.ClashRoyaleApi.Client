using MageCorp.ClashRoyaleApi.Client.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model;
using MageCorp.ClashRoyaleApi.Client.Interfaces;
using System.Web;

namespace MageCorp.ClashRoyaleApi.Client;

internal class PlayersService : ApiClient, IPlayersService
{
    internal PlayersService(HttpClient httpClient) : base(httpClient) { }

    public PlayersService(IHttpClientFactory httpClientFactory) : base(httpClientFactory) { }

    public async Task<Player> GetPlayerAsync(string playerTag) => 
        await GetAsync<Player>($"players/{HttpUtility.UrlEncode(playerTag)}");

    public async Task<UpcomingChests> GetUpcomingChestsAsync(string playerTag) => 
        await GetAsync<UpcomingChests>($"players/{HttpUtility.UrlEncode(playerTag)}/upcomingchests");

    public async Task<BattleList> ListBatlleLogAsync(string playerTag) => 
        await GetAsync<BattleList>($"players/{HttpUtility.UrlEncode(playerTag)}/battlelog");
}
