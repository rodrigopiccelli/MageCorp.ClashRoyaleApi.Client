using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;
/// <summary>
/// </summary>
public class PathOfLegendSeasonResult
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Trophies { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int LeagueNumber { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int? Rank { get; internal set; }
}
