using MageCorp.ClashRoyaleApi.Client.Converter;
using MageCorp.ClashRoyaleApi.Client.Model.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

public class CurrentClanWar: ApiResponse
{
    public CurrentClanWarStateEnum State { get; set; }
    public ClanWarClan? Clan { get; set; }
    public ClanWarParticipantList? Participants { get; set; }
    public ClanWarClanList? Clans { get; set; }
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? CollectionEndTime { get; set; }
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? WarEndTime { get; set; }
}
