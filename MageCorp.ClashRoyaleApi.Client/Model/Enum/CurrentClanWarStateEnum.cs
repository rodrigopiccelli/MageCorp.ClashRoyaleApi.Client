using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

public enum CurrentClanWarStateEnum
{
    [EnumMember(Value = "CLAN_NOT_FOUND")]
    ClanNotFound,
    [EnumMember(Value = "ACCESS_DENIED")]
    AccessDenied,
    [EnumMember(Value = "NOT_IN_WAR")]
    NotInWar,
    [EnumMember(Value = "COLLECTION_DAY")]
    CollectionDay,
    [EnumMember(Value = "MATCHMAKING")]
    Matchmaking,
    [EnumMember(Value = "WAR_DAY")]
    WarDay,
    [EnumMember(Value = "ENDED")]
    Ended
}
