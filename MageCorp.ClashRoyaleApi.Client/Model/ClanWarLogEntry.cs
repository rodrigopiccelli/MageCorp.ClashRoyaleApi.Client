using MageCorp.ClashRoyaleApi.Client.Converter;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class ClanWarLogEntry
{
    /// <summary>
    /// </summary>
    public ClanWarStandingList? Standings { get; set; }
    /// <summary>
    /// </summary>
    public int SeasonId { get; set; }
    /// <summary>
    /// </summary>
    public ClanWarParticipantList? Participants { get; set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? CreatedDate { get; set; }
}
