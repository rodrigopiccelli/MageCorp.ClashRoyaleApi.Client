namespace MageCorp.ClashRoyaleApi.Client.Model;

public class ClanRanking
{
    public int ClanScore { get; set; }
    public int BadgeId { get; set; }
    public Location? Location { get; set; }
    public int Members { get; set; }
    public string? Tag { get; set; }
    public string? Name { get; set; }
    public int Rank { get; set; }
    public int PreviousRank { get; set; }
    public BadgeUrls? BadgeUrls { get; set; }
}
