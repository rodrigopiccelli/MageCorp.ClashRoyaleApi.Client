namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PlayerRanking
{
    /// <summary>
    /// </summary>
    public PlayerRankingClan? Clan { get; set; }
    /// <summary>
    /// </summary>
    public Arena? Arena { get; set; }
    /// <summary>
    /// </summary>
    public string? Tag { get; set; }
    /// <summary>
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// </summary>
    public int ExpLevel { get; set; }
    /// <summary>
    /// </summary>
    public int Rank { get; set; }
    /// <summary>
    /// </summary>
    public int PreviousRank { get; set; }
    /// <summary>
    /// </summary>
    public int Trophies { get; set; }
}
