using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PlayerBattleData
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Crowns { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public List<int>? PrincessTowersHitPoints { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PlayerClan? Clan { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PlayerCardList? Cards { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PlayerCardList? SupportCards { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int? GlobalRank { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public float ElixirLeaked { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PlayerBattleRoundList? Rounds { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Tag { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int StartingTrophies { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int TrophyChange { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int KingTowerHitPoints { get; internal set; }
}
