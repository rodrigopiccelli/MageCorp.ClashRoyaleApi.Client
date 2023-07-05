namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PlayerLeagueStatistics
{
    /// <summary>
    /// </summary>
    public LeagueSeasonResult? PreviousSeason { get; set; }
    /// <summary>
    /// </summary>
    public LeagueSeasonResult? CurrentSeason { get; set; }
    /// <summary>
    /// </summary>
    public LeagueSeasonResult? BestSeason { get; set; }
}
