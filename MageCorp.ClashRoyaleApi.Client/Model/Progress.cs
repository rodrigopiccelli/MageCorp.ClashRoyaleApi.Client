using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Progress
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    [JsonPropertyName("Royals_2v2_2025")]
    public ProgressType? Royals2v2_2025 { get; internal set; }

    /// <summary>
    /// </summary>
    [JsonInclude]
    [JsonPropertyName("Royals_2v2")]
    public ProgressType? Royals2v2 { get; internal set; }
}
