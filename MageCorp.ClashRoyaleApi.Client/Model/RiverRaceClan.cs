using MageCorp.ClashRoyaleApi.Client.Converter;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

public class RiverRaceClan
{
    public string? Tag { get; set; }
    public int ClanScore { get; set; }
    public int BadgeId { get; set; }
    public string? Name { get; set; }
    public int Fame { get; set; }
    public int RepairPoints { get; set; }
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? FinishTime { get; set; }
    public RiverRaceParticipantList? Participants { get; set; }
}
