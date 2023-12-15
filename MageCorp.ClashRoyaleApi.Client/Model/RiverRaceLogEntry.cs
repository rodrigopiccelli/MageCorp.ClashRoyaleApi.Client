using MageCorp.ClashRoyaleApi.Client.Converter;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class RiverRaceLogEntry
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public RiverRaceStandingList? Standings { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int SeasonId { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? CreatedDate { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int SectionIndex { get; internal set; }
}
