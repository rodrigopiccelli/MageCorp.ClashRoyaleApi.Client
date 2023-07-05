using MageCorp.ClashRoyaleApi.Client.Model.Enum;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class SurvivalMilestoneReward
{
    /// <summary>
    /// </summary>
    public string? Chest { get; set; }
    /// <summary>
    /// </summary>
    public RarityEnum Rarity { get; set; }
    /// <summary>
    /// </summary>
    public ResourceEnum Resource { get; set; }
    /// <summary>
    /// </summary>
    public SurvivalMilestoneRewardTypeEnum Type { get; set; }
    /// <summary>
    /// </summary>
    public int Amount { get; set; }
    /// <summary>
    /// </summary>
    public Card? Card { get; set; }
    /// <summary>
    /// </summary>
    public string? ConsumableName { get; set; }
    /// <summary>
    /// </summary>
    public int Wins { get; set; }
}
