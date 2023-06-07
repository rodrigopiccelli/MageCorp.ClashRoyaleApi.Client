namespace MageCorp.ClashRoyaleApi.Client.Model;

public class LadderTournamentRanking
{
    public PlayerRankingClan? Clan { get; set; }
    public int Wins { get; set; }
    public int Losses { get; set; }
    public string? Tag { get; set; }
    public string? Name { get; set; }
    public int Rank { get; set; }
    public int PreviousRank { get; set; }
}
