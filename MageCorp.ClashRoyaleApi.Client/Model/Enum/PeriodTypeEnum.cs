using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

public enum PeriodTypeEnum
{
    [EnumMember(Value = "TRAINING")]
    Training,
    [EnumMember(Value = "WAR_DAY")]
    WarDay,
    [EnumMember(Value = "COLOSSEUM")]
    Colosseum
}
