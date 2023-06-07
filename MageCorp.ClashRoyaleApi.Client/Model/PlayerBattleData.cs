namespace MageCorp.ClashRoyaleApi.Client.Model;

public class PlayerBattleData
{
    public int Crowns { get; set; }
    public List<int>? PrincessTowersHitPoints { get; set; }
    public PlayerClan? Clan { get; set; }
    public PlayerCardList? Cards { get; set; }
    public float ElixirLeaked { get; set; }
    public PlayerBattleRoundList? Rounds { get; set; }
    public string? Tag { get; set; }
    public string? Name { get; set; }
    public int StartingTrophies { get; set; }
    public int TrophyChange { get; set; }
    public int KingTowerHitPoin { get; set; }
}
