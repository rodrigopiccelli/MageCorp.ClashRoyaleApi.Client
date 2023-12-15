using MageCorp.ClashRoyaleApi.Client.Converter;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class RiverRaceClan
{
    /// <summary>
    /// </summary>
    public string? Tag { get; internal set; }
    /// <summary>
    /// </summary>
    public int ClanScore { get; internal set; }
    /// <summary>
    /// </summary>
    public int BadgeId { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    public int Fame { get; internal set; }
    /// <summary>
    /// </summary>
    public int RepairPoints { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? FinishTime { get; internal set; }
    /// <summary>
    /// </summary>
    public RiverRaceParticipantList? Participants { get; internal set; }
}
