using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

public enum RarityEnum
{
    [EnumMember(Value = "COMMON")]
    Common,
    [EnumMember(Value = "RARE")]
    Rare,
    [EnumMember(Value = "EPIC")]
    Epic,
    [EnumMember(Value = "LEGENDARY")]
    Legendary,
    [EnumMember(Value = "HERO")]
    Hero
}
