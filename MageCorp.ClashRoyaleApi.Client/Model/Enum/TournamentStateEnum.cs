using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

public enum TournamentStateEnum
{
    [EnumMember(Value = "IN_PREPARATION")]
    InPreparation,
    [EnumMember(Value = "IN_PROGRESS")]
    InProgress,
    [EnumMember(Value = "ENDED")]
    Ended,
    [EnumMember(Value = "UNKNOWN")]
    Unknown
}
