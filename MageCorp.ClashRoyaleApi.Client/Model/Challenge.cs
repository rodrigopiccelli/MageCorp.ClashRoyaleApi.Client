namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Challenge
{
    /// <summary>
    /// </summary>
    public string? Description { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    public int Id { get; internal set; }
    /// <summary>
    /// </summary>
    public string? WinMode { get; internal set; }
    /// <summary>
    /// </summary>
    public bool Casual { get; internal set; }
    /// <summary>
    /// </summary>
    public int MaxLosses { get; internal set; }
    /// <summary>
    /// </summary>
    public int MaxWins { get; internal set; }
    /// <summary>
    /// </summary>
    public Uri? IconUrl { get; internal set; }
    /// <summary>
    /// </summary>
    public ChallengeGameMode? GameMode { get; internal set; }
    /// <summary>
    /// </summary>
    public SurvivalMilestoneRewardList? Prizes { get; internal set; }
}
