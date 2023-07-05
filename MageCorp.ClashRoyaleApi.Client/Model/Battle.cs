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
    public BattleTypeEnum Type { get; set; }
    /// <summary>
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// </summary>
    public DeckSelectionEnum DeckSelection { get; set; }
    /// <summary>
    /// </summary>
    public PlayerBattleDataList? Team { get; set; }
    /// <summary>
    /// </summary>
    public PlayerBattleDataList? Opponent { get; set; }
    /// <summary>
    /// </summary>
    public int ChallengeWinCountBefore { get; set; }
    /// <summary>
    /// </summary>
    public string? BoatBattleSide { get; set; }
    /// <summary>
    /// </summary>
    public bool BoatBattleWon { get; set; }
    /// <summary>
    /// </summary>
    public int NewTowersDestroyed { get; set; }
    /// <summary>
    /// </summary>
    public int PrevTowersDestroyed { get; set; }
    /// <summary>
    /// </summary>
    public int RemainingTowers { get; set; }
    /// <summary>
    /// </summary>
    public Arena? Arena { get; set; }
    /// <summary>
    /// </summary>
    public GameMode? GameMode { get; set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? BattleTime { get; set; }
    /// <summary>
    /// </summary>
    public int ChallengeId { get; set; }
    /// <summary>
    /// </summary>
    public string? TournamentTag { get; set; }
    /// <summary>
    /// </summary>
    public string? ChallengeTitle { get; set; }
    /// <summary>
    /// </summary>
    public bool IsLadderTournament { get; set; }
    /// <summary>
    /// </summary>
    public bool IsHostedMatch { get; set; }
}



