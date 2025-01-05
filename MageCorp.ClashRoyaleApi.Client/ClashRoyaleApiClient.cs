using MageCorp.ClashRoyaleApi.Client.Extensions;
using MageCorp.ClashRoyaleApi.Client.Interfaces;

namespace MageCorp.ClashRoyaleApi.Client
{
    /// <summary>
    /// The Clash Royale API Client
    /// </summary>
    public class ClashRoyaleApiClient
    {
        private readonly HttpClient httpClient;

        private ClashRoyaleApiClient(HttpClient httpClient, ApiOptions apiOptions)
        {
            ArgumentNullException.ThrowIfNull(httpClient, nameof(httpClient));
            ArgumentNullException.ThrowIfNull(apiOptions, nameof(apiOptions));
            httpClient.ConfigureApiOptions(apiOptions);

            this.httpClient = httpClient;

            CardsService = new CardsService(this.httpClient);
            ChallengesService = new ChallengesService(this.httpClient);
            ClansService = new ClansService(this.httpClient);
            GlobalTournamentsService = new GlobalTournamentsService(this.httpClient);
            LocationsService = new LocationsService(this.httpClient);
            PlayersService = new PlayersService(this.httpClient);
            TournamentsService = new TournamentsService(this.httpClient);
            LeaderboardsService = new LeaderboardsService(this.httpClient);
            FilesService = new FilesService(this.httpClient);
        }

        /// <summary>
        /// Creates an instance of ClashRoyaleApiClient
        /// </summary>
        /// <param name="apiOptions">Instance of ApiOptions</param>
        public static ClashRoyaleApiClient Create(ApiOptions apiOptions)
        {
            var httpClient = new HttpClient(new SocketsHttpHandler
            {
                PooledConnectionLifetime = TimeSpan.FromMinutes(2)
            });
            return Create(apiOptions, httpClient);
        }

        /// <summary>
        /// Creates an instance of ClashRoyaleApiClient
        /// </summary>
        /// <param name="apiOptions">Instance of ApiOptions</param>
        /// <param name="httpClientFactory">Instance of IHttpClientFactory</param>
        public static ClashRoyaleApiClient Create(ApiOptions apiOptions, IHttpClientFactory httpClientFactory)
        {
            ArgumentNullException.ThrowIfNull(httpClientFactory, nameof(httpClientFactory));
            var httpClient = httpClientFactory.CreateClient();
            return Create(apiOptions, httpClient);
        }

        /// <summary>
        /// Creates an instance of ClashRoyaleApiClient
        /// </summary>
        /// <param name="apiOptions">Instance of ApiOptions</param>
        /// <param name="httpClient">Instance of HttpClient</param>
        public static ClashRoyaleApiClient Create(ApiOptions apiOptions, HttpClient httpClient)
            => new(httpClient, apiOptions);

        /// <summary>
        /// Access card information
        /// </summary>
        public ICardsService CardsService { get; }
        /// <summary>
        /// Access challenge information
        /// </summary>
        public IChallengesService ChallengesService { get; }
        /// <summary>
        /// Access clan specific information
        /// </summary>
        public IClansService ClansService { get; }
        /// <summary>
        /// Access global tournaments information
        /// </summary>
        public IGlobalTournamentsService GlobalTournamentsService { get; }
        /// <summary>
        /// Access global and local rankings
        /// </summary>
        public ILocationsService LocationsService { get; }
        /// <summary>
        /// Access player specific information
        /// </summary>
        public IPlayersService PlayersService { get; }
        /// <summary>
        /// Access tournament information
        /// </summary>
        public ITournamentsService TournamentsService { get; }
        /// <summary>
        /// Access leaderboard information
        /// </summary>
        public ILeaderboardsService LeaderboardsService { get; }
        /// <summary>
        /// Access files information
        /// </summary>
        public IFilesService FilesService { get; }
    }
}
