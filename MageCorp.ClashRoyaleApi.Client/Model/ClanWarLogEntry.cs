using MageCorp.ClashRoyaleApi.Client.Converter;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class ClanWarLogEntry
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public ClanWarStandingList? Standings { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int SeasonId { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public ClanWarParticipantList? Participants { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? CreatedDate { get; internal set; }
}
