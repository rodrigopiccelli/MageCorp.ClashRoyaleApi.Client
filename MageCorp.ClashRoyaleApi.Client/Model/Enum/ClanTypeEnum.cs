using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
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
