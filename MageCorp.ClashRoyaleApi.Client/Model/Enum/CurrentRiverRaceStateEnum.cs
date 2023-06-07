using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

public enum CurrentRiverRaceStateEnum
{
    [EnumMember(Value = "CLAN_NOT_FOUND")]
    ClanNotFound,
    [EnumMember(Value = "MATCHMAKING")]
    Matchmaking,
    [EnumMember(Value = "MATCHED")]
    Matched,
    [EnumMember(Value = "FULL")]
    Full,
    [EnumMember(Value = "ENDED")]
    Ended
}
