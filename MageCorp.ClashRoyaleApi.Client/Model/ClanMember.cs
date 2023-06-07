using MageCorp.ClashRoyaleApi.Client.Model.Enum;

namespace MageCorp.ClashRoyaleApi.Client.Model;

public class ClanMember
{
    public Arena? Arena { get; set; }
    public int ClanChestPoints { get; set; }
    public string? LastSeen { get; set; }
    public string? Tag { get; set; }
    public string? Name { get; set; }
    public RoleEnum Role { get; set; }
    public int ExpLevel { get; set; }
    public int Trophies { get; set; }
    public int ClanRank { get; set; }
    public int PreviousClanRank { get; set; }
    public int Donations { get; set; }
    public int DonationsReceived { get; set; }
}
