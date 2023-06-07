using MageCorp.ClashRoyaleApi.Client.Converter;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

public class ClanWarLogEntry
{
    public ClanWarStandingList? Standings { get; set; }
    public int SeasonId { get; set; }
    public ClanWarParticipantList? Participants { get; set; }
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? CreatedDate { get; set; }
}
