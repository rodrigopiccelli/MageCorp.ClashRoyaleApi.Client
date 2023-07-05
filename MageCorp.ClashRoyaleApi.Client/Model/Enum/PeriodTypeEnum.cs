using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
public enum PeriodTypeEnum
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
