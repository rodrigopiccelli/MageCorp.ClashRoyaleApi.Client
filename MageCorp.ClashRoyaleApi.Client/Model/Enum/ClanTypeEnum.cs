using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
public enum ClanTypeEnum
{
    /// <summary>
    /// </summary>
    [EnumMember(Value = "OPEN")]
    Open,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "INVITE_ONLY")]
    InviteOnly,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "CLOSED")]
    Closed
}
