namespace MageCorp.ClashRoyaleApi.Client.Model;

public class PlayerPathOfLegendRanking
{
    public PlayerRankingClan? Clan { get; set; }
    public string? Tag { get; set; }
    public string? Name { get; set; }
    public int ExpLevel { get; set; }
    public int Rank { get; set; }
    public int EloRating { get; set; }
}
