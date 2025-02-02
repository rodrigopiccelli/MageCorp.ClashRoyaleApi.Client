using MageCorp.ClashRoyaleApi.Client.Converter;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class ChallengeChain
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Title { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public ChallengeChainType Type { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? StartTime { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? EndTime { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public ChallengeList? Challenge { get; internal set; }
}
