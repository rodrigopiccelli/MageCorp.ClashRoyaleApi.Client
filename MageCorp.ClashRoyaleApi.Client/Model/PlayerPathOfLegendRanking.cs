namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PlayerPathOfLegendRanking
{
    /// <summary>
    /// </summary>
    public PlayerRankingClan? Clan { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Tag { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    public int ExpLevel { get; internal set; }
    /// <summary>
    /// </summary>
    public int Rank { get; internal set; }
    /// <summary>
    /// </summary>
    public int EloRating { get; internal set; }
}
