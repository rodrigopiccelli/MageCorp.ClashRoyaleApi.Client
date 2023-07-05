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
    public CurrentClanWarStateEnum State { get; set; }
    /// <summary>
    /// </summary>
    public ClanWarClan? Clan { get; set; }
    /// <summary>
    /// </summary>
    public ClanWarParticipantList? Participants { get; set; }
    /// <summary>
    /// </summary>
    public ClanWarClanList? Clans { get; set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? CollectionEndTime { get; set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? WarEndTime { get; set; }
}
