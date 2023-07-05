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
    public object? Invites { get; set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? StartTime { get; set; }
    /// <summary>
    /// </summary>
    public MatchStateEnum State { get; set; }
    /// <summary>
    /// </summary>
    public Battle? Battle { get; set; }
    /// <summary>
    /// </summary>
    public string? Tag { get; set; }
}
