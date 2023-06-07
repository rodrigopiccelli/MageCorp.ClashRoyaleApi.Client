using MageCorp.ClashRoyaleApi.Client.Converter;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

public class Battle
{
    public BattleTypeEnum Type { get; set; }
    public string? Name { get; set; }
    public DeckSelectionEnum DeckSelection { get; set; }
    public PlayerBattleDataList? Team { get; set; }
    public PlayerBattleDataList? Opponent { get; set; }
    public int ChallengeWinCountBefore { get; set; }
    public string? BoatBattleSide { get; set; }
    public bool BoatBattleWon { get; set; }
    public int NewTowersDestroyed { get; set; }
    public int PrevTowersDestroyed { get; set; }
    public int RemainingTowers { get; set; }
    public Arena? Arena { get; set; }
    public GameMode? GameMode { get; set; }
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? BattleTime { get; set; }
    public int ChallengeId { get; set; }
    public string? TournamentTag { get; set; }
    public string? ChallengeTitle { get; set; }
    public bool IsLadderTournament { get; set; }
    public bool IsHostedMatch { get; set; }
}



