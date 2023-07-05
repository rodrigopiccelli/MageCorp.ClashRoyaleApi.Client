using MageCorp.ClashRoyaleApi.Client.Converter;
using MageCorp.ClashRoyaleApi.Client.Model.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class CurrentRiverRace : ApiResponse
{
    /// <summary>
    /// </summary>
    public CurrentRiverRaceStateEnum State { get; set; }
    /// <summary>
    /// </summary>
    public RiverRaceClan? Clan { get; set; }
    /// <summary>
    /// </summary>
    public RiverRaceClanList? Clans { get; set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? CollectionEndTime { get; set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? WarEndTime { get; set; }
    /// <summary>
    /// </summary>
    public int SectionIndex { get; set; }
    /// <summary>
    /// </summary>
    public int PeriodIndex { get; set; }
    /// <summary>
    /// </summary>
    public PeriodTypeEnum PeriodType { get; set; }
    /// <summary>
    /// </summary>
    public PeriodLogList? PeriodLogs { get; set; }
}
