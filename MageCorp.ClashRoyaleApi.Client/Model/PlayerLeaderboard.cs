using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PlayerLeaderboard
{
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
    public int Score { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PlayerLeaderboardClan? Clan { get; internal set; }
}
