using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

public enum GameModeEnum
{
    [EnumMember(Value = "REGULAR")]
    Regular,
    [EnumMember(Value = "TEAM_VS_TEAM")]
    TeamVsTeam,
    [EnumMember(Value = "DOUBLE_ELIXIR")]
    DoubleElixir,
    [EnumMember(Value = "TRIPLE_ELIXIR")]
    TripleElixir,
    [EnumMember(Value = "RAGE")]
    Rage,
    [EnumMember(Value = "SUDDEN_DEATH")]
    SuddenDeath,
    [EnumMember(Value = "TOUCHDOWN")]
    Touchdown,
    [EnumMember(Value = "RAMP_UP")]
    RampUp,
    [EnumMember(Value = "DRAFT")]
    Draft,
    [EnumMember(Value = "MIRROR")]
    Mirror,
    [EnumMember(Value = "DRAGON_HUNT")]
    DragonHunt,
    [EnumMember(Value = "TRIPLE_DRAFT")]
    TripleDraft,
    [EnumMember(Value = "BEST_OF_3")]
    BestOfThree
}
