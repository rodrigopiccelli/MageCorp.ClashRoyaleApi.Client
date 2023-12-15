using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BattleTypeEnum
{
    /// <summary>
    /// </summary>
    [EnumMember(Value = "PVP")]
    PVP,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "PVE")]
    PVE,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "CLANMATE")]
    Clanmate,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "TOURNAMENT")]
    Tournament,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "FRIENDLY")]
    Friendly,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "SURVIVAL")]
    Survival,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "PVP2v2")]
    Pvp2v2,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "CLANMATE2v2")]
    Clanmate2v2,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "CHALLENGE2v2")]
    Challenge2v2,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "CLANWAR_COLLECTION_DAY")]
    ClanwarCollectionDay,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "CLANWAR_WAR_DAY")]
    ClanwarWarDay,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "CASUAL_1V1")]
    Casual1v1,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "CASUAL_2V2")]
    Casual2v2,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "BOAT_BATTLE")]
    BoatBattle,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "BOAT_BATTLE_PRACTICE")]
    BoatBattlePractice,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "RIVER_RACE_PVP")]
    RiverRacePvp,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "RIVER_RACE_DUEL")]
    RiverRaceDuel,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "RIVER_RACE_DUEL_COLOSSEUM")]
    RiverRaceDuelColosseum,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "TUTORIAL")]
    Tutorial,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "PATH_OF_LEGEND")]
    PathOfLegend,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown
}
