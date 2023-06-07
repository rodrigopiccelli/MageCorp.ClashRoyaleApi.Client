using System.Runtime.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Enum;

public enum DeckSelectionEnum
{
    [EnumMember(Value = "COLLECTION")]
    Collection,
    [EnumMember(Value = "DRAFT")]
    Draft,
    [EnumMember(Value = "DRAFT_COMPETITIVE")]
    DraftCompetitive,
    [EnumMember(Value = "PREDEFINED")]
    Predefined,
    [EnumMember(Value = "EVENT_DECK")]
    EventDeck,
    [EnumMember(Value = "PICK")]
    Pick,
    [EnumMember(Value = "WARDECK_PICK")]
    WardeckPick,
    [EnumMember(Value = "QUADDECK_PICK")]
    QuaddeckPick,
    [EnumMember(Value = "UNKNOWN")]
    Unknown
}
