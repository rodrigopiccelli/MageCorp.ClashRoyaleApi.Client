using MageCorp.ClashRoyaleApi.Client.Converter;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Battle
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public BattleTypeEnum Type { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public DeckSelectionEnum DeckSelection { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PlayerBattleDataList? Team { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PlayerBattleDataList? Opponent { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ChallengeWinCountBefore { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? BoatBattleSide { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public bool BoatBattleWon { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int NewTowersDestroyed { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int PrevTowersDestroyed { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int RemainingTowers { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Arena? Arena { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public GameMode? GameMode { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? BattleTime { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ChallengeId { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? TournamentTag { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? ChallengeTitle { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public bool IsLadderTournament { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public bool IsHostedMatch { get; internal set; }
}



