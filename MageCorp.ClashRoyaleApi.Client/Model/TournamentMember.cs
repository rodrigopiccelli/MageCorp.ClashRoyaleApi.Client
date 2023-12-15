namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class TournamentMember
{
    /// <summary>
    /// </summary>
    public PlayerClan? Clan { get; internal set; }
    /// <summary>
    /// </summary>
    public int Rank { get; internal set; }
    /// <summary>
    /// </summary>
    public int PreviousRank { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Tag { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    public int Score { get; internal set; }
}
