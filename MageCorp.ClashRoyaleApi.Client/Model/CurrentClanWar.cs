using MageCorp.ClashRoyaleApi.Client.Converter;
using MageCorp.ClashRoyaleApi.Client.Model.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class CurrentClanWar: ApiResponse
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public CurrentClanWarState State { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public ClanWarClan? Clan { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public ClanWarParticipantList? Participants { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public ClanWarClanList? Clans { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? CollectionEndTime { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? WarEndTime { get; internal set; }
}
