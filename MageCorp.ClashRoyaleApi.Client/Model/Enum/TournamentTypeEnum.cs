using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
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
