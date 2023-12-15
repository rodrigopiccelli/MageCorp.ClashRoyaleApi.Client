using MageCorp.ClashRoyaleApi.Client.Converter;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Battle
{
    /// <summary>
    /// </summary>
    public BattleTypeEnum Type { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    public DeckSelectionEnum DeckSelection { get; internal set; }
    /// <summary>
    /// </summary>
    public PlayerBattleDataList? Team { get; internal set; }
    /// <summary>
    /// </summary>
    public PlayerBattleDataList? Opponent { get; internal set; }
    /// <summary>
    /// </summary>
    public int ChallengeWinCountBefore { get; internal set; }
    /// <summary>
    /// </summary>
    public string? BoatBattleSide { get; internal set; }
    /// <summary>
    /// </summary>
    public bool BoatBattleWon { get; internal set; }
    /// <summary>
    /// </summary>
    public int NewTowersDestroyed { get; internal set; }
    /// <summary>
    /// </summary>
    public int PrevTowersDestroyed { get; internal set; }
    /// <summary>
    /// </summary>
    public int RemainingTowers { get; internal set; }
    /// <summary>
    /// </summary>
    public Arena? Arena { get; internal set; }
    /// <summary>
    /// </summary>
    public GameMode? GameMode { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? BattleTime { get; internal set; }
    /// <summary>
    /// </summary>
    public int ChallengeId { get; internal set; }
    /// <summary>
    /// </summary>
    public string? TournamentTag { get; internal set; }
    /// <summary>
    /// </summary>
    public string? ChallengeTitle { get; internal set; }
    /// <summary>
    /// </summary>
    public bool IsLadderTournament { get; internal set; }
    /// <summary>
    /// </summary>
    public bool IsHostedMatch { get; internal set; }
}



