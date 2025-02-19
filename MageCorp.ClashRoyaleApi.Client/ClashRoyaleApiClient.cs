using MageCorp.ClashRoyaleApi.Client.Extensions;
using MageCorp.ClashRoyaleApi.Client.Interfaces;

namespace MageCorp.ClashRoyaleApi.Client
{
    /// <summary>
    /// The Clash Royale API Client
    /// </summary>
    public class ClashRoyaleApiClient
    {
        private ClashRoyaleApiClient(HttpClient httpClient, ClashRoyaleApiOptions clashRoyaleApiOptions)
        {
            ArgumentNullException.ThrowIfNull(httpClient);
            ArgumentNullException.ThrowIfNull(clashRoyaleApiOptions);
            httpClient.ConfigureClashRoyaleApiOptions(clashRoyaleApiOptions);

            CardsService = new CardsService(httpClient);
            ChallengesService = new ChallengesService(httpClient);
            ClansService = new ClansService(httpClient);
            GlobalTournamentsService = new GlobalTournamentsService(httpClient);
            LocationsService = new LocationsService(httpClient);
            PlayersService = new PlayersService(httpClient);
            TournamentsService = new TournamentsService(httpClient);
            LeaderboardsService = new LeaderboardsService(httpClient);
            FilesService = new FilesService(httpClient);
        }

        /// <summary>
        /// Creates an instance of ClashRoyaleApiClient
        /// </summary>
        /// <param name="clashRoyaleApiOptions">Instance of ApiOptions</param>
        public static ClashRoyaleApiClient Create(ClashRoyaleApiOptions clashRoyaleApiOptions)
        {
            var httpClient = new HttpClient(new SocketsHttpHandler
            {
                PooledConnectionLifetime = TimeSpan.FromMinutes(2)
            });
            return Create(clashRoyaleApiOptions, httpClient);
        }

        /// <summary>
        /// Creates an instance of ClashRoyaleApiClient
        /// </summary>
        /// <param name="clashRoyaleApiOptions">Instance of ApiOptions</param>
        /// <param name="httpClientFactory">Instance of IHttpClientFactory</param>
        public static ClashRoyaleApiClient Create(ClashRoyaleApiOptions clashRoyaleApiOptions, IHttpClientFactory httpClientFactory)
        {
            ArgumentNullException.ThrowIfNull(httpClientFactory);
            var httpClient = httpClientFactory.CreateClient();
            return Create(clashRoyaleApiOptions, httpClient);
        }

        /// <summary>
        /// Creates an instance of ClashRoyaleApiClient
        /// </summary>
        /// <param name="clashRoyaleApiOptions">Instance of ApiOptions</param>
        /// <param name="httpClient">Instance of HttpClient</param>
        public static ClashRoyaleApiClient Create(ClashRoyaleApiOptions clashRoyaleApiOptions, HttpClient httpClient)
            => new(httpClient, clashRoyaleApiOptions);

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
