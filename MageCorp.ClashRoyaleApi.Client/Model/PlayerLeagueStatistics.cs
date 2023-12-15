using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PlayerLeagueStatistics
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public LeagueSeasonResult? PreviousSeason { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public LeagueSeasonResult? CurrentSeason { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public LeagueSeasonResult? BestSeason { get; internal set; }
}
