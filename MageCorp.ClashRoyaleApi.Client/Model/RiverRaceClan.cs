using MageCorp.ClashRoyaleApi.Client.Converter;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class RiverRaceClan
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Tag { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ClanScore { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int BadgeId { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Fame { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int RepairPoints { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? FinishTime { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public RiverRaceParticipantList? Participants { get; internal set; }
}
