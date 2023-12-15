using MageCorp.ClashRoyaleApi.Client.Converter;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Replay
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? ReplayInfo { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public object? ReplayData { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Version? Version { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Tag { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? BattleTime { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ViewCount { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ShareCount { get; internal set; }
}
