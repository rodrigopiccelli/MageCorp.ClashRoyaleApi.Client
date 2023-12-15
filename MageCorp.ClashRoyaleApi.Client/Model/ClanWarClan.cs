using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class ClanWarClan
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Crowns { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Tag { get; internal set; }
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
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Participants { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int BattlesPlayed { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Wins { get; internal set; }
}
