using MageCorp.ClashRoyaleApi.Client.Model.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Clan: ApiResponse
{
    /// <summary>
    /// </summary>
    public ClanMemberList? MemberList { get; set; }
    /// <summary>
    /// </summary>
    public string? Tag { get; set; }
    /// <summary>
    /// </summary>
    public ClanChestStatusEnum ClanChestStatus { get; set; }
    /// <summary>
    /// </summary>
    public int ClanChestLevel { get; set; }
    /// <summary>
    /// </summary>
    public int RequiredTrophies { get; set; }
    /// <summary>
    /// </summary>
    public int DonationsPerWeek { get; set; }
    /// <summary>
    /// </summary>
    public int ClanScore { get; set; }
    /// <summary>
    /// </summary>
    public int ClanChestMaxLevel { get; set; }
    /// <summary>
    /// </summary>
    public int ClanWarTrophies { get; set; }
    /// <summary>
    /// </summary>
    public int BadgeId { get; set; }
    /// <summary>
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// </summary>
    public Location? Location { get; set; }
    /// <summary>
    /// </summary>
    public ClanTypeEnum Type { get; set; }
    /// <summary>
    /// </summary>
    public int Members { get; set; }
    /// <summary>
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// </summary>
    public int ClanChestPoints { get; set; }
    /// <summary>
    /// </summary>
    public BadgeUrls? BadgeUrls { get; set; }
}
