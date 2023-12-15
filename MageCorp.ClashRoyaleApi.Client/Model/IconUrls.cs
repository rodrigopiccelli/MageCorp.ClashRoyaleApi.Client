using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class IconUrls
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Uri? Large { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Uri? Medium { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Uri? EvolutionMedium { get; internal set; }
}
