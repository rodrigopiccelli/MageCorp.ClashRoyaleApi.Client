using MageCorp.ClashRoyaleApi.Client.Model.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Player : ApiResponse
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PlayerClan? Clan { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Arena? Arena { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public RoleEnum Role { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Wins { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Losses { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int TotalDonations { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PlayerLeagueStatistics? LeagueStatistics { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PlayerCardList? Cards { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PlayerCardList? SupportCards { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Card? CurrentFavouriteCard { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PlayerAchievementBadgeList? Badges { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Tag { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ExpLevel { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Trophies { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int BestTrophies { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Donations { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int DonationsReceived { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PlayerAchievementProgressList? Achievements { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int BattleCount { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ThreeCrownWins { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ChallengeCardsWon { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ChallengeMaxWins { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int TournamentCardsWon { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int TournamentBattleCount { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PlayerCardList? CurrentDeck { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PlayerCardList? CurrentDeckSupportCards { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int WarDayWins { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ClanCardsCollected { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int StarPoints { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ExpPoints { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int LegacyTrophyRoadHighScore { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PathOfLegendSeasonResult? CurrentPathOfLegendSeasonResult { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PathOfLegendSeasonResult? LastPathOfLegendSeasonResult { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PathOfLegendSeasonResult? BestPathOfLegendSeasonResult { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Progress? Progress { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int TotalExpPoints { get; internal set; }
}
