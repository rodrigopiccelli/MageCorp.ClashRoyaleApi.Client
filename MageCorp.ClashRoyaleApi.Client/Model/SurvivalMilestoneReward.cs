using MageCorp.ClashRoyaleApi.Client.Model.Enum;

namespace MageCorp.ClashRoyaleApi.Client.Model;

public class SurvivalMilestoneReward
{
    public string? Chest { get; set; }
    public RarityEnum Rarity { get; set; }
    public ResourceEnum Resource { get; set; }
    public SurvivalMilestoneRewardTypeEnum Type { get; set; }
    public int Amount { get; set; }
    public Card? Card { get; set; }
    public string? ConsumableName { get; set; }
    public int Wins { get; set; }
}
