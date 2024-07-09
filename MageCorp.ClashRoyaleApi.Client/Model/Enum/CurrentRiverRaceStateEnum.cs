using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CurrentRiverRaceStateEnum
{
    /// <summary>
    /// </summary>
    [EnumMember(Value = "CLAN_NOT_FOUND")]
    ClanNotFound,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "ACCESS_DENIED")]
    AccessDenied,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "MATCHMAKING")]
    Matchmaking,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "MATCHED")]
    Matched,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "FULL")]
    Full,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "ENDED")]
    Ended
}
