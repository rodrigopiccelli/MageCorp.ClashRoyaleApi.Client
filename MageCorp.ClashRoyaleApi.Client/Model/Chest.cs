using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Chest
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Index { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public IconUrls? IconUrls { get; internal set; }
}
