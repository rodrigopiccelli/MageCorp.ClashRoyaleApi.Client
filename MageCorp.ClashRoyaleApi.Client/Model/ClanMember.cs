using MageCorp.ClashRoyaleApi.Client.Converter;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using Newtonsoft.Json;

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
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? LastSeen { get; set; }
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
