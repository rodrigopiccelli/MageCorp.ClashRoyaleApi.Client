using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

public enum ClanChestStatusEnum
{
    [EnumMember(Value = "INACTIVE")]
    Inactive,
    [EnumMember(Value = "ACTIVE")]
    Active,
    [EnumMember(Value = "COMPLETED")]
    Completed,
    [EnumMember(Value = "UNKNOWN")]
    Unknown
}
