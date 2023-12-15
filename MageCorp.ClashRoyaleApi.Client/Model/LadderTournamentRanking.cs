using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class LadderTournamentRanking
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PlayerRankingClan? Clan { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Wins { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Losses { get; internal set; }
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
}
