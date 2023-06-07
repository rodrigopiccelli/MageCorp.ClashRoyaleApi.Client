using MageCorp.ClashRoyaleApi.Client.Converter;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

public class Match
{
    public object? Invites { get; set; }
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? StartTime { get; set; }
    public MatchStateEnum State { get; set; }
    public Battle? Battle { get; set; }
    public string? Tag { get; set; }
}
