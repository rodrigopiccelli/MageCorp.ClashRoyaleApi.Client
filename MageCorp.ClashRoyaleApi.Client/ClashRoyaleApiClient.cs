using MageCorp.ClashRoyaleApi.Client.Extensions;
using MageCorp.ClashRoyaleApi.Client.Interfaces;

namespace MageCorp.ClashRoyaleApi.Client
{
    public class ClashRoyaleApiClient
    {
        private static HttpClient? httpClient;

        private ClashRoyaleApiClient(ApiOptions apiOptions)
        {
            if (apiOptions == null)
                throw new ArgumentNullException(nameof(apiOptions));

            httpClient = new HttpClient(new SocketsHttpHandler
            {
                PooledConnectionLifetime = TimeSpan.FromMinutes(2)
            });
            httpClient.ConfigureApiOptions(apiOptions ?? new());

            CardsService = new CardsService(httpClient);
            ChallengesService = new ChallengesService(httpClient);
            ClansService = new ClansService(httpClient);
            GlobalTournamentsService = new GlobalTournamentsService(httpClient);
            LocationsService = new LocationsService(httpClient);
            PlayersService = new PlayersService(httpClient);
            TournamentsService = new TournamentsService(httpClient);
        }

        public static ClashRoyaleApiClient Create(ApiOptions apiOptions)
        {
            return new ClashRoyaleApiClient(apiOptions);
        }

        public ICardsService CardsService { get; internal set; }
        public IChallengesService ChallengesService { get; internal set; }
        public IClansService ClansService { get; internal set; }
        public IGlobalTournamentsService GlobalTournamentsService { get; internal set; }
        public ILocationsService LocationsService { get; internal set; }
        public IPlayersService PlayersService { get; internal set; }
        public ITournamentsService TournamentsService { get; internal set; }
    }
}
