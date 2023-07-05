namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class LadderTournamentRanking
{
    /// <summary>
    /// </summary>
    public PlayerRankingClan? Clan { get; set; }
    /// <summary>
    /// </summary>
    public int Wins { get; set; }
    /// <summary>
    /// </summary>
    public int Losses { get; set; }
    /// <summary>
    /// </summary>
    public string? Tag { get; set; }
    /// <summary>
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// </summary>
    public int Rank { get; set; }
    /// <summary>
    /// </summary>
    public int PreviousRank { get; set; }
}
