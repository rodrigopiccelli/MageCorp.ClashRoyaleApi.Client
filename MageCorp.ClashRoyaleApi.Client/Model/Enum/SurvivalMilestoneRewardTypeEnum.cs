using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
public enum SurvivalMilestoneRewardTypeEnum
{
    /// <summary>
    /// </summary>
    [EnumMember(Value = "NONE")]
    None,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "CARD_STACK")]
    CardStack,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "CHEST")]
    Chest,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "CARD_STACK_RANDOM")]
    CardStackRandom,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "RESOURCE")]
    Resource,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "TRADE_TOKEN")]
    TradeToken,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "CONSUMABLE")]
    Consumable
}
