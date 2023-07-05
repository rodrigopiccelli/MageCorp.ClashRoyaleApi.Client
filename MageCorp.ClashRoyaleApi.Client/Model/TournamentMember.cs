namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class TournamentMember
{
    /// <summary>
    /// </summary>
    public PlayerClan? Clan { get; set; }
    /// <summary>
    /// </summary>
    public int Rank { get; set; }
    /// <summary>
    /// </summary>
    public int PreviousRank { get; set; }
    /// <summary>
    /// </summary>
    public string? Tag { get; set; }
    /// <summary>
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// </summary>
    public int Score { get; set; }
}
