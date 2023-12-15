using MageCorp.ClashRoyaleApi.Client.Model.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Clan: ApiResponse
{
    /// <summary>
    /// </summary>
    public List<ClanMember>? MemberList { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Tag { get; internal set; }
    /// <summary>
    /// </summary>
    public ClanChestStatusEnum ClanChestStatus { get; internal set; }
    /// <summary>
    /// </summary>
    public int ClanChestLevel { get; internal set; }
    /// <summary>
    /// </summary>
    public int RequiredTrophies { get; internal set; }
    /// <summary>
    /// </summary>
    public int DonationsPerWeek { get; internal set; }
    /// <summary>
    /// </summary>
    public int ClanScore { get; internal set; }
    /// <summary>
    /// </summary>
    public int ClanChestMaxLevel { get; internal set; }
    /// <summary>
    /// </summary>
    public int ClanWarTrophies { get; internal set; }
    /// <summary>
    /// </summary>
    public int BadgeId { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    public Location? Location { get; internal set; }
    /// <summary>
    /// </summary>
    public ClanTypeEnum Type { get; internal set; }
    /// <summary>
    /// </summary>
    public int Members { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Description { get; internal set; }
    /// <summary>
    /// </summary>
    public int ClanChestPoints { get; internal set; }
    /// <summary>
    /// </summary>
    public BadgeUrls? BadgeUrls { get; internal set; }
}
