using MageCorp.ClashRoyaleApi.Client.Converter;
using MageCorp.ClashRoyaleApi.Client.Model.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class CurrentClanWar: ApiResponse
{
    /// <summary>
    /// </summary>
    public CurrentClanWarStateEnum State { get; internal set; }
    /// <summary>
    /// </summary>
    public ClanWarClan? Clan { get; internal set; }
    /// <summary>
    /// </summary>
    public ClanWarParticipantList? Participants { get; internal set; }
    /// <summary>
    /// </summary>
    public ClanWarClanList? Clans { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? CollectionEndTime { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? WarEndTime { get; internal set; }
}
