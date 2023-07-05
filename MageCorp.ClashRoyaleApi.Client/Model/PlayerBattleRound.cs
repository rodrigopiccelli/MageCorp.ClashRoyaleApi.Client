namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PlayerBattleRound
{
    /// <summary>
    /// </summary>
    public PlayerCardList? Cards { get; set; }
    /// <summary>
    /// </summary>
    public float ElixirLeaked { get; set; }
    /// <summary>
    /// </summary>
    public int Crowns { get; set; }
    /// <summary>
    /// </summary>
    public int KingTowerHitPoints { get; set; }
    /// <summary>
    /// </summary>
    public List<int>? PrincessTowersHitPoints { get; set; }
}
