using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PlayerAchievementProgress
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Stars { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Value { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Target { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public object? Info { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public object? CompletionInfo { get; internal set; }
}
