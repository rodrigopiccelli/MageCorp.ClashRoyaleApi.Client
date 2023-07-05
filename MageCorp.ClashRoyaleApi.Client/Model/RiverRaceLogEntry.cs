using MageCorp.ClashRoyaleApi.Client.Converter;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class RiverRaceLogEntry
{
    /// <summary>
    /// </summary>
    public RiverRaceStandingList? Standings { get; set; }
    /// <summary>
    /// </summary>
    public int SeasonId { get; set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? CreatedDate { get; set; }
    /// <summary>
    /// </summary>
    public int SectionIndex { get; set; }
}
