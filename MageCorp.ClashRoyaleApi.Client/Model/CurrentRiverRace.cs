using MageCorp.ClashRoyaleApi.Client.Converter;
using MageCorp.ClashRoyaleApi.Client.Model.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

public class CurrentRiverRace : ApiResponse
{
    public CurrentRiverRaceStateEnum State { get; set; }
    public RiverRaceClan? Clan { get; set; }
    public RiverRaceClanList? Clans { get; set; }
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? CollectionEndTime { get; set; }
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? WarEndTime { get; set; }
    public int SectionIndex { get; set; }
    public int PeriodIndex { get; set; }
    public PeriodTypeEnum PeriodType { get; set; }
    public PeriodLogList? PeriodLogs { get; set; }
}
