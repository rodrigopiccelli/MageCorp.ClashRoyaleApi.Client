using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CurrentClanWarState
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
