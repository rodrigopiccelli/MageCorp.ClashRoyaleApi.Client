using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
public enum CurrentClanWarStateEnum
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
    [EnumMember(Value = "NOT_IN_WAR")]
    NotInWar,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "COLLECTION_DAY")]
    CollectionDay,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "MATCHMAKING")]
    Matchmaking,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "WAR_DAY")]
    WarDay,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "ENDED")]
    Ended
}
