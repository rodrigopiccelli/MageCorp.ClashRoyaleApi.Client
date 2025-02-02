using MageCorp.ClashRoyaleApi.Client.Converter;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Match
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public object? Invites { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? StartTime { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public MatchState State { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Battle? Battle { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Tag { get; internal set; }
}
