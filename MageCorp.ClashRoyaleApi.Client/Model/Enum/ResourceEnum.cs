using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ResourceEnum
{
    /// <summary>
    /// </summary>
    [EnumMember(Value = "GOLD")]
    Gold,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown
}
