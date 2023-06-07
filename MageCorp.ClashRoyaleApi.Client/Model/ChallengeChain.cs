using MageCorp.ClashRoyaleApi.Client.Converter;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

public class ChallengeChain
{
    public string? Title { get; set; }
    public ChallengeChainTypeEnum Type { get; set; }
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? StartTime { get; set; }
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? EndTime { get; set; }
    public ChallengeList? Challenge { get; set; }
}
