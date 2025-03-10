﻿using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

/// <summary>
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DeckSelection
{
    /// <summary>
    /// </summary>
    [EnumMember(Value = "COLLECTION")]
    Collection,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "DRAFT")]
    Draft,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "DRAFT_COMPETITIVE")]
    DraftCompetitive,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "PREDEFINED")]
    Predefined,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "EVENT_DECK")]
    EventDeck,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "PICK")]
    Pick,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "WARDECK_PICK")]
    WardeckPick,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "QUADDECK_PICK")]
    QuaddeckPick,
    /// <summary>
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown
}
