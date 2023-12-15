using MageCorp.ClashRoyaleApi.Client.Converter;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Match
{
    /// <summary>
    /// </summary>
    public object? Invites { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? StartTime { get; internal set; }
    /// <summary>
    /// </summary>
    public MatchStateEnum State { get; internal set; }
    /// <summary>
    /// </summary>
    public Battle? Battle { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Tag { get; internal set; }
}
