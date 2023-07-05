namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Challenge
{
    /// <summary>
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// </summary>
    public string? WinMode { get; set; }
    /// <summary>
    /// </summary>
    public bool Casual { get; set; }
    /// <summary>
    /// </summary>
    public int MaxLosses { get; set; }
    /// <summary>
    /// </summary>
    public int MaxWins { get; set; }
    /// <summary>
    /// </summary>
    public Uri? IconUrl { get; set; }
    /// <summary>
    /// </summary>
    public ChallengeGameMode? GameMode { get; set; }
    /// <summary>
    /// </summary>
    public SurvivalMilestoneRewardList? Prizes { get; set; }
}
