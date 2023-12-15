using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PlayerAchievementBadge
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public IconUrls? IconUrls { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int MaxLevel { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Progress { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Level { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Target { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Name { get; internal set; }
}



