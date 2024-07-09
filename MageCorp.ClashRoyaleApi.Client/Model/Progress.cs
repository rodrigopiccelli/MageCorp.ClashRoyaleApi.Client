using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Progress
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    [JsonPropertyName("goblin-road")]
    public GoblinRoad? GoblinRoad { get; internal set; }
}
