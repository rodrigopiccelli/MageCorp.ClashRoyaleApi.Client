using MageCorp.ClashRoyaleApi.Client.Model.Enum;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class ClanMember
{
    /// <summary>
    /// </summary>
    public Arena? Arena { get; set; }
    /// <summary>
    /// </summary>
    public int ClanChestPoints { get; set; }
    /// <summary>
    /// </summary>
    public string? LastSeen { get; set; }
    /// <summary>
    /// </summary>
    public string? Tag { get; set; }
    /// <summary>
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// </summary>
    public RoleEnum Role { get; set; }
    /// <summary>
    /// </summary>
    public int ExpLevel { get; set; }
    /// <summary>
    /// </summary>
    public int Trophies { get; set; }
    /// <summary>
    /// </summary>
    public int ClanRank { get; set; }
    /// <summary>
    /// </summary>
    public int PreviousClanRank { get; set; }
    /// <summary>
    /// </summary>
    public int Donations { get; set; }
    /// <summary>
    /// </summary>
    public int DonationsReceived { get; set; }
}
