using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PeriodType
{
    /// <summary>
    /// </summary>
    [EnumMember(Value = "TRAINING")]
    Training,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "WAR_DAY")]
    WarDay,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "COLOSSEUM")]
    Colosseum
}
