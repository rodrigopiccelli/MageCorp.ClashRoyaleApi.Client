using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
public enum CurrentRiverRaceStateEnum
{
    /// <summary>
    /// </summary>
    [EnumMember(Value = "CLAN_NOT_FOUND")]
    ClanNotFound,
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
