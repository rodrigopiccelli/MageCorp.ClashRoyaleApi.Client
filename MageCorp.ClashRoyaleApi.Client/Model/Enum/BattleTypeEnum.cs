using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

public enum BattleTypeEnum
{
    [EnumMember(Value = "PVP")]
    PVP,
    [EnumMember(Value = "PVE")]
    PVE,
    [EnumMember(Value = "CLANMATE")]
    Clanmate,
    [EnumMember(Value = "TOURNAMENT")]
    Tournament,
    [EnumMember(Value = "FRIENDLY")]
    Friendly,
    [EnumMember(Value = "SURVIVAL")]
    Survival,
    [EnumMember(Value = "PVP2v2")]
    Pvp2v2,
    [EnumMember(Value = "CLANMATE2v2")]
    Clanmate2v2,
    [EnumMember(Value = "CHALLENGE2v2")]
    Challenge2v2,
    [EnumMember(Value = "CLANWAR_COLLECTION_DAY")]
    ClanwarCollectionDay,
    [EnumMember(Value = "CLANWAR_WAR_DAY")]
    ClanwarWarDay,
    [EnumMember(Value = "CASUAL_1V1")]
    Casual1v1,
    [EnumMember(Value = "CASUAL_2V2")]
    Casual2v2,
    [EnumMember(Value = "BOAT_BATTLE")]
    BoatBattle,
    [EnumMember(Value = "BOAT_BATTLE_PRACTICE")]
    BoatBattlePractice,
    [EnumMember(Value = "RIVER_RACE_PVP")]
    RiverRacePvp,
    [EnumMember(Value = "RIVER_RACE_DUEL")]
    RiverRaceDuel,
    [EnumMember(Value = "RIVER_RACE_DUEL_COLOSSEUM")]
    RiverRaceDuelColosseum,
    [EnumMember(Value = "TUTORIAL")]
    Tutorial,
    [EnumMember(Value = "PATH_OF_LEGEND")]
    PathOfLegend,
    [EnumMember(Value = "UNKNOWN")]
    Unknown
}
