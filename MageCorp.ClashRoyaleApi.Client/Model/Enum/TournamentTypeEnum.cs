using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

public enum TournamentTypeEnum
{
    [EnumMember(Value = "OPEN")]
    Open,
    [EnumMember(Value = "PASSWORD_PROTECTED")]
    PasswordProtected,
    [EnumMember(Value = "UNKNOWN")]
    Unknown
}
