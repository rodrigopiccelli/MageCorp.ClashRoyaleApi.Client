using MageCorp.ClashRoyaleApi.Client.Model.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;

namespace MageCorp.ClashRoyaleApi.Client.Model;

public class Clan: ApiResponse
{
    public ClanMemberList? MemberList { get; set; }
    public string? Tag { get; set; }
    public ClanChestStatusEnum ClanChestStatus { get; set; }
    public int ClanChestLevel { get; set; }
    public int RequiredTrophies { get; set; }
    public int DonationsPerWeek { get; set; }
    public int ClanScore { get; set; }
    public int ClanChestMaxLevel { get; set; }
    public int ClanWarTrophies { get; set; }
    public int BadgeId { get; set; }
    public string? Name { get; set; }
    public Location? Location { get; set; }
    public ClanTypeEnum Type { get; set; }
    public int Members { get; set; }
    public string? Description { get; set; }
    public int ClanChestPoints { get; set; }
    public BadgeUrls? BadgeUrls { get; set; }
}
