using MageCorp.ClashRoyaleApi.Client.Converter;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class RiverRaceClan
{
    /// <summary>
    /// </summary>
    public string? Tag { get; set; }
    /// <summary>
    /// </summary>
    public int ClanScore { get; set; }
    /// <summary>
    /// </summary>
    public int BadgeId { get; set; }
    /// <summary>
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// </summary>
    public int Fame { get; set; }
    /// <summary>
    /// </summary>
    public int RepairPoints { get; set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? FinishTime { get; set; }
    /// <summary>
    /// </summary>
    public RiverRaceParticipantList? Participants { get; set; }
}
