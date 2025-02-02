using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ClanChestStatus
{
    /// <summary>
    /// </summary>
    [EnumMember(Value = "INACTIVE")]
    Inactive,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "ACTIVE")]
    Active,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "COMPLETED")]
    Completed,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown
}
