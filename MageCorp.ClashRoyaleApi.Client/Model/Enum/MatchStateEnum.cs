using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

public enum MatchStateEnum
{
    [EnumMember(Value = "PENDING")]
    Pending,
    [EnumMember(Value = "CANCELLED")]
    Cancelled,
    [EnumMember(Value = "TIMED_OUT")]
    TimedOut,
    [EnumMember(Value = "IN_PROGRESS")]
    InProgress,
    [EnumMember(Value = "COMPLETE")]
    Complete,
    [EnumMember(Value = "FAILED")]
    Failed
}
