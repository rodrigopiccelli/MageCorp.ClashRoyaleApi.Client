namespace MageCorp.ClashRoyaleApi.Client.Model;

public class PlayerLeagueStatistics
{
    public LeagueSeasonResult? PreviousSeason { get; set; }
    public LeagueSeasonResult? CurrentSeason { get; set; }
    public LeagueSeasonResult? BestSeason { get; set; }
}
