using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
public enum TournamentTypeEnum
{
    /// <summary>
    /// </summary>
    [EnumMember(Value = "OPEN")]
    Open,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "PASSWORD_PROTECTED")]
    PasswordProtected,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown
}
