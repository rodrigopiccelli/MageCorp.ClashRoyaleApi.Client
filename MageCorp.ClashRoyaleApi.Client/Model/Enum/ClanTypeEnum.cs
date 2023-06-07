using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

public enum ClanTypeEnum
{
    [EnumMember(Value = "OPEN")]
    Open,
    [EnumMember(Value = "INVITE_ONLY")]
    InviteOnly,
    [EnumMember(Value = "CLOSED")]
    Closed
}
