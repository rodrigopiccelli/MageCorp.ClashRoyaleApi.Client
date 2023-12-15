using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class ClanRanking
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ClanScore { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int BadgeId { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Location? Location { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Members { get; internal set; }
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
    public int Rank { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int PreviousRank { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public BadgeUrls? BadgeUrls { get; internal set; }
}
