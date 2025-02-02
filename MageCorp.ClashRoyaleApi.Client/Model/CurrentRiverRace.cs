using MageCorp.ClashRoyaleApi.Client.Converter;
using MageCorp.ClashRoyaleApi.Client.Model.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class CurrentRiverRace : ApiResponse
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public CurrentRiverRaceState State { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public RiverRaceClan? Clan { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public RiverRaceClanList? Clans { get; internal set; }
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
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int SectionIndex { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int PeriodIndex { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PeriodType PeriodType { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PeriodLogList? PeriodLogs { get; internal set; }
}
