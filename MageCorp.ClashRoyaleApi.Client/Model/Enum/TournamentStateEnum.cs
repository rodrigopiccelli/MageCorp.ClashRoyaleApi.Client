using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
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
