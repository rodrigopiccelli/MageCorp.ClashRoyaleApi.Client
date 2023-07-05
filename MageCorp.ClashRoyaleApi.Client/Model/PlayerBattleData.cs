namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PlayerBattleData
{
    /// <summary>
    /// </summary>
    public int Crowns { get; set; }
    /// <summary>
    /// </summary>
    public List<int>? PrincessTowersHitPoints { get; set; }
    /// <summary>
    /// </summary>
    public PlayerClan? Clan { get; set; }
    /// <summary>
    /// </summary>
    public PlayerCardList? Cards { get; set; }
    /// <summary>
    /// </summary>
    public float ElixirLeaked { get; set; }
    /// <summary>
    /// </summary>
    public PlayerBattleRoundList? Rounds { get; set; }
    /// <summary>
    /// </summary>
    public string? Tag { get; set; }
    /// <summary>
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// </summary>
    public int StartingTrophies { get; set; }
    /// <summary>
    /// </summary>
    public int TrophyChange { get; set; }
    /// <summary>
    /// </summary>
    public int KingTowerHitPoin { get; set; }
}
