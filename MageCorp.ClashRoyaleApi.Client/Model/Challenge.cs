namespace MageCorp.ClashRoyaleApi.Client.Model;

public class Challenge
{
    public string? Description { get; set; }
    public string? Name { get; set; }
    public int Id { get; set; }
    public string? WinMode { get; set; }
    public bool Casual { get; set; }
    public int MaxLosses { get; set; }
    public int MaxWins { get; set; }
    public string? IconUrl { get; set; }
    public ChallengeGameMode? GameMode { get; set; }
    public SurvivalMilestoneRewardList? Prizes { get; set; }
}
