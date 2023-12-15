using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum RoleEnum
{
    /// <summary>
    /// </summary>
    [EnumMember(Value = "NOT_MEMBER")]
    NotMember,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "MEMBER")]
    Member,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "LEADER")]
    Leader,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "ADMIN")]
    Admin,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "COLEADER")]
    Coleader,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "ELDER")]
    Elder
}
