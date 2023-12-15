using MageCorp.ClashRoyaleApi.Client.Converter;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Replay
{
    /// <summary>
    /// </summary>
    public string? ReplayInfo { get; internal set; }
    /// <summary>
    /// </summary>
    public object? ReplayData { get; internal set; }
    /// <summary>
    /// </summary>
    public Version? Version { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Tag { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? BattleTime { get; internal set; }
    /// <summary>
    /// </summary>
    public int ViewCount { get; internal set; }
    /// <summary>
    /// </summary>
    public int ShareCount { get; internal set; }
}
