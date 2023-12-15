using MageCorp.ClashRoyaleApi.Client.Model.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Clan: ApiResponse
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public List<ClanMember>? MemberList { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Tag { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public ClanChestStatusEnum ClanChestStatus { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ClanChestLevel { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int RequiredTrophies { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int DonationsPerWeek { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ClanScore { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ClanChestMaxLevel { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ClanWarTrophies { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int BadgeId { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Location? Location { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public ClanTypeEnum Type { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Members { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Description { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ClanChestPoints { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public BadgeUrls? BadgeUrls { get; internal set; }
}
