using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

public enum SurvivalMilestoneRewardTypeEnum
{
    [EnumMember(Value = "NONE")]
    None,
    [EnumMember(Value = "CARD_STACK")]
    CardStack,
    [EnumMember(Value = "CHEST")]
    Chest,
    [EnumMember(Value = "CARD_STACK_RANDOM")]
    CardStackRandom,
    [EnumMember(Value = "RESOURCE")]
    Resource,
    [EnumMember(Value = "TRADE_TOKEN")]
    TradeToken,
    [EnumMember(Value = "CONSUMABLE")]
    Consumable
}
