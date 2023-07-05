﻿using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
public enum GameModeEnum
{
    /// <summary>
    /// </summary>
    [EnumMember(Value = "REGULAR")]
    Regular,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "TEAM_VS_TEAM")]
    TeamVsTeam,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "DOUBLE_ELIXIR")]
    DoubleElixir,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "TRIPLE_ELIXIR")]
    TripleElixir,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "RAGE")]
    Rage,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "SUDDEN_DEATH")]
    SuddenDeath,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "TOUCHDOWN")]
    Touchdown,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "RAMP_UP")]
    RampUp,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "DRAFT")]
    Draft,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "MIRROR")]
    Mirror,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "DRAGON_HUNT")]
    DragonHunt,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "TRIPLE_DRAFT")]
    TripleDraft,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "BEST_OF_3")]
    BestOfThree
}
