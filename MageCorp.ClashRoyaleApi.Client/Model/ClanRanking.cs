namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class ClanRanking
{
    /// <summary>
    /// </summary>
    public int ClanScore { get; internal set; }
    /// <summary>
    /// </summary>
    public int BadgeId { get; internal set; }
    /// <summary>
    /// </summary>
    public Location? Location { get; internal set; }
    /// <summary>
    /// </summary>
    public int Members { get; internal set; }
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
    /// <summary>
    /// </summary>
    public BadgeUrls? BadgeUrls { get; internal set; }
}
