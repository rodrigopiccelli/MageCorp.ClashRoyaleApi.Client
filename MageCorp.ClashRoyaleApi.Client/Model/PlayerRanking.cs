namespace MageCorp.ClashRoyaleApi.Client.Model;

public class PlayerRanking
{
    public PlayerRankingClan? Clan { get; set; }
    public Arena? Arena { get; set; }
    public string? Tag { get; set; }
    public string? Name { get; set; }
    public int ExpLevel { get; set; }
    public int Rank { get; set; }
    public int PreviousRank { get; set; }
    public int Trophies { get; set; }
}
