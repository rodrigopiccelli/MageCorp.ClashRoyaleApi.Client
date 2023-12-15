namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PlayerLeagueStatistics
{
    /// <summary>
    /// </summary>
    public LeagueSeasonResult? PreviousSeason { get; internal set; }
    /// <summary>
    /// </summary>
    public LeagueSeasonResult? CurrentSeason { get; internal set; }
    /// <summary>
    /// </summary>
    public LeagueSeasonResult? BestSeason { get; internal set; }
}
