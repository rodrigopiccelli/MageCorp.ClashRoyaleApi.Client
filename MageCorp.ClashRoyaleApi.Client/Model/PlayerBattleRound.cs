namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PlayerBattleRound
{
    /// <summary>
    /// </summary>
    public PlayerCardList? Cards { get; internal set; }
    /// <summary>
    /// </summary>
    public float ElixirLeaked { get; internal set; }
    /// <summary>
    /// </summary>
    public int Crowns { get; internal set; }
    /// <summary>
    /// </summary>
    public int KingTowerHitPoints { get; internal set; }
    /// <summary>
    /// </summary>
    public List<int>? PrincessTowersHitPoints { get; internal set; }
}
