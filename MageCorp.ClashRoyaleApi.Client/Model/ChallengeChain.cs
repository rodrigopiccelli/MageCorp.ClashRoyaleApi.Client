using MageCorp.ClashRoyaleApi.Client.Converter;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class ChallengeChain
{
    /// <summary>
    /// </summary>
    public string? Title { get; internal set; }
    /// <summary>
    /// </summary>
    public ChallengeChainTypeEnum Type { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? StartTime { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? EndTime { get; internal set; }
    /// <summary>
    /// </summary>
    public ChallengeList? Challenge { get; internal set; }
}
