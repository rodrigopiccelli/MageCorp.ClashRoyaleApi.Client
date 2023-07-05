using MageCorp.ClashRoyaleApi.Client.Model.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Player : ApiResponse
{
    /// <summary>
    /// </summary>
    public PlayerClan? Clan { get; set; }
    /// <summary>
    /// </summary>
    public Arena? Arena { get; set; }
    /// <summary>
    /// </summary>
    public RoleEnum Role { get; set; }
    /// <summary>
    /// </summary>
    public int Wins { get; set; }
    /// <summary>
    /// </summary>
    public int Losses { get; set; }
    /// <summary>
    /// </summary>
    public int TotalDonations { get; set; }
    /// <summary>
    /// </summary>
    public PlayerLeagueStatistics? LeagueStatistics { get; set; }
    /// <summary>
    /// </summary>
    public PlayerCardList? Cards { get; set; }
    /// <summary>
    /// </summary>
    public Card? CurrentFavouriteCard { get; set; }
    /// <summary>
    /// </summary>
    public PlayerAchievementBadgeList? Badges { get; set; }
    /// <summary>
    /// </summary>
    public string? Tag { get; set; }
    /// <summary>
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// </summary>
    public int ExpLevel { get; set; }
    /// <summary>
    /// </summary>
    public int Trophies { get; set; }
    /// <summary>
    /// </summary>
    public int BestTrophies { get; set; }
    /// <summary>
    /// </summary>
    public int Donations { get; set; }
    /// <summary>
    /// </summary>
    public int DonationsReceived { get; set; }
    /// <summary>
    /// </summary>
    public PlayerAchievementProgressList? Achievements { get; set; }
    /// <summary>
    /// </summary>
    public int BattleCount { get; set; }
    /// <summary>
    /// </summary>
    public int ThreeCrownWins { get; set; }
    /// <summary>
    /// </summary>
    public int ChallengeCardsWon { get; set; }
    /// <summary>
    /// </summary>
    public int ChallengeMaxWins { get; set; }
    /// <summary>
    /// </summary>
    public int TournamentCardsWon { get; set; }
    /// <summary>
    /// </summary>
    public int TournamentBattleCount { get; set; }
    /// <summary>
    /// </summary>
    public PlayerCardList? CurrentDeck { get; set; }
    /// <summary>
    /// </summary>
    public int WarDayWins { get; set; }
    /// <summary>
    /// </summary>
    public int ClanCardsCollected { get; set; }
    /// <summary>
    /// </summary>
    public int StarPoints { get; set; }
    /// <summary>
    /// </summary>
    public int ExpPoints { get; set; }
}
