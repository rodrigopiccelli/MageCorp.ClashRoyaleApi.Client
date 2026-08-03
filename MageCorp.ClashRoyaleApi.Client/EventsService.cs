using MageCorp.ClashRoyaleApi.Client.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model;
using MageCorp.ClashRoyaleApi.Client.Interfaces;

namespace MageCorp.ClashRoyaleApi.Client;

internal class EventsService : ApiClient, IEventsService
{
    internal EventsService(HttpClient httpClient) : base(httpClient) { }

    public EventsService(IHttpClientFactory httpClientFactory) : base(httpClientFactory) { }

    public async Task<TrailEventList> ListEventsAsync() =>
        await GetAsync<TrailEventList>("events");

    public TrailEventList ListEvents() =>
        ListEventsAsync().GetAwaiter().GetResult();
}
