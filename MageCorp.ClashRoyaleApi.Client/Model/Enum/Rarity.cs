using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Rarity
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
