using MageCorp.ClashRoyaleApi.Client.Converter;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

public class RiverRaceLogEntry
{
    public RiverRaceStandingList? Standings { get; set; }
    public int SeasonId { get; set; }
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? CreatedDate { get; set; }
    public int SectionIndex { get; set; }
}
