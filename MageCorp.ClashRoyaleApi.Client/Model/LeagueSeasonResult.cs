using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class LeagueSeasonResult
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Trophies { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Rank { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int BestTrophies { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Id { get; internal set; }
}
