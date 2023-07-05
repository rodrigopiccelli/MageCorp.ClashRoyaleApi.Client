using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
public enum MatchStateEnum
{
    /// <summary>
    /// </summary>
    [EnumMember(Value = "PENDING")]
    Pending,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "CANCELLED")]
    Cancelled,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "TIMED_OUT")]
    TimedOut,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "IN_PROGRESS")]
    InProgress,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "COMPLETE")]
    Complete,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "FAILED")]
    Failed
}
