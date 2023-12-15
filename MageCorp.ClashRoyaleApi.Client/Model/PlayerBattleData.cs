namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PlayerBattleData
{
    /// <summary>
    /// </summary>
    public int Crowns { get; internal set; }
    /// <summary>
    /// </summary>
    public List<int>? PrincessTowersHitPoints { get; internal set; }
    /// <summary>
    /// </summary>
    public PlayerClan? Clan { get; internal set; }
    /// <summary>
    /// </summary>
    public PlayerCardList? Cards { get; internal set; }
    /// <summary>
    /// </summary>
    public PlayerCardList? SupportCards { get; internal set; }
    /// <summary>
    /// </summary>
    public int? GlobalRank { get; internal set; }
    /// <summary>
    /// </summary>
    public float ElixirLeaked { get; internal set; }
    /// <summary>
    /// </summary>
    public PlayerBattleRoundList? Rounds { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Tag { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    public int StartingTrophies { get; internal set; }
    /// <summary>
    /// </summary>
    public int TrophyChange { get; internal set; }
    /// <summary>
    /// </summary>
    public int KingTowerHitPoints { get; internal set; }
}
