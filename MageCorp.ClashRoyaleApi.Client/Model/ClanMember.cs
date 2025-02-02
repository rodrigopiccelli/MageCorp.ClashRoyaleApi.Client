using MageCorp.ClashRoyaleApi.Client.Converter;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class ClanMember
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Arena? Arena { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ClanChestPoints { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? LastSeen { get; internal set; }
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
    public Role Role { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ExpLevel { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Trophies { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ClanRank { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int PreviousClanRank { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Donations { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int DonationsReceived { get; internal set; }
}
