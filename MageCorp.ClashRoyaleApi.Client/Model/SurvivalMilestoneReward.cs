using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class SurvivalMilestoneReward
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Chest { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Rarity? Rarity { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Resource? Resource { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public SurvivalMilestoneRewardType? Type { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Amount { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Card? Card { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? ConsumableName { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Wins { get; internal set; }
}
