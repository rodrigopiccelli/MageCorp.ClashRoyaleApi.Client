using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class BadgeUrls
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Uri? Large { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Uri? Medium { get; internal set; }
}
