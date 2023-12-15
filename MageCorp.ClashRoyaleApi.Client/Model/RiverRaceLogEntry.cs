using MageCorp.ClashRoyaleApi.Client.Converter;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class RiverRaceLogEntry
{
    /// <summary>
    /// </summary>
    public RiverRaceStandingList? Standings { get; internal set; }
    /// <summary>
    /// </summary>
    public int SeasonId { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? CreatedDate { get; internal set; }
    /// <summary>
    /// </summary>
    public int SectionIndex { get; internal set; }
}
