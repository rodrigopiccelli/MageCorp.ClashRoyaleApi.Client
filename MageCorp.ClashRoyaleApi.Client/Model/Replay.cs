using MageCorp.ClashRoyaleApi.Client.Converter;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Replay
{
    /// <summary>
    /// </summary>
    public string? ReplayInfo { get; set; }
    /// <summary>
    /// </summary>
    public object? ReplayData { get; set; }
    /// <summary>
    /// </summary>
    public Version? Version { get; set; }
    /// <summary>
    /// </summary>
    public string? Tag { get; set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? BattleTime { get; set; }
    /// <summary>
    /// </summary>
    public int ViewCount { get; set; }
    /// <summary>
    /// </summary>
    public int ShareCount { get; set; }
}
