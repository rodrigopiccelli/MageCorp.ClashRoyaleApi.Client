using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PlayerPathOfLegendRanking
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PlayerRankingClan? Clan { get; internal set; }
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
    public int Rank { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int EloRating { get; internal set; }
}
