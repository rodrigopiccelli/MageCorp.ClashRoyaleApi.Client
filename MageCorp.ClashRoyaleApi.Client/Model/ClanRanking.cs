namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class ClanRanking
{
    /// <summary>
    /// </summary>
    public int ClanScore { get; set; }
    /// <summary>
    /// </summary>
    public int BadgeId { get; set; }
    /// <summary>
    /// </summary>
    public Location? Location { get; set; }
    /// <summary>
    /// </summary>
    public int Members { get; set; }
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
    /// <summary>
    /// </summary>
    public BadgeUrls? BadgeUrls { get; set; }
}
