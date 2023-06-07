using MageCorp.ClashRoyaleApi.Client.Model.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;

namespace MageCorp.ClashRoyaleApi.Client.Model;

public class Player : ApiResponse
{
    public PlayerClan? Clan { get; set; }
    public Arena? Arena { get; set; }
    public RoleEnum Role { get; set; }
    public int Wins { get; set; }
    public int Losses { get; set; }
    public int TotalDonations { get; set; }
    public PlayerLeagueStatistics? LeagueStatistics { get; set; }
    public PlayerCardList? Cards { get; set; }
    public Card? CurrentFavouriteCard { get; set; }
    public PlayerAchievementBadgeList? Badges { get; set; }
    public string? Tag { get; set; }
    public string? Name { get; set; }
    public int ExpLevel { get; set; }
    public int Trophies { get; set; }
    public int BestTrophies { get; set; }
    public int Donations { get; set; }
    public int DonationsReceived { get; set; }
    public PlayerAchievementProgressList? Achievements { get; set; }
    public int BattleCount { get; set; }
    public int ThreeCrownWins { get; set; }
    public int ChallengeCardsWon { get; set; }
    public int ChallengeMaxWins { get; set; }
    public int TournamentCardsWon { get; set; }
    public int TournamentBattleCount { get; set; }
    public PlayerCardList? CurrentDeck { get; set; }
    public int WarDayWins { get; set; }
    public int ClanCardsCollected { get; set; }
    public int StarPoints { get; set; }
    public int ExpPoints { get; set; }
}
