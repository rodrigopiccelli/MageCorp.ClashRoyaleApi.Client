using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class ClanWarStanding
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int TrophyChange { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public ClanWarClan? Clan { get; internal set; }   
}
