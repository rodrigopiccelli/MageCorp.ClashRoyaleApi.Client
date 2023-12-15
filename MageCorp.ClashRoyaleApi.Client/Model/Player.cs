using MageCorp.ClashRoyaleApi.Client.Model.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Player : ApiResponse
{
    /// <summary>
    /// </summary>
    public PlayerClan? Clan { get; internal set; }
    /// <summary>
    /// </summary>
    public Arena? Arena { get; internal set; }
    /// <summary>
    /// </summary>
    public RoleEnum Role { get; internal set; }
    /// <summary>
    /// </summary>
    public int Wins { get; internal set; }
    /// <summary>
    /// </summary>
    public int Losses { get; internal set; }
    /// <summary>
    /// </summary>
    public int TotalDonations { get; internal set; }
    /// <summary>
    /// </summary>
    public PlayerLeagueStatistics? LeagueStatistics { get; internal set; }
    /// <summary>
    /// </summary>
    public PlayerCardList? Cards { get; internal set; }
    /// <summary>
    /// </summary>
    public PlayerCardList? SupportCards { get; internal set; }
    /// <summary>
    /// </summary>
    public Card? CurrentFavouriteCard { get; internal set; }
    /// <summary>
    /// </summary>
    public PlayerAchievementBadgeList? Badges { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Tag { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    public int ExpLevel { get; internal set; }
    /// <summary>
    /// </summary>
    public int Trophies { get; internal set; }
    /// <summary>
    /// </summary>
    public int BestTrophies { get; internal set; }
    /// <summary>
    /// </summary>
    public int Donations { get; internal set; }
    /// <summary>
    /// </summary>
    public int DonationsReceived { get; internal set; }
    /// <summary>
    /// </summary>
    public PlayerAchievementProgressList? Achievements { get; internal set; }
    /// <summary>
    /// </summary>
    public int BattleCount { get; internal set; }
    /// <summary>
    /// </summary>
    public int ThreeCrownWins { get; internal set; }
    /// <summary>
    /// </summary>
    public int ChallengeCardsWon { get; internal set; }
    /// <summary>
    /// </summary>
    public int ChallengeMaxWins { get; internal set; }
    /// <summary>
    /// </summary>
    public int TournamentCardsWon { get; internal set; }
    /// <summary>
    /// </summary>
    public int TournamentBattleCount { get; internal set; }
    /// <summary>
    /// </summary>
    public PlayerCardList? CurrentDeck { get; internal set; }
    /// <summary>
    /// </summary>
    public PlayerCardList? CurrentDeckSupportCards { get; internal set; }
    /// <summary>
    /// </summary>
    public int WarDayWins { get; internal set; }
    /// <summary>
    /// </summary>
    public int ClanCardsCollected { get; internal set; }
    /// <summary>
    /// </summary>
    public int StarPoints { get; internal set; }
    /// <summary>
    /// </summary>
    public int ExpPoints { get; internal set; }
    /// <summary>
    /// </summary>
    public int LegacyTrophyRoadHighScore { get; internal set; }
    /// <summary>
    /// </summary>
    public PathOfLegendSeasonResult? CurrentPathOfLegendSeasonResult { get; internal set; }
    /// <summary>
    /// </summary>
    public PathOfLegendSeasonResult? LastPathOfLegendSeasonResult { get; internal set; }
    /// <summary>
    /// </summary>
    public PathOfLegendSeasonResult? BestPathOfLegendSeasonResult { get; internal set; }
    /// <summary>
    /// </summary>
    public int TotalExpPoints { get; internal set; }
}
