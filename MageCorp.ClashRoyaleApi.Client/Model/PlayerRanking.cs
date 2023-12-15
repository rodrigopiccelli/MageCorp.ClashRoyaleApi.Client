using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PlayerRanking
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PlayerRankingClan? Clan { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Arena? Arena { get; internal set; }
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
    public int PreviousRank { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Trophies { get; internal set; }
}
