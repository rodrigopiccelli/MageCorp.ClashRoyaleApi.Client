using MageCorp.ClashRoyaleApi.Client.Model.Enum;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class SurvivalMilestoneReward
{
    /// <summary>
    /// </summary>
    public string? Chest { get; internal set; }
    /// <summary>
    /// </summary>
    public RarityEnum Rarity { get; internal set; }
    /// <summary>
    /// </summary>
    public ResourceEnum Resource { get; internal set; }
    /// <summary>
    /// </summary>
    public SurvivalMilestoneRewardTypeEnum Type { get; internal set; }
    /// <summary>
    /// </summary>
    public int Amount { get; internal set; }
    /// <summary>
    /// </summary>
    public Card? Card { get; internal set; }
    /// <summary>
    /// </summary>
    public string? ConsumableName { get; internal set; }
    /// <summary>
    /// </summary>
    public int Wins { get; internal set; }
}
