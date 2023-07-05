using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
public enum TournamentStateEnum
{
    /// <summary>
    /// </summary>
    [EnumMember(Value = "IN_PREPARATION")]
    InPreparation,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "IN_PROGRESS")]
    InProgress,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "ENDED")]
    Ended,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown
}
