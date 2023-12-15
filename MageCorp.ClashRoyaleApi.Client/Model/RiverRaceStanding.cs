using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class RiverRaceStanding
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Rank { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int TrophyChange { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public RiverRaceClan? Clan { get; internal set; }
}
