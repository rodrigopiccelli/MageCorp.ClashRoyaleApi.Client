using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class ClanWarParticipant
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
    public int CardsEarned { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int BattlesPlayed { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Wins { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int CollectionDayBattlesPlayed { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int NumberOfBattles { get; internal set; }
}
