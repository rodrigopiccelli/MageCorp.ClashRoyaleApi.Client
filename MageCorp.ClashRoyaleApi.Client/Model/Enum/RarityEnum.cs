using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
public enum RarityEnum
{
    /// <summary>
    /// </summary>
    [EnumMember(Value = "COMMON")]
    Common,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "RARE")]
    Rare,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "EPIC")]
    Epic,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "LEGENDARY")]
    Legendary,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "CHAMPION")]
    Champion
}
