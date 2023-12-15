using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Arena
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Id { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public IconUrls? IconUrls { get; internal set; }
}
