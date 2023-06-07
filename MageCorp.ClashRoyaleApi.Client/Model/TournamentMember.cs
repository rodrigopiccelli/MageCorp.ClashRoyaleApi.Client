namespace MageCorp.ClashRoyaleApi.Client.Model;

public class TournamentMember
{
    public PlayerClan? Clan { get; set; }
    public int Rank { get; set; }
    public int PreviousRank { get; set; }
    public string? Tag { get; set; }
    public string? Name { get; set; }
    public int Score { get; set; }
}
