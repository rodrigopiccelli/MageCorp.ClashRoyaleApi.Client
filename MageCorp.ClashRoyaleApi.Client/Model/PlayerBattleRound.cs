namespace MageCorp.ClashRoyaleApi.Client.Model;

public class PlayerBattleRound
{
    public PlayerCardList? Cards { get; set; }
    public float ElixirLeaked { get; set; }
    public int Crowns { get; set; }
    public int KingTowerHitPoints { get; set; }
    public object? PrincessTowersHitPoints { get; set; }
}
