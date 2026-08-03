using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class TrailEvent
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Title { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Description { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? EventTag { get; internal set; }
}
