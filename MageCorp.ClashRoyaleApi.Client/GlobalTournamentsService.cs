using MageCorp.ClashRoyaleApi.Client.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model;
using MageCorp.ClashRoyaleApi.Client.Interfaces;

namespace MageCorp.ClashRoyaleApi.Client;

internal class GlobalTournamentsService : ApiClient, IGlobalTournamentsService
{
    internal GlobalTournamentsService(HttpClient httpClient) : base(httpClient) { }

    public GlobalTournamentsService(IHttpClientFactory httpClientFactory) : base(httpClientFactory) { }

    public async Task<LadderTournamentList> ListGlobalTournamentsAsync() =>
        await GetAsync<LadderTournamentList>($"globaltournaments");

    public LadderTournamentList ListGlobalTournaments() =>
        ListGlobalTournamentsAsync().GetAwaiter().GetResult();
}
