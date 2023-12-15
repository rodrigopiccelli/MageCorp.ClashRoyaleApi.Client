namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PlayerAchievementProgress
{
    /// <summary>
    /// </summary>
    public int Stars { get; internal set; }
    /// <summary>
    /// </summary>
    public int Value { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    public int Target { get; internal set; }
    /// <summary>
    /// </summary>
    public object? Info { get; internal set; }
    /// <summary>
    /// </summary>
    public object? CompletionInfo { get; internal set; }
}
