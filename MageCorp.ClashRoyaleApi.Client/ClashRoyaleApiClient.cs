using MageCorp.ClashRoyaleApi.Client.Extensions;
using MageCorp.ClashRoyaleApi.Client.Interfaces;

namespace MageCorp.ClashRoyaleApi.Client
{
    /// <summary>
    /// The Clash Royale API Client
    /// </summary>
    public class ClashRoyaleApiClient
    {
        private static HttpClient? httpClient;

        private ClashRoyaleApiClient(ApiOptions apiOptions)
        {
            ArgumentNullException.ThrowIfNull(apiOptions);

            httpClient = new HttpClient(new SocketsHttpHandler
            {
                PooledConnectionLifetime = TimeSpan.FromMinutes(2)
            });
            httpClient.ConfigureApiOptions(apiOptions);

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
        /// <param name="apiOptions">Instance of ApiOptions</param>
        /// <returns></returns>
        public static ClashRoyaleApiClient Create(ApiOptions apiOptions)
        {
            return new ClashRoyaleApiClient(apiOptions);
        }

        /// <summary>
        /// Access card information
        /// </summary>
        public ICardsService CardsService { get; internal set; }
        /// <summary>
        /// Access challenge information
        /// </summary>
        public IChallengesService ChallengesService { get; internal set; }
        /// <summary>
        /// Access clan specific information
        /// </summary>
        public IClansService ClansService { get; internal set; }
        /// <summary>
        /// Access global tournaments information
        /// </summary>
        public IGlobalTournamentsService GlobalTournamentsService { get; internal set; }
        /// <summary>
        /// Access global and local rankings
        /// </summary>
        public ILocationsService LocationsService { get; internal set; }
        /// <summary>
        /// Access player specific information
        /// </summary>
        public IPlayersService PlayersService { get; internal set; }
        /// <summary>
        /// Access tournament information
        /// </summary>
        public ITournamentsService TournamentsService { get; internal set; }
        /// <summary>
        /// Access leaderboard information
        /// </summary>
        public ILeaderboardsService LeaderboardsService { get; internal set; }
        /// <summary>
        /// Access files information
        /// </summary>
        public IFilesService FilesService { get; internal set; }
    }
}
