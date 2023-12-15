namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class LadderTournamentRanking
{
    /// <summary>
    /// </summary>
    public PlayerRankingClan? Clan { get; internal set; }
    /// <summary>
    /// </summary>
    public int Wins { get; internal set; }
    /// <summary>
    /// </summary>
    public int Losses { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Tag { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    public int Rank { get; internal set; }
    /// <summary>
    /// </summary>
    public int PreviousRank { get; internal set; }
}
