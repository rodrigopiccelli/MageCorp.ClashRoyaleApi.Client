using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Challenge
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Description { get; internal set; }
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
    public string? WinMode { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public bool Casual { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int MaxLosses { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int MaxWins { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Uri? IconUrl { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public ChallengeGameMode? GameMode { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public SurvivalMilestoneRewardList? Prizes { get; internal set; }
}
