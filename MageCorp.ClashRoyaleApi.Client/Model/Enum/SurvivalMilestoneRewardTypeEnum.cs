using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SurvivalMilestoneRewardTypeEnum
{
    /// <summary>
    /// </summary>
    [EnumMember(Value = "none")]
    None,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "cardStack")]
    CardStack,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "chest")]
    Chest,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "cardStackRandom")]
    CardStackRandom,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "resource")]
    Resource,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "tradeToken")]
    TradeToken,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "consumable")]
    Consumable
}
